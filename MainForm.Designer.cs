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
			System.Windows.Forms.ComboBox Windowslist;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnactivate = new System.Windows.Forms.Button();
			this.btnremove = new System.Windows.Forms.Button();
			this.btnst = new System.Windows.Forms.Button();
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
			this.lblpassCounter = new System.Windows.Forms.Label();
			this.lblRePassCounter = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.adapter_list = new System.Windows.Forms.ComboBox();
			this.text_result = new System.Windows.Forms.TextBox();
			this.tbn_info = new System.Windows.Forms.Button();
			this.data_table = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label7 = new System.Windows.Forms.Label();
			Windowslist = new System.Windows.Forms.ComboBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
			this.SuspendLayout();
			// 
			// Windowslist
			// 
			resources.ApplyResources(Windowslist, "Windowslist");
			Windowslist.Name = "Windowslist";
			// 
			// btnactivate
			// 
			resources.ApplyResources(this.btnactivate, "btnactivate");
			this.btnactivate.ForeColor = System.Drawing.Color.Red;
			this.btnactivate.Name = "btnactivate";
			this.btnactivate.UseVisualStyleBackColor = true;
			this.btnactivate.Click += new System.EventHandler(this.BtnactivateClick);
			// 
			// btnremove
			// 
			resources.ApplyResources(this.btnremove, "btnremove");
			this.btnremove.Name = "btnremove";
			this.btnremove.UseVisualStyleBackColor = true;
			this.btnremove.Click += new System.EventHandler(this.BtnremoveClick);
			// 
			// btnst
			// 
			resources.ApplyResources(this.btnst, "btnst");
			this.btnst.Name = "btnst";
			this.btnst.UseVisualStyleBackColor = true;
			this.btnst.Click += new System.EventHandler(this.BtnstClick);
			// 
			// statusStrip1
			// 
			resources.ApplyResources(this.statusStrip1, "statusStrip1");
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabel2,
			this.lbltime,
			this.toolStripStatusLabel3,
			this.lblver,
			this.toolStripStatusLabel4});
			this.statusStrip1.Name = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
			// 
			// lbltime
			// 
			this.lbltime.Name = "lbltime";
			resources.ApplyResources(this.lbltime, "lbltime");
			this.lbltime.Click += new System.EventHandler(this.LbltimeClick);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
			// 
			// lblver
			// 
			this.lblver.Name = "lblver";
			resources.ApplyResources(this.lblver, "lblver");
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 30000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Name = "label1";
			// 
			// btnupdate
			// 
			resources.ApplyResources(this.btnupdate, "btnupdate");
			this.btnupdate.BackColor = System.Drawing.Color.Transparent;
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.UseVisualStyleBackColor = false;
			this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Name = "label3";
			// 
			// NameBox
			// 
			resources.ApplyResources(this.NameBox, "NameBox");
			this.NameBox.Name = "NameBox";
			this.NameBox.TextChanged += new System.EventHandler(this.NameBoxTextChanged);
			// 
			// PassBox
			// 
			resources.ApplyResources(this.PassBox, "PassBox");
			this.PassBox.Name = "PassBox";
			this.PassBox.TextChanged += new System.EventHandler(this.PassBoxTextChanged);
			// 
			// RePassBox
			// 
			resources.ApplyResources(this.RePassBox, "RePassBox");
			this.RePassBox.Name = "RePassBox";
			this.RePassBox.TextChanged += new System.EventHandler(this.RePassBoxTextChanged);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Name = "label4";
			// 
			// BoxShowPass
			// 
			this.BoxShowPass.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.BoxShowPass, "BoxShowPass");
			this.BoxShowPass.Name = "BoxShowPass";
			this.BoxShowPass.UseVisualStyleBackColor = false;
			this.BoxShowPass.CheckedChanged += new System.EventHandler(this.BoxShowPassCheckedChanged);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Name = "label5";
			// 
			// automaticUpdater1
			// 
			resources.ApplyResources(this.automaticUpdater1, "automaticUpdater1");
			this.automaticUpdater1.BackColor = System.Drawing.Color.Transparent;
			this.automaticUpdater1.ContainerForm = this;
			this.automaticUpdater1.GUID = "69f9d41d-99e0-49b9-87c4-1b6508baa263";
			this.automaticUpdater1.Name = "automaticUpdater1";
			this.automaticUpdater1.wyUpdateCommandline = null;
			// 
			// lblpassCounter
			// 
			resources.ApplyResources(this.lblpassCounter, "lblpassCounter");
			this.lblpassCounter.BackColor = System.Drawing.Color.Transparent;
			this.lblpassCounter.Name = "lblpassCounter";
			// 
			// lblRePassCounter
			// 
			resources.ApplyResources(this.lblRePassCounter, "lblRePassCounter");
			this.lblRePassCounter.BackColor = System.Drawing.Color.Transparent;
			this.lblRePassCounter.Name = "lblRePassCounter";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Name = "label6";
			// 
			// adapter_list
			// 
			resources.ApplyResources(this.adapter_list, "adapter_list");
			this.adapter_list.BackColor = System.Drawing.SystemColors.HighlightText;
			this.adapter_list.FormattingEnabled = true;
			this.adapter_list.Name = "adapter_list";
			this.adapter_list.Sorted = true;
			this.adapter_list.SelectedIndexChanged += new System.EventHandler(this.Adapter_listSelectedIndexChanged);
			// 
			// text_result
			// 
			this.text_result.BackColor = System.Drawing.Color.WhiteSmoke;
			resources.ApplyResources(this.text_result, "text_result");
			this.text_result.Name = "text_result";
			this.text_result.ReadOnly = true;
			// 
			// tbn_info
			// 
			resources.ApplyResources(this.tbn_info, "tbn_info");
			this.tbn_info.Name = "tbn_info";
			this.tbn_info.UseVisualStyleBackColor = true;
			this.tbn_info.Click += new System.EventHandler(this.Tbn_infoClick);
			// 
			// data_table
			// 
			this.data_table.AllowUserToDeleteRows = false;
			this.data_table.AllowUserToOrderColumns = true;
			this.data_table.BackgroundColor = System.Drawing.Color.LightGray;
			this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.name,
			this.mac,
			this.edit});
			resources.ApplyResources(this.data_table, "data_table");
			this.data_table.Name = "data_table";
			this.data_table.ReadOnly = true;
			// 
			// name
			// 
			resources.ApplyResources(this.name, "name");
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// mac
			// 
			this.mac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			resources.ApplyResources(this.mac, "mac");
			this.mac.Name = "mac";
			this.mac.ReadOnly = true;
			// 
			// edit
			// 
			resources.ApplyResources(this.edit, "edit");
			this.edit.Name = "edit";
			this.edit.ReadOnly = true;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.label7, "label7");
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Name = "label7";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.data_table);
			this.Controls.Add(this.tbn_info);
			this.Controls.Add(this.text_result);
			this.Controls.Add(this.adapter_list);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblRePassCounter);
			this.Controls.Add(this.lblpassCounter);
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
			this.Controls.Add(this.btnst);
			this.Controls.Add(this.btnremove);
			this.Controls.Add(this.btnactivate);
			this.Controls.Add(Windowslist);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblpassCounter;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblRePassCounter;
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
		private System.Windows.Forms.Button btnactivate;
		private System.Windows.Forms.Button btnremove;
		private System.Windows.Forms.Button btnst;
		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.TextBox PassBox;
		private System.Windows.Forms.TextBox RePassBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox BoxShowPass;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;

		private System.Windows.Forms.ComboBox adapter_list;
		private System.Windows.Forms.TextBox text_result;
		private System.Windows.Forms.Button tbn_info;
		private System.Windows.Forms.DataGridView data_table;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn mac;
		private System.Windows.Forms.DataGridViewButtonColumn edit;

	}
}
