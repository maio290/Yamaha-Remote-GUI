// File created on 08.11.2016 at 08:02
using System;
using System.IO;
using System.Windows.Forms;

namespace YRGUI
{
	/// <summary>
	/// Description of Config_File_Reader.
	/// </summary>
	public class Config_File_Reader
	{
		static string config_file = "\\YRC.cfg";
		static string cwd = Directory.GetCurrentDirectory();
		public bool exists = File.Exists(cwd+config_file);
		public YRC_Config file_cfg;
		
		
		public Config_File_Reader()
		{
			
			if(exists)
			{
				string[] cfg = File.ReadAllLines(cwd+config_file);
				
				string ip; int mv; int sp; int mp; int lp;
				
				// this thing is greedy, so please ensure that the config is always in the proper order
				
				ip = cfg[0].Substring(cfg[0].IndexOf("=")+1);
				mv = Convert.ToInt32(cfg[1].Substring(cfg[1].IndexOf("=")+1));
				sp = Convert.ToInt32(cfg[2].Substring(cfg[2].IndexOf("=")+1));
				mp = Convert.ToInt32(cfg[3].Substring(cfg[3].IndexOf("=")+1));
				lp = Convert.ToInt32(cfg[4].Substring(cfg[4].IndexOf("=")+1));
				
				file_cfg = new YRC_Config(ip,mv,sp,mp,lp);
				
			}
			
		}
		
		public YRC_Config get_cfg()
		{
				return this.file_cfg;
		}
		
	}
}
