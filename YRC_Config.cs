// File created on 08.11.2016 at 07:56
using System;

namespace YRGUI
{
	/// <summary>
	/// Description of YRC_Config.
	/// </summary>
	public class YRC_Config
	{
		public string ip;
		public int maximum_volume;
		public int silent_preset;
		public int medium_preset;
		public int loud_preset;
		
		public YRC_Config(string ip, int mv, int sp, int mp, int lp)
		{					
			this.ip = ip;
			this.maximum_volume = mv;
			this.silent_preset = sp;
			this.medium_preset = mp;
			this.loud_preset = lp;
		}
	}
}
