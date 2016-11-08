// File created on 07.11.2016 at 20:21
using System;
using System.Drawing;
using System.Windows.Forms;

namespace YRGUI
{
	/// <summary>
	/// Description of Config.
	/// </summary>
	public partial class Config : Form
	{
		public Config()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ConfigLoad(object sender, EventArgs e)
		{
			Config_File_Reader cfg_reader = new Config_File_Reader();
			if(cfg_reader.exists)
			{
				YRC_Config file_cfg = cfg_reader.get_cfg();
				this.TB_IP.Text = file_cfg.ip;
				this.TB_MV.Text = file_cfg.maximum_volume.ToString();
				this.TB_SP.Text = file_cfg.silent_preset.ToString();
				this.TB_MP.Text = file_cfg.medium_preset.ToString();
				this.TB_LP.Text = file_cfg.loud_preset.ToString();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Config_File_Writer cfg_writer = new Config_File_Writer(this.TB_IP.Text,this.TB_MV.Text,this.TB_SP.Text,this.TB_MP.Text,this.TB_LP.Text);
			this.Close();
			Application.Restart();
		}
	}
}
