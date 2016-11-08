// File created on 14.10.2016 at 16:39
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Yamaha_Remote_Console
{
	public class Functions
	{

		static bool debug = false;
		static bool disable_sleep = false;
		
		public static string get_basic_status(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"GET\"><Main_Zone><Basic_Status>GetParam</Basic_Status></Main_Zone></YAMAHA_AV>");
		}

		public static string[] extract_basic_infos(string basic_xml)
		{
			/*
			0 -> PowerState
			1 -> Volume
			2 -> Input
			3 -> Enhancer
			*/
			
			string[] basic_infos = new string[4];
			basic_infos[0] = basic_xml.Substring(basic_xml.IndexOf("<Power>")+7,(basic_xml.IndexOf("</Power>")-basic_xml.IndexOf("<Power>")-7));
			basic_infos[1] = basic_xml.Substring(basic_xml.IndexOf("<Val>")+5,(basic_xml.IndexOf("</Val>")-basic_xml.IndexOf("<Val>")-5));
			basic_infos[2] = basic_xml.Substring(basic_xml.IndexOf("<Input_Sel>")+11,(basic_xml.IndexOf("</Input_Sel>")-basic_xml.IndexOf("<Input_Sel>")-11));
			basic_infos[3] = basic_xml.Substring(basic_xml.IndexOf("<Enhancer>")+10,(basic_xml.IndexOf("</Enhancer>")-basic_xml.IndexOf("<Enhancer>")-10));
			return basic_infos;
		}
		
		public static string server_playback_stop(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Playback>Stop</Playback></Play_Control></SERVER></YAMAHA_AV>");
		}

		public static string server_playback_start(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Playback>Play</Playback></Play_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_playback_pause(string ip)
		{
			// The command is not different to resume, so calling pause while being paused will cause the receiver to resume
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Playback>Pause</Playback></Play_Control></SERVER></YAMAHA_AV>");
		}

		public static string server_playback_fwd(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Playback>Skip Fwd</Playback></Play_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_playback_rev(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Playback>Skip Rev</Playback></Play_Control></SERVER></YAMAHA_AV>");
		}		
		
		public static void server_playback_prev(string ip)
		{
			server_playback_rev(ip);
			if(!disable_sleep)
			{Thread.Sleep(100);}
			server_playback_rev(ip);
		}

		public static string server_shuffle_on(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control><Play_Mode><Shuffle>On</Shuffle></Play_Mode></Play_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_shuffle_off(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><Play_Control>><Play_Mode><Shuffle>Off</Shuffle></Play_Mode></Play_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_page_down(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><List_Control><Page>Down</Page></List_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_page_up(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><List_Control><Page>Up</Page></List_Control></SERVER></YAMAHA_AV>");
		}
		
		public static string server_get_list(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"GET\"><SERVER><List_Info>GetParam</List_Info></SERVER></YAMAHA_AV>");
		}
		
		public static string server_direct_sel(string ip, int listelement)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><SERVER><List_Control><Direct_Sel>Line_"+listelement+"</Direct_Sel></List_Control></SERVER></YAMAHA_AV>");
		}
		
		public static int server_determine_list_pos(string ip, string reply_xml, string tofind)
		{
			// Actually, the receiver is using XML, but since we can handle it better as string, we do handle it as string. 
			// Since Yamaha is using paging, we have to watch out for multiple lists 
			
			int max_line_start = reply_xml.IndexOf("<Max_Line>")+"<Max_Line>".Length;
			int max_line_end = reply_xml.IndexOf("</Max_Line>",max_line_start);
			int max_line = Convert.ToInt32(reply_xml.Substring(max_line_start,max_line_end-max_line_start));
			int pages = 0;
			
			if((max_line%8) != 0)
			{
				pages = (max_line/8)+1;
			}
			else
			{
				pages = (max_line/8);
			}
			
			
			
			
			while(pages != 0)
			{
							
				while(reply_xml.IndexOf("<Menu_Status>Busy</Menu_Status>") != -1)
				{	if(!disable_sleep)
					{Thread.Sleep(125);}
					reply_xml = server_get_list(ip);}
				
				// check if the current element is contained in the list 
				if(reply_xml.IndexOf(tofind) != -1)
				{
					// extract the listpos of it
					int listpos_strpos = reply_xml.IndexOf(tofind)-7;
					try
					{
					int listpos = Convert.ToInt32(reply_xml.Substring(listpos_strpos,1));
					if(debug)
					{Console.WriteLine("Returning: " + listpos);}
					return listpos;
					}
					catch(FormatException f)
					{}
					
				}
		
				// update the reply_xml to the next page
				server_page_down(ip);
				pages--;
				reply_xml = server_get_list(ip);
			}
			
			return -1;
		}
		
		public static void set_server(string ip, string[] input_commands)
		{
			// Ensure that input is SERVER
			set_input(ip,"SERVER");
			// Mute the autoplay
			server_playback_stop(ip);
			
			
			
			for(int i = 0; i<input_commands.Length; i++)
			{
				if(debug)
				{Console.WriteLine("Currently looking for: " + input_commands[i]);}
				string reply_xml = server_get_list(ip);
				
				while(reply_xml.IndexOf("<Menu_Status>Busy") != -1)
				{
				reply_xml = server_get_list(ip);
				}
				
				int list_pos = server_determine_list_pos(ip,reply_xml,input_commands[i]);
				
				if(list_pos == -1)
				{
					Console.WriteLine("Failed to set to: " + input_commands[i]);
					continue;
				}
				
				server_direct_sel(ip,list_pos);
				
				// The sleep shall ensure that the receiver did perform our action since there is no success or error state
				if(!disable_sleep)
				{Thread.Sleep(1000);}
				
			}
			
			
			
		}
		
		public static void fade_volume(string ip, string ss, string fs, string sts, string sls)
		{
			int start;
			int final;
			int step;
			int sleep;
			
			try
			{start = Convert.ToInt32(ss);
			final = Convert.ToInt32(fs);
			step = Convert.ToInt32(sts);
			sleep = Convert.ToInt32(sls);
			}
			catch(FormatException e)
			{
				Console.Error.WriteLine("[CRITICAL] Invalid arguments for fade_volume!");
				return;
			}
			
			if(final > start)
			{
				for(int i = start; i<= final; i=i+step)
				{
					set_volume(ip,i);
					Thread.Sleep(sleep);
				}
			}
			else
			{
				for(int i = start; i>= final; i-=step)
				{
					set_volume(ip,i);
					Thread.Sleep(sleep);
				}			
			}
		}
		
		public static string power_on(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><Main_Zone><Power_Control><Power>On</Power></Power_Control></Main_Zone></YAMAHA_AV>");
		}
		
		public static string power_off(string ip)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><Main_Zone><Power_Control><Power>Standby</Power></Power_Control></Main_Zone></YAMAHA_AV>");
		}
		
		public static string set_volume(string ip, int level)
		{
			if(level < YRGUI.MainForm.file_cfg.maximum_volume*-1)
			{
				level = YRGUI.MainForm.file_cfg.maximum_volume*-1;
			}
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><Main_Zone><Volume><Lvl><Val>-"+level+"</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>");
			
		}
		
		public static void set_volume_thread(string ip, int level)
		{
			postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><Main_Zone><Volume><Lvl><Val>-"+level+"</Val><Exp>1</Exp><Unit>dB</Unit></Lvl></Volume></Main_Zone></YAMAHA_AV>");
		}		
		
		public static string set_input(string ip, string input)
		{
			return postXMLData("http://"+ip+"/YamahaRemoteControl/ctrl","<YAMAHA_AV cmd=\"PUT\"><Main_Zone><Input><Input_Sel>"+input+"</Input_Sel></Input></Main_Zone></YAMAHA_AV>");
		}
		
		public static string postXMLData(string destinationUrl, string requestXml)
		{
			// This function was provided by AlliterativeAlice on Stackoverflow.com
			// http://stackoverflow.com/questions/17535872/
		    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
		    byte[] bytes;
		    bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
		    request.ContentType = "text/xml; encoding='utf-8'";
		    request.ContentLength = bytes.Length;
		    request.Method = "POST";
		    Stream requestStream = request.GetRequestStream();
		    requestStream.Write(bytes, 0, bytes.Length);
		    requestStream.Close();
		    HttpWebResponse response;
		    response = (HttpWebResponse)request.GetResponse();
		    if (response.StatusCode == HttpStatusCode.OK)
		    {
		        Stream responseStream = response.GetResponseStream();
		        string responseStr = new StreamReader(responseStream).ReadToEnd();
		        return responseStr;
		    }
		    return null;
		}
	}
}