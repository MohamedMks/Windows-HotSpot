using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MB
{
    public partial class MyCMB : Form
    {

        static MyCMB newMB;
        public Timer msgTimer;
        static string Button_id;
        static int disposeFormTimer;

        public MyCMB()
        {
            InitializeComponent();
        }

        public static string ShowBox(string txtMessage)
        {
            newMB = new MyCMB();
            newMB.lblMessage.Text = txtMessage;
            newMB.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle ,int delay)
        {
        	disposeFormTimer = delay;
            newMB = new MyCMB();
            newMB.lblTitle.Text = txtTitle;
            newMB.lblMessage.Text = txtMessage;
            newMB.ShowDialog();
            return Button_id;
        }

        private void MyCMB_Load(object sender, EventArgs e)
        {
           // disposeFormTimer = 20;
            newMB.lblTimer.Text = disposeFormTimer.ToString();
            msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(this.timer_tick); 
        }

        private void MyCMB_Paint(object sender, PaintEventArgs e)
        {
            Graphics mGraphics = e.Graphics;
            Pen pen1 = new Pen(Color.FromArgb(96, 155, 173), 1);
            
            Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            mGraphics.FillRectangle(LGB, Area1);
            mGraphics.DrawRectangle(pen1, Area1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newMB.msgTimer.Stop();
            newMB.msgTimer.Dispose();
            Button_id = "1";
            newMB.Dispose(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newMB.msgTimer.Stop();
            newMB.msgTimer.Dispose();
            Button_id = "2";
            newMB.Dispose();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                newMB.lblTimer.Text = disposeFormTimer.ToString();
            }
            else
            {
                newMB.msgTimer.Stop();
                newMB.msgTimer.Dispose();
                newMB.Dispose();
            }
        } 
    }
}

/* How To USE

            try{
                string result = MyCMB.ShowBox("Do you want to exit?\n This Dialog will close automaticaly after 5 sec", "Exit" ,5);
                if (result.Equals("1")){
                    MessageBox.Show("OK Button was Clicked");
                }else if (result.Equals("2")) {
                    MessageBox.Show("Cancel Button was Clicked");
                }
            }catch{ 
        		MessageBox.Show("errrrrrrrrrrrrr");
        	}
            
*/