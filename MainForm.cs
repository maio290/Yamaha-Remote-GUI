// File created on 07.11.2016 at 09:37
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace YRGUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// class vars
		Config_File_Reader cfg_reader;
		public static YRC_Config file_cfg;
		private bool killswitch = false;
		Thread update_looper;
		
		string IP;
		int maximum_volume;
		int sp;
		int mp;
		int lp;
				
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cfg_reader = new Config_File_Reader();
			Input_XML.ReadXml("input_list.xml");
			bindingSource1.DataSource = Input_XML.Tables[0];
			CB_Input.ValueMember = "value";
			CB_Input.DisplayMember = "name";
			if(cfg_reader.exists)
			{
				file_cfg = cfg_reader.get_cfg();
				maximum_volume = file_cfg.maximum_volume;
				TRB_Volume_Free.Maximum = maximum_volume;
				TB_MaxVol.Text = maximum_volume.ToString();
				IP = file_cfg.ip;
				sp = file_cfg.silent_preset;
				mp = file_cfg.medium_preset;
				lp = file_cfg.loud_preset;
				update_looper = get_new_basic_updater();
				update_looper.Start();
			}
			else
			{
				MessageBox.Show("No config file detected - please setup YRGUI","Missing Config-File",MessageBoxButtons.OK, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
				Config cfg_form = new Config();
				cfg_form.Show();
			}
			
			STST_Label_IP.Text = IP;
			
			
		}
		
		void TRB_Volume_Free_Change(object sender, EventArgs e)
		{
			/*
			try
			{
			if(vol_change.IsAlive)
			{
				vol_change.Abort();
			}
			}
			catch(NullReferenceException nre_vc)
			{}
			*/
			
			TB_Volume_Bar.Text = TRB_Volume_Free.Value.ToString();
			Yamaha_Remote_Console.Functions.set_volume_thread(IP,TRB_Volume_Free.Value*-1);
			/*
			vol_change = new Thread(()=>Yamaha_Remote_Console.Functions.set_volume_thread("192.168.178.54",TRB_Volume_Free.Value*-1));
			vol_change.Start();
			*/
			
			
		}
		
		Thread get_new_basic_updater()
		{
			return new Thread(loop_basic_infos);
		}

		void loop_basic_infos()
		{
			while(!killswitch)
			{
				update_and_get_basic_infos();
				Thread.Sleep(1000);
			}
		}
			
		void update_and_get_basic_infos()
		{
			string[] infos = Yamaha_Remote_Console.Functions.extract_basic_infos(Yamaha_Remote_Console.Functions.get_basic_status(IP));
			
			// Update Power-State
			STST_Label_PowerState.Text = infos[0];
			switch(infos[0])
			{
				case "On":
				STST_Label_PowerState.ForeColor = Color.Green;
				break;
				case "Standby":
				STST_Label_PowerState.ForeColor = Color.Orange;
				break;
			}
			// Update Volume
			TRB_Volume_Free.Value = Convert.ToInt32(infos[1]);
			TB_Volume_Bar.Text = infos[1];
			STST_Label_Volume.Text = infos[1];
			
			// Update Input
			STST_Label_Input.Text = infos[2];
			
			// Update Enhancer
			switch(infos[3])
			{
				case "On":
				CB_Enhancer.Checked = true;
				break;
				case "Off":
				CB_Enhancer.Checked = false;
				break;
			}			
					
			
		}
		
		void BT_Power_ON_Click(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.power_on(IP);
		}
		
		void BT_Power_OFF_Click(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.power_off(IP);
		}
		
		void Overview_Strip_Click(object sender, EventArgs e)
		{
			// do nothing
		}
		
		void ConfigToolStripMenuItemClick(object sender, EventArgs e)
		{
			Config config_form = new Config();
			config_form.Show();
		}
		
		void BT_Volume_Mute_Click(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.set_volume(IP,805);
			TRB_Volume_Free.Value = -805;
			TB_Volume_Bar.Text = "-805";
		}
		
		void BT_Volume_SilentClick(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.set_volume(IP,sp*-1);
			TRB_Volume_Free.Value = sp;
			TB_Volume_Bar.Text = sp.ToString();
		}
		
		void BT_Volume_MediumClick(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.set_volume(IP,mp*-1);
			TRB_Volume_Free.Value = mp;
			TB_Volume_Bar.Text = mp.ToString();			
		}
		
		void BT_Volume_LoudClick(object sender, EventArgs e)
		{
			Yamaha_Remote_Console.Functions.set_volume(IP,lp*-1);
			TRB_Volume_Free.Value = lp;
			TB_Volume_Bar.Text = lp.ToString();						
		}
		

		
		void CB_InputSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			Yamaha_Remote_Console.Functions.set_input(IP,this.CB_Input.SelectedValue.ToString());
			}
			catch(NullReferenceException)
			{}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			// define something on startup, if you want to			
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			killswitch = true;
			try
			{
			update_looper.Abort();
			}
			catch(NullReferenceException)
			{}
			catch(ThreadAbortException)
			{}
		}
	}
}
