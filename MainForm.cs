using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
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
			InitializeComponent();
			if (Settings.Default.UpgradeRequired)
            {
               Settings.Default.Upgrade();
               Settings.Default.UpgradeRequired = false;
               Settings.Default.Save();
            }
			
			if(IsAdministrator()){
				this.Text = this.Text+" As Administrator";
			}
			
			
		}
		
		void NameBoxTextChanged(object sender, EventArgs e)
		{
	       NameBox.BackColor = Color.White;
	       NameBox.Text = NameBox.Text.Replace(" ", "_");
		}
		
		// btn save settings
		void BtnactivateClick(object sender, System.EventArgs e)
		{
			
			if (string.IsNullOrEmpty(NameBox.Text))
			{
				NameBox.BackColor = Color.Red;
				text_result.Text = "Wifi name empty";
				
			}else {
				if(!IsAdministrator()){
					Restart_to_admin();
				}else{
				 btnactivate.BackColor = Color.White;
				 String myresult = RunCMD("/C netsh wlan set hostednetwork mode=allow ssid="+NameBox.Text+" key="+RePassBox.Text+" keyUsage=persistent  "); 
				// interface=\"Wi-FI\"
				 text_result.Text = myresult;
				}
				
				SaveSettings();
			}
			
		}
		void SaveSettings()
        {
            Settings.Default.NameUser  = NameBox.Text;
            Settings.Default.PassWord  = RePassBox.Text;
            Settings.Default.DataSaved = true;
            Settings.Default.Save();
        }
		
		void LoadSettings()
		{
			 //  <Value Profile="(Default)"></Value>
			try
            {
                    if (!string.IsNullOrEmpty(Settings.Default.NameUser)) {
                        NameBox.Text = Settings.Default.NameUser;
                    }else if (string.IsNullOrEmpty(Settings.Default.NameUser)){
                    	NameBox.Text = "Wifi_"+Environment.MachineName;
                    }
                    
                    if (!string.IsNullOrEmpty(Settings.Default.PassWord)){
                    	PassBox.Text = Settings.Default.PassWord;
                        RePassBox.Text = Settings.Default.PassWord;   
                    }else if (string.IsNullOrEmpty(Settings.Default.PassWord)){
                    	PassBox.Text = "1234567890";
                    	RePassBox.Text = "1234567890";
                    }
                    
                    if ( !string.IsNullOrEmpty(Settings.Default.NameUser) && !string.IsNullOrEmpty(Settings.Default.PassWord) ){
                       Settings.Default.DataSaved = true;
                    }
            } catch {
				text_result.Text = "Parameters Error";
			}
		}
		
		void BtnremoveClick(object sender, System.EventArgs e)
		{
			// netsh wlan show hostednetwork
			String myresult = RunCMD("/C netsh wlan stop hostednetwork");
			text_result.Text = myresult;
			String myresult2 = RunCMD("/C netsh wlan show hostednetwork");
			text_result.Text += myresult2;
			
		}
		
		void Tbn_infoClick(object sender, EventArgs e)
		{
			Load_clients();
		}
				
		void BtnstClick(object sender, System.EventArgs e)
		{
			/*
			 "/C netsh interface set interface name=\""+adapter_list.Text+"\" admin=disabled"
			 "/C netsh wlan start hostednetwork"
			*/
			
			if(IsAdministrator() == false){

				try{
                  string result = MyCMB.ShowBox("Please run this as Administrator", "info" ,3);
                  if (result.Equals("1")){
                  	Restart_to_admin();
                  }else if (result.Equals("2")) {}
                }catch{ 
        		  
        	    }
				
				btnst.Enabled = false;
		    }else if(IsAdministrator() == true){

			 if(Settings.Default.DataSaved){
					
			   String myresult = RunCMD("/C netsh wlan start hostednetwork");
			   text_result.Text = myresult;
			   
			}else if(!Settings.Default.DataSaved){

				string result = MyCMB.ShowBox("Please save data first", "info" ,1);
                if (result.Equals("1")){
					btnactivate.BackColor = Color.Red;
                }else if (result.Equals("2")) {}
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
			Load_clients();
			SendKeys.Send("{ESC}"); 
			
			
		}
		void MainFormLoad(object sender, System.EventArgs e)
		{

			LoadAdapters();
			NameBox.Focus();
			LoadSettings();
			winver();
			automaticUpdater1.ForceCheckForUpdate(true);
		}
		
		//get version
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
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
			if (BoxShowPass.Checked){
                PassBox.PasswordChar = '\0';
                RePassBox.PasswordChar = '\0';
			}else {
                PassBox.PasswordChar = '*';
                RePassBox.PasswordChar = '*';
            }
	
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
		
		public void LoadAdapters()
        {            
           if (adapter_list.Items.Count < 1)
           {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                var ipProps = adapter.GetIPProperties();
                IPInterfaceProperties properties = adapter.GetIPProperties();                    
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) //  || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                {

                	if (adapter.Description.Contains("Microsoft Hosted Network Virtual Adapter") || adapter.Description.Contains("Hosted Network")){
                	    	
                	}else{
                		adapter_list.Items.Add(adapter.Name);
                	}

                    text_result.Text += "Name   :"+adapter.Name+"\r\n"+
                    	                "Status :"+adapter.OperationalStatus.ToString()+"\r\n"+
                    	                "Info   :"+adapter.Description+"\r\n"+
                    	                "______________\r\n";
                }
            }
           }
           //adapter_list.SelectedIndex = 0; 
        }
		
		public String RunCMD(String cmd){

			 String strOutput;
			/*
			 System.Diagnostics.Process process = new System.Diagnostics.Process();
			 System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			 startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			 startInfo.FileName = "cmd.exe";
			 startInfo.Arguments = cmd ; 
			 process.StartInfo = startInfo;
			 process.Start();
			 */
			
			 //Create process
			 System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
			 // window style
			 pProcess.StartInfo.CreateNoWindow = true;
			 //strCommand is path and file name of command to run
			 pProcess.StartInfo.FileName = "cmd.exe";
			 //strCommandParameters are parameters to pass to program
			 pProcess.StartInfo.Arguments = cmd ; 
			 //
			 pProcess.StartInfo.UseShellExecute = false;
			 //Set output of program to be written to process output stream
			 pProcess.StartInfo.RedirectStandardOutput = true;   
			 //Optional
			 //pProcess.StartInfo.WorkingDirectory = strWorkingDirectory;
			 //Start the process
			 pProcess.Start();
			 //Get program output
			 strOutput = pProcess.StandardOutput.ReadToEnd();
			 //Wait for process to finish
			 pProcess.WaitForExit();

			 return strOutput;
		}
		

		public void Load_adapter_info(){
			
			String myresult = RunCMD("/C netsh wlan show drivers");

			string[] Lines = myresult.Split("\r\n".ToCharArray());
            string LineString = string.Empty;
            Boolean is_it = false;

            for (int i = 0; i < Lines.Length; i++)
            {
              LineString = Lines[i];

              if (LineString.Contains("Interface name")   && LineString.Split(":".ToCharArray())[1].Trim() == adapter_list.Text ){
              	
              	  text_result.Text = LineString.ToString()+ "\r\n";
              	  is_it = true;
              }

              if (LineString.Contains("Hosted network supported")   && LineString.Split(":".ToCharArray())[1].Trim() == "Yes" && is_it){
              	  text_result.Text += LineString.ToString()+"\r\n";
              	  is_it = false;
              }
              // adapter_list.Items[adapter_list.SelectedIndex].ToString()
            }
	    }
		public void Load_clients()
		{
	        String myresult = RunCMD("/C netsh wlan show hostednetwork");

			string[] Lines = myresult.Split("\r\n".ToCharArray());
            string LineString = string.Empty;
            
            data_table.Rows.Clear();
            var index = data_table.Rows.Add();
            
            for (int i = 0; i < Lines.Length; i++)
            {
              LineString = Lines[i]; 
              
              if(LineString.Contains("SSID name") ){
              	
              	text_result.Text =  "WIFI Name         :"  +LineString.Split(":".ToCharArray())[1].Trim() +"\r\n";
              	
              }if(LineString.Contains("Status") ){
              	
              	text_result.Text +=  "Status           :"  +LineString.Split(":".ToCharArray())[1].Trim() +"\r\n";
              	
              }else if (LineString.Contains("Number of clients") ){ 
              	
              	text_result.Text += "Number of clients : " +LineString.Split(":".ToCharArray())[1].Trim()+"\r\n";
              	
              }else if(LineString.Contains("Authenticated") ){
              	

              	String mac = LineString.Replace("Authenticated", "").Replace(" ", "");
              	
              	text_result.Text += "Device Mac        : " +mac +"\r\n";

              	data_table.Rows[index].Cells["Mac"].Value = mac;
              	
              }else{
              	
              }
 
            }

		}
				
		void Adapter_listSelectedIndexChanged(object sender, EventArgs e)
		{
			Load_adapter_info();
	
		}
		
		void Restart_to_admin(){
			Process proc = new Process();
            proc.StartInfo.FileName = "MyWifiHotSpot.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
            System.Environment.Exit(0);
		}
		// netsh wlan show interface
		// netsh wlan connect ssid="TNCAPAD58" name=Profile2 interface="Wireless Network Connection 2"

		
		//
		//netsh interface ip set address "TestWIFI" static 192.168.159.1 255.255.255.0 196.168.159.1
	}
	
}