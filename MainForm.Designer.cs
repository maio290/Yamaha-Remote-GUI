// File created on 07.11.2016 at 09:37
namespace YRGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.CB_Repeat_One = new System.Windows.Forms.CheckBox();
			this.CB_Repeat_All = new System.Windows.Forms.CheckBox();
			this.CB_Repeat_Off = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CB_Shuffle_Off = new System.Windows.Forms.CheckBox();
			this.CB_Shuffle_On = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CB_Enhancer = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.STST_Label_IP = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.STST_Label_PowerState = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.STST_Label_Input = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.STST_Label_Volume = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.BT_Power_OFF = new System.Windows.Forms.Button();
			this.BT_Power_ON = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.TB_MaxVol = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_Volume_Bar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.TRB_Volume_Free = new System.Windows.Forms.TrackBar();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.BT_Volume_Loud = new System.Windows.Forms.Button();
			this.BT_Volume_Medium = new System.Windows.Forms.Button();
			this.BT_Volume_Silent = new System.Windows.Forms.Button();
			this.BT_Volume_Mute = new System.Windows.Forms.Button();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CB_Input = new System.Windows.Forms.ComboBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.Input_XML = new System.Data.DataSet();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TRB_Volume_Free)).BeginInit();
			this.groupBox7.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Input_XML)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(653, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Options";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.CB_Repeat_One);
			this.groupBox4.Controls.Add(this.CB_Repeat_All);
			this.groupBox4.Controls.Add(this.CB_Repeat_Off);
			this.groupBox4.Location = new System.Drawing.Point(6, 116);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(188, 113);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Repeat";
			// 
			// CB_Repeat_One
			// 
			this.CB_Repeat_One.Location = new System.Drawing.Point(6, 19);
			this.CB_Repeat_One.Name = "CB_Repeat_One";
			this.CB_Repeat_One.Size = new System.Drawing.Size(104, 26);
			this.CB_Repeat_One.TabIndex = 2;
			this.CB_Repeat_One.Text = "One";
			this.CB_Repeat_One.UseVisualStyleBackColor = true;
			// 
			// CB_Repeat_All
			// 
			this.CB_Repeat_All.Location = new System.Drawing.Point(6, 51);
			this.CB_Repeat_All.Name = "CB_Repeat_All";
			this.CB_Repeat_All.Size = new System.Drawing.Size(104, 24);
			this.CB_Repeat_All.TabIndex = 1;
			this.CB_Repeat_All.Text = "All";
			this.CB_Repeat_All.UseVisualStyleBackColor = true;
			// 
			// CB_Repeat_Off
			// 
			this.CB_Repeat_Off.Location = new System.Drawing.Point(6, 81);
			this.CB_Repeat_Off.Name = "CB_Repeat_Off";
			this.CB_Repeat_Off.Size = new System.Drawing.Size(104, 24);
			this.CB_Repeat_Off.TabIndex = 0;
			this.CB_Repeat_Off.Text = "Off";
			this.CB_Repeat_Off.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CB_Shuffle_Off);
			this.groupBox3.Controls.Add(this.CB_Shuffle_On);
			this.groupBox3.Location = new System.Drawing.Point(6, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(188, 91);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Shuffle";
			// 
			// CB_Shuffle_Off
			// 
			this.CB_Shuffle_Off.Location = new System.Drawing.Point(6, 49);
			this.CB_Shuffle_Off.Name = "CB_Shuffle_Off";
			this.CB_Shuffle_Off.Size = new System.Drawing.Size(104, 24);
			this.CB_Shuffle_Off.TabIndex = 1;
			this.CB_Shuffle_Off.Text = "Off";
			this.CB_Shuffle_Off.UseVisualStyleBackColor = true;
			// 
			// CB_Shuffle_On
			// 
			this.CB_Shuffle_On.Location = new System.Drawing.Point(6, 19);
			this.CB_Shuffle_On.Name = "CB_Shuffle_On";
			this.CB_Shuffle_On.Size = new System.Drawing.Size(104, 24);
			this.CB_Shuffle_On.TabIndex = 0;
			this.CB_Shuffle_On.Text = "On";
			this.CB_Shuffle_On.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CB_Enhancer);
			this.groupBox2.Location = new System.Drawing.Point(653, 273);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 150);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sound Options";
			// 
			// CB_Enhancer
			// 
			this.CB_Enhancer.Location = new System.Drawing.Point(6, 19);
			this.CB_Enhancer.Name = "CB_Enhancer";
			this.CB_Enhancer.Size = new System.Drawing.Size(104, 24);
			this.CB_Enhancer.TabIndex = 0;
			this.CB_Enhancer.Text = "Enhancer";
			this.CB_Enhancer.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.STST_Label_IP,
									this.toolStripStatusLabel1,
									this.toolStripStatusLabel2,
									this.STST_Label_PowerState,
									this.toolStripStatusLabel3,
									this.toolStripStatusLabel4,
									this.STST_Label_Input,
									this.toolStripStatusLabel5,
									this.toolStripStatusLabel6,
									this.STST_Label_Volume});
			this.statusStrip1.Location = new System.Drawing.Point(0, 426);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(865, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// STST_Label_IP
			// 
			this.STST_Label_IP.Name = "STST_Label_IP";
			this.STST_Label_IP.Size = new System.Drawing.Size(17, 17);
			this.STST_Label_IP.Text = "IP";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel1.Text = "|";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 17);
			this.toolStripStatusLabel2.Text = "Power-State:";
			// 
			// STST_Label_PowerState
			// 
			this.STST_Label_PowerState.Name = "STST_Label_PowerState";
			this.STST_Label_PowerState.Size = new System.Drawing.Size(66, 17);
			this.STST_Label_PowerState.Text = "PowerState";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel3.Text = "|";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(38, 17);
			this.toolStripStatusLabel4.Text = "Input:";
			// 
			// STST_Label_Input
			// 
			this.STST_Label_Input.Name = "STST_Label_Input";
			this.STST_Label_Input.Size = new System.Drawing.Size(35, 17);
			this.STST_Label_Input.Text = "Input";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel5.Text = "|";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(50, 17);
			this.toolStripStatusLabel6.Text = "Volume:";
			// 
			// STST_Label_Volume
			// 
			this.STST_Label_Volume.Name = "STST_Label_Volume";
			this.STST_Label_Volume.Size = new System.Drawing.Size(47, 17);
			this.STST_Label_Volume.Text = "Volume";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.overviewToolStripMenuItem,
									this.configToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(865, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// overviewToolStripMenuItem
			// 
			this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
			this.overviewToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.overviewToolStripMenuItem.Text = "Overview";
			this.overviewToolStripMenuItem.Click += new System.EventHandler(this.Overview_Strip_Click);
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItemClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.BT_Power_OFF);
			this.groupBox5.Controls.Add(this.BT_Power_ON);
			this.groupBox5.Location = new System.Drawing.Point(12, 27);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(347, 62);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Power Options";
			// 
			// BT_Power_OFF
			// 
			this.BT_Power_OFF.Location = new System.Drawing.Point(266, 19);
			this.BT_Power_OFF.Name = "BT_Power_OFF";
			this.BT_Power_OFF.Size = new System.Drawing.Size(75, 23);
			this.BT_Power_OFF.TabIndex = 1;
			this.BT_Power_OFF.Text = "Off";
			this.BT_Power_OFF.UseVisualStyleBackColor = true;
			this.BT_Power_OFF.Click += new System.EventHandler(this.BT_Power_OFF_Click);
			// 
			// BT_Power_ON
			// 
			this.BT_Power_ON.Location = new System.Drawing.Point(6, 19);
			this.BT_Power_ON.Name = "BT_Power_ON";
			this.BT_Power_ON.Size = new System.Drawing.Size(75, 23);
			this.BT_Power_ON.TabIndex = 0;
			this.BT_Power_ON.Text = "On";
			this.BT_Power_ON.UseVisualStyleBackColor = true;
			this.BT_Power_ON.Click += new System.EventHandler(this.BT_Power_ON_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.TB_MaxVol);
			this.groupBox6.Controls.Add(this.label2);
			this.groupBox6.Controls.Add(this.TB_Volume_Bar);
			this.groupBox6.Controls.Add(this.label1);
			this.groupBox6.Controls.Add(this.groupBox8);
			this.groupBox6.Controls.Add(this.groupBox7);
			this.groupBox6.Location = new System.Drawing.Point(12, 95);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(347, 328);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Volume Options";
			// 
			// TB_MaxVol
			// 
			this.TB_MaxVol.Location = new System.Drawing.Point(140, 214);
			this.TB_MaxVol.Name = "TB_MaxVol";
			this.TB_MaxVol.ReadOnly = true;
			this.TB_MaxVol.Size = new System.Drawing.Size(75, 20);
			this.TB_MaxVol.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 37);
			this.label2.TabIndex = 4;
			this.label2.Text = "Maximum Volume:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TB_Volume_Bar
			// 
			this.TB_Volume_Bar.Location = new System.Drawing.Point(140, 177);
			this.TB_Volume_Bar.Name = "TB_Volume_Bar";
			this.TB_Volume_Bar.ReadOnly = true;
			this.TB_Volume_Bar.Size = new System.Drawing.Size(75, 20);
			this.TB_Volume_Bar.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current Value:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.TRB_Volume_Free);
			this.groupBox8.Location = new System.Drawing.Point(12, 85);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(329, 80);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Free Volume";
			// 
			// TRB_Volume_Free
			// 
			this.TRB_Volume_Free.LargeChange = 50;
			this.TRB_Volume_Free.Location = new System.Drawing.Point(6, 19);
			this.TRB_Volume_Free.Maximum = -350;
			this.TRB_Volume_Free.Minimum = -805;
			this.TRB_Volume_Free.Name = "TRB_Volume_Free";
			this.TRB_Volume_Free.Size = new System.Drawing.Size(312, 45);
			this.TRB_Volume_Free.SmallChange = 5;
			this.TRB_Volume_Free.TabIndex = 0;
			this.TRB_Volume_Free.TickFrequency = 50;
			this.TRB_Volume_Free.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.TRB_Volume_Free.Value = -450;
			this.TRB_Volume_Free.Scroll += new System.EventHandler(this.TRB_Volume_Free_Change);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.BT_Volume_Loud);
			this.groupBox7.Controls.Add(this.BT_Volume_Medium);
			this.groupBox7.Controls.Add(this.BT_Volume_Silent);
			this.groupBox7.Controls.Add(this.BT_Volume_Mute);
			this.groupBox7.Location = new System.Drawing.Point(6, 23);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(335, 56);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Presets";
			// 
			// BT_Volume_Loud
			// 
			this.BT_Volume_Loud.Location = new System.Drawing.Point(249, 19);
			this.BT_Volume_Loud.Name = "BT_Volume_Loud";
			this.BT_Volume_Loud.Size = new System.Drawing.Size(75, 23);
			this.BT_Volume_Loud.TabIndex = 3;
			this.BT_Volume_Loud.Text = "Loud";
			this.BT_Volume_Loud.UseVisualStyleBackColor = true;
			this.BT_Volume_Loud.Click += new System.EventHandler(this.BT_Volume_LoudClick);
			// 
			// BT_Volume_Medium
			// 
			this.BT_Volume_Medium.Location = new System.Drawing.Point(168, 19);
			this.BT_Volume_Medium.Name = "BT_Volume_Medium";
			this.BT_Volume_Medium.Size = new System.Drawing.Size(75, 23);
			this.BT_Volume_Medium.TabIndex = 2;
			this.BT_Volume_Medium.Text = "Medium";
			this.BT_Volume_Medium.UseVisualStyleBackColor = true;
			this.BT_Volume_Medium.Click += new System.EventHandler(this.BT_Volume_MediumClick);
			// 
			// BT_Volume_Silent
			// 
			this.BT_Volume_Silent.Location = new System.Drawing.Point(87, 19);
			this.BT_Volume_Silent.Name = "BT_Volume_Silent";
			this.BT_Volume_Silent.Size = new System.Drawing.Size(75, 23);
			this.BT_Volume_Silent.TabIndex = 1;
			this.BT_Volume_Silent.Text = "Silent";
			this.BT_Volume_Silent.UseVisualStyleBackColor = true;
			this.BT_Volume_Silent.Click += new System.EventHandler(this.BT_Volume_SilentClick);
			// 
			// BT_Volume_Mute
			// 
			this.BT_Volume_Mute.Location = new System.Drawing.Point(6, 19);
			this.BT_Volume_Mute.Name = "BT_Volume_Mute";
			this.BT_Volume_Mute.Size = new System.Drawing.Size(75, 23);
			this.BT_Volume_Mute.TabIndex = 0;
			this.BT_Volume_Mute.Text = "Mute";
			this.BT_Volume_Mute.UseVisualStyleBackColor = true;
			this.BT_Volume_Mute.Click += new System.EventHandler(this.BT_Volume_Mute_Click);
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.label3);
			this.groupBox9.Controls.Add(this.CB_Input);
			this.groupBox9.Location = new System.Drawing.Point(365, 27);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(282, 62);
			this.groupBox9.TabIndex = 6;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Input";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Input Selector:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CB_Input
			// 
			this.CB_Input.DataSource = this.bindingSource1;
			this.CB_Input.FormattingEnabled = true;
			this.CB_Input.Location = new System.Drawing.Point(96, 21);
			this.CB_Input.Name = "CB_Input";
			this.CB_Input.Size = new System.Drawing.Size(180, 21);
			this.CB_Input.TabIndex = 0;
			this.CB_Input.SelectedIndexChanged += new System.EventHandler(this.CB_InputSelectedIndexChanged);
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.Input_XML;
			this.bindingSource1.Position = 0;
			// 
			// Input_XML
			// 
			this.Input_XML.CaseSensitive = true;
			this.Input_XML.DataSetName = "Input_XML_DS";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 448);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Yamaha Remote GUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TRB_Volume_Free)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Input_XML)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel STST_Label_Volume;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel STST_Label_Input;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel STST_Label_PowerState;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.CheckBox CB_Enhancer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CB_Input;
		private System.Data.DataSet Input_XML;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_MaxVol;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_Volume_Bar;
		private System.Windows.Forms.Button BT_Volume_Mute;
		private System.Windows.Forms.Button BT_Volume_Silent;
		private System.Windows.Forms.Button BT_Volume_Medium;
		private System.Windows.Forms.Button BT_Volume_Loud;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TrackBar TRB_Volume_Free;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button BT_Power_ON;
		private System.Windows.Forms.Button BT_Power_OFF;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripStatusLabel STST_Label_IP;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.CheckBox CB_Shuffle_On;
		private System.Windows.Forms.CheckBox CB_Shuffle_Off;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox CB_Repeat_Off;
		private System.Windows.Forms.CheckBox CB_Repeat_All;
		private System.Windows.Forms.CheckBox CB_Repeat_One;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
