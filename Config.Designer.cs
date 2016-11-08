// File created on 07.11.2016 at 20:21
namespace YRGUI
{
	partial class Config
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TB_IP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.TB_LP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TB_MP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TB_SP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TB_MV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BT_SaveChanges = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TB_IP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Receiver Config";
			// 
			// TB_IP
			// 
			this.TB_IP.Location = new System.Drawing.Point(41, 18);
			this.TB_IP.Name = "TB_IP";
			this.TB_IP.Size = new System.Drawing.Size(215, 20);
			this.TB_IP.TabIndex = 1;
			this.TB_IP.Text = "xxx.xxx.xxx.xxx";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(12, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(262, 147);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Function Config";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.TB_LP);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.TB_MP);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.TB_SP);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.TB_MV);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(6, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(226, 115);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Volume Config";
			// 
			// TB_LP
			// 
			this.TB_LP.Location = new System.Drawing.Point(112, 87);
			this.TB_LP.Name = "TB_LP";
			this.TB_LP.Size = new System.Drawing.Size(100, 20);
			this.TB_LP.TabIndex = 7;
			this.TB_LP.Text = "-250";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Loud Preset:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TB_MP
			// 
			this.TB_MP.Location = new System.Drawing.Point(112, 64);
			this.TB_MP.Name = "TB_MP";
			this.TB_MP.Size = new System.Drawing.Size(100, 20);
			this.TB_MP.TabIndex = 5;
			this.TB_MP.Text = "-400";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Medium Preset:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TB_SP
			// 
			this.TB_SP.Location = new System.Drawing.Point(112, 41);
			this.TB_SP.Name = "TB_SP";
			this.TB_SP.Size = new System.Drawing.Size(100, 20);
			this.TB_SP.TabIndex = 3;
			this.TB_SP.Text = "-600";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Silent Preset:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TB_MV
			// 
			this.TB_MV.Location = new System.Drawing.Point(112, 18);
			this.TB_MV.Name = "TB_MV";
			this.TB_MV.Size = new System.Drawing.Size(100, 20);
			this.TB_MV.TabIndex = 1;
			this.TB_MV.Text = "-200";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Maximum Volume:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BT_SaveChanges
			// 
			this.BT_SaveChanges.Location = new System.Drawing.Point(12, 286);
			this.BT_SaveChanges.Name = "BT_SaveChanges";
			this.BT_SaveChanges.Size = new System.Drawing.Size(268, 23);
			this.BT_SaveChanges.TabIndex = 2;
			this.BT_SaveChanges.Text = "Save Changes";
			this.BT_SaveChanges.UseVisualStyleBackColor = true;
			this.BT_SaveChanges.Click += new System.EventHandler(this.Button1Click);
			// 
			// Config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 321);
			this.Controls.Add(this.BT_SaveChanges);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Config";
			this.Text = "Config";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ConfigLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BT_SaveChanges;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TB_SP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TB_MP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TB_LP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_MV;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_IP;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
