using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

using MB;
using Microsoft.VisualBasic;
using Windows_HOSTSPOT.Properties;

namespace HotSpotWindows
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if (Settings.Default.UpgradeRequired)
            {
               Settings.Default.Upgrade();
               Settings.Default.UpgradeRequired = false;
               Settings.Default.Save();
            }
		}
		// 
		void BtnactivateClick(object sender, System.EventArgs e)
		{
			
			if (string.IsNullOrEmpty(Windowslist.Text))
			{
				timer1.Interval=2000;
				timer1.Enabled=true;
				MessageBox.Show("لم تختر نوع الحماية"); 
			}
			else if (string.IsNullOrEmpty(NameBox.Text))
			{
				MessageBox.Show("لم تختر اسم الويفي"); 
			}	
			else
			{
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				startInfo.FileName = "cmd.exe";
				
				//startInfo.Arguments = "/C slmgr.vbs -rilc";
				switch (Windowslist.Text)
				{
	
					case "SECURED":  
						try
						{ startInfo.Arguments = "/C netsh wlan set hostednetwork mode=allow ssid="+NameBox.Text+" key="+RePassBox.Text;	} //enable - allow
						catch
						{ MessageBox.Show("Bugs happens");  }
						break;
					default:
						break;
						
				}
				//startInfo.Arguments = "/C netsh wlan start hostednetwork"; 
				process.StartInfo = startInfo;
				process.Start();
				MessageBox.Show(Windowslist.Text + " Hotspot configured successfully \n Click Start Now");
				SaveSettings();
			}
			
		}
		void SaveSettings()
        {
            Settings.Default.NameUser = NameBox.Text;
            Settings.Default.PassWord = RePassBox.Text;
            Settings.Default.DataSaved = true;
            Settings.Default.Save();
        }
		
		void LoadSettings()
		{
			 //  <Value Profile="(Default)"></Value>
			try
                {
                    if (!string.IsNullOrEmpty(Settings.Default.NameUser))
                    {
                        NameBox.Text = Settings.Default.NameUser;

                    }else if (string.IsNullOrEmpty(Settings.Default.NameUser)){
                    	NameBox.Text = "Wifi_"+Environment.MachineName;
                    }
                    
                    if (!string.IsNullOrEmpty(Settings.Default.PassWord))
                    {
                    	PassBox.Text = Settings.Default.PassWord;
                        RePassBox.Text = Settings.Default.PassWord;
                        
                    }else if (string.IsNullOrEmpty(Settings.Default.PassWord)){
                    	PassBox.Text = "1234567890";
                    	RePassBox.Text = "1234567890";
                    }
                    
                    if ( !string.IsNullOrEmpty(Settings.Default.NameUser) && !string.IsNullOrEmpty(Settings.Default.PassWord) )
                    {
                       Settings.Default.DataSaved = true;

                    }
                }
			catch { }
		}
		void BtnremoveClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C netsh wlan stop hostednetwork";
			process.StartInfo = startInfo;
			process.Start();
			MessageBox.Show("Hostpot Stopped \n DONE .....");
			
		}
		void BtnstClick(object sender, System.EventArgs e)
		{
			if(IsAdministrator() == false){
				try{
                  string result = MyCMB.ShowBox("Please run this as Administrator", "info" ,3);
                  if (result.Equals("1")){
                    System.Environment.Exit(0);
                  }else if (result.Equals("2")) {}
                }catch{ 
        		  
        	    }
				btnst.Enabled = false;
		    }else if(IsAdministrator() == true){

			if(Settings.Default.DataSaved){
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C netsh wlan start hostednetwork"; 
			process.StartInfo = startInfo;
			process.Start();
			
			  try{
                  string result = MyCMB.ShowBox("Hostpot Started", "DONE ..." ,3);
                  if (result.Equals("1")){
                    
                  }else if (result.Equals("2")) {}
                }catch{ 
        		  
        	    }
			}else if(!Settings.Default.DataSaved){
				MessageBox.Show("Please save data first");
			}
				
								
			}
		}
		void BtnexitClick(object sender, System.EventArgs e)
		{
			System.Environment.Exit(0);
		}
		void Timer1Tick(object sender, System.EventArgs e)
		{
			lbltime.Text = DateTime.Now.ToShortTimeString();
			//timer1.Enabled=false;
			SendKeys.Send("{ESC}"); 
		}
		void MainFormLoad(object sender, System.EventArgs e)
		{
			loadlist();
			NameBox.Focus();
			LoadSettings();
			winver();
			automaticUpdater1.ForceCheckForUpdate(true);
		}
		
		void loadlist()
		{
			Windowslist.Items.Add("SECURED");
		}
		//get version
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}
		
		void WindowslistSelectedIndexChanged(object sender, System.EventArgs e)
		{/*
			btnactivate.Enabled = true;
			
			switch (Windowslist.Text)
				{
					// windows 8.1 ******************************************
					case "OPEN":  
						try
						{ PassBox.Enabled = false; }
						catch
						{ MessageBox.Show("sorry");  }
						
						break;
						
					case "SECURED":  
						try
						{ PassBox.Enabled = true;	}
						catch
						{ MessageBox.Show("sorry");  }
						break;
					default:
						break;
						
				}
			*/
		}

		void winver()
		{
			lblver.Text = String.Format("Version {0}", AssemblyVersion);
			lbltime.Text = DateTime.Now.ToShortTimeString();
			
		}
		void BtnupdateClick(object sender, System.EventArgs e)
		{
			automaticUpdater1.ForceCheckForUpdate(true);
		}
		void PassBoxTextChanged(object sender, EventArgs e)
		{
	
			if (PassBox.Text.Length >= 8)
            {
                //PassBox.BackColor = Color.White;
                RePassBox.Enabled = true;
            }
		    if (PassBox.Text != RePassBox.Text)
            {
                PassBox.BackColor = Color.Green;
                RePassBox.BackColor = Color.Red;
                btnactivate.Enabled = false;
            }
		    
		    lblpassCounter.Text = PassBox.Text.Length.ToString();
			
		}
		void RePassBoxTextChanged(object sender, EventArgs e)
		{
	
			if (PassBox.Text == RePassBox.Text && RePassBox.Text.Length >= 8 )
            {
                PassBox.BackColor = Color.Green;
                RePassBox.BackColor = Color.Green;
                btnactivate.Enabled = true;
            }
            else if (PassBox.Text != RePassBox.Text)
            {
                PassBox.BackColor = Color.Green;
                RePassBox.BackColor = Color.Red;
                btnactivate.Enabled = false;
            }
            lblRePassCounter.Text = RePassBox.Text.Length.ToString();

		}
		void BoxShowPassCheckedChanged(object sender, EventArgs e)
		{
			try
            {
				if (BoxShowPass.Checked){
                    PassBox.PasswordChar = '\0';
                    RePassBox.PasswordChar = '\0';
			        }
                    else {
                    PassBox.PasswordChar = '*';
                    RePassBox.PasswordChar = '*';
                    }
            }
            catch { }
	
		}
		

		
	
		
		void ToolStripStatusLabel1Click(object sender, EventArgs e)
		{
           System.Diagnostics.Process.Start("https://github.com/MohamedMks ");			
		}
		
		void LbltimeClick(object sender, EventArgs e)
		{
			lbltime.Text = DateTime.Now.ToShortTimeString();
		}
		
		
		bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole (WindowsBuiltInRole.Administrator);
        }
	}
	
}