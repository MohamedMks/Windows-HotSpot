/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 24-Mar-14
 * Time: 12:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HotSpotWindows
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Windowslist = new System.Windows.Forms.ComboBox();
			this.btnactivate = new System.Windows.Forms.Button();
			this.btnremove = new System.Windows.Forms.Button();
			this.btnst = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbltime = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblver = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnupdate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.PassBox = new System.Windows.Forms.TextBox();
			this.RePassBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BoxShowPass = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.automaticUpdater1 = new wyDay.Controls.AutomaticUpdater();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).BeginInit();
			this.SuspendLayout();
			// 
			// Windowslist
			// 
			this.Windowslist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Windowslist.Enabled = false;
			this.Windowslist.FormattingEnabled = true;
			this.Windowslist.Location = new System.Drawing.Point(125, 52);
			this.Windowslist.MaxDropDownItems = 10;
			this.Windowslist.Name = "Windowslist";
			this.Windowslist.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Windowslist.Size = new System.Drawing.Size(127, 21);
			this.Windowslist.TabIndex = 2;
			this.Windowslist.Text = "SECURED";
			this.Windowslist.SelectedIndexChanged += new System.EventHandler(this.WindowslistSelectedIndexChanged);
			// 
			// btnactivate
			// 
			this.btnactivate.Enabled = false;
			this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnactivate.ForeColor = System.Drawing.Color.Red;
			this.btnactivate.Image = ((System.Drawing.Image)(resources.GetObject("btnactivate.Image")));
			this.btnactivate.Location = new System.Drawing.Point(265, 131);
			this.btnactivate.Name = "btnactivate";
			this.btnactivate.Size = new System.Drawing.Size(96, 30);
			this.btnactivate.TabIndex = 3;
			this.btnactivate.Text = "Save info";
			this.btnactivate.UseVisualStyleBackColor = true;
			this.btnactivate.Click += new System.EventHandler(this.BtnactivateClick);
			// 
			// btnremove
			// 
			this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnremove.Image = ((System.Drawing.Image)(resources.GetObject("btnremove.Image")));
			this.btnremove.Location = new System.Drawing.Point(70, 182);
			this.btnremove.Name = "btnremove";
			this.btnremove.Size = new System.Drawing.Size(138, 45);
			this.btnremove.TabIndex = 4;
			this.btnremove.Text = "STOP";
			this.btnremove.UseVisualStyleBackColor = true;
			this.btnremove.Click += new System.EventHandler(this.BtnremoveClick);
			// 
			// btnst
			// 
			this.btnst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnst.Image = ((System.Drawing.Image)(resources.GetObject("btnst.Image")));
			this.btnst.Location = new System.Drawing.Point(214, 182);
			this.btnst.Name = "btnst";
			this.btnst.Size = new System.Drawing.Size(147, 45);
			this.btnst.TabIndex = 5;
			this.btnst.Text = "START";
			this.btnst.UseVisualStyleBackColor = true;
			this.btnst.Click += new System.EventHandler(this.BtnstClick);
			// 
			// btnexit
			// 
			this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
			this.btnexit.Location = new System.Drawing.Point(12, 182);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(52, 45);
			this.btnexit.TabIndex = 7;
			this.btnexit.Text = "EXIT";
			this.btnexit.UseVisualStyleBackColor = true;
			this.btnexit.Click += new System.EventHandler(this.BtnexitClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripStatusLabel2,
									this.lbltime,
									this.toolStripStatusLabel3,
									this.lblver,
									this.toolStripStatusLabel4});
			this.statusStrip1.Location = new System.Drawing.Point(0, 250);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip1.Size = new System.Drawing.Size(370, 24);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arabic Typesetting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 19);
			this.toolStripStatusLabel1.Text = "By: MohamedMks";
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1Click);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 19);
			this.toolStripStatusLabel2.Text = "|";
			// 
			// lbltime
			// 
			this.lbltime.Name = "lbltime";
			this.lbltime.Size = new System.Drawing.Size(31, 19);
			this.lbltime.Text = "time";
			this.lbltime.Click += new System.EventHandler(this.LbltimeClick);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 19);
			this.toolStripStatusLabel3.Text = "|";
			// 
			// lblver
			// 
			this.lblver.Name = "lblver";
			this.lblver.Size = new System.Drawing.Size(23, 19);
			this.lblver.Text = "ver";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 19);
			this.toolStripStatusLabel4.Text = "|";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(52, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "MODE";
			// 
			// btnupdate
			// 
			this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnupdate.BackColor = System.Drawing.Color.Transparent;
			this.btnupdate.Location = new System.Drawing.Point(0, 253);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(44, 21);
			this.btnupdate.TabIndex = 15;
			this.btnupdate.Text = "تحديث";
			this.btnupdate.UseVisualStyleBackColor = false;
			this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Wifi Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Password";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(125, 5);
			this.NameBox.MaxLength = 20;
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(236, 20);
			this.NameBox.TabIndex = 18;
			// 
			// PassBox
			// 
			this.PassBox.Location = new System.Drawing.Point(125, 79);
			this.PassBox.MaxLength = 20;
			this.PassBox.Name = "PassBox";
			this.PassBox.PasswordChar = '*';
			this.PassBox.Size = new System.Drawing.Size(236, 20);
			this.PassBox.TabIndex = 19;
			this.PassBox.TextChanged += new System.EventHandler(this.PassBoxTextChanged);
			// 
			// RePassBox
			// 
			this.RePassBox.Enabled = false;
			this.RePassBox.Location = new System.Drawing.Point(125, 105);
			this.RePassBox.MaxLength = 20;
			this.RePassBox.Name = "RePassBox";
			this.RePassBox.PasswordChar = '*';
			this.RePassBox.Size = new System.Drawing.Size(236, 20);
			this.RePassBox.TabIndex = 20;
			this.RePassBox.TextChanged += new System.EventHandler(this.RePassBoxTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 109);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Retry Pass";
			// 
			// BoxShowPass
			// 
			this.BoxShowPass.BackColor = System.Drawing.Color.Transparent;
			this.BoxShowPass.Location = new System.Drawing.Point(125, 138);
			this.BoxShowPass.Name = "BoxShowPass";
			this.BoxShowPass.Size = new System.Drawing.Size(104, 19);
			this.BoxShowPass.TabIndex = 22;
			this.BoxShowPass.Text = "Show Password";
			this.BoxShowPass.UseVisualStyleBackColor = false;
			this.BoxShowPass.CheckedChanged += new System.EventHandler(this.BoxShowPassCheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(125, 28);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "No spaces please*";
			// 
			// automaticUpdater1
			// 
			this.automaticUpdater1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.automaticUpdater1.BackColor = System.Drawing.Color.Transparent;
			this.automaticUpdater1.ContainerForm = this;
			this.automaticUpdater1.GUID = "69f9d41d-99e0-49b9-87c4-1b6508baa263";
			this.automaticUpdater1.Location = new System.Drawing.Point(344, 231);
			this.automaticUpdater1.Name = "automaticUpdater1";
			this.automaticUpdater1.Size = new System.Drawing.Size(16, 16);
			this.automaticUpdater1.TabIndex = 24;
			this.automaticUpdater1.wyUpdateCommandline = null;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(370, 274);
			this.Controls.Add(this.automaticUpdater1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BoxShowPass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.RePassBox);
			this.Controls.Add(this.PassBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.btnst);
			this.Controls.Add(this.btnremove);
			this.Controls.Add(this.btnactivate);
			this.Controls.Add(this.Windowslist);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(386, 313);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(386, 313);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Hotspot";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private wyDay.Controls.AutomaticUpdater automaticUpdater1;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel lblver;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripStatusLabel lbltime;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Button btnexit;
		private System.Windows.Forms.Button btnactivate;
		private System.Windows.Forms.Button btnremove;
		private System.Windows.Forms.Button btnst;
		private System.Windows.Forms.ComboBox Windowslist;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox PassBox;
		private System.Windows.Forms.TextBox RePassBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox BoxShowPass;
		private System.Windows.Forms.Label label5;
	}
}
