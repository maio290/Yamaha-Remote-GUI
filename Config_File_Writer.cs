// File created on 08.11.2016 at 11:16
using System;
using System.IO;

namespace YRGUI
{
	/// <summary>
	/// Description of Config_File_Writer.
	/// </summary>
	public class Config_File_Writer
	{
		static string config_file = "\\YRC.cfg";
		static string cwd = Directory.GetCurrentDirectory();
		
		public Config_File_Writer(string ip, string mv, string sp, string mp, string lp)
		{
			StreamWriter str_write = new StreamWriter(cwd+config_file,false);
			str_write.WriteLine("ip="+ip);
			str_write.WriteLine("max_vol="+mv);
			str_write.WriteLine("silent_preset="+sp);
			str_write.WriteLine("medium_preset="+mp);
			str_write.WriteLine("loud_preset="+lp);
			str_write.Close();
		}
	}
}
