using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMFSeat
{
    public partial class Foreground : Form
    {
        public Foreground()
        {
            InitializeComponent();
        }
        private void Foreground_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }



        public string Txt { get; set; }

        private void Foreground_Load(object sender, EventArgs e)
        {

            //int itemindex = int.Parse(this.Txt.Replace("btn",""))-1;

            //ToolStripMenuItem item = this.menuStrip1.Items[itemindex] as ToolStripMenuItem;

            //item.PerformClick();

            switch (Txt)
            {
                case "btn1":
                    TSMI1.PerformClick();
                    break;
                case "btn2":
                    TSMI2.PerformClick();
                    break;
            }
        }

        private void TSMI1_Click(object sender, EventArgs e)
        {
            Appointment aptmt = new Appointment();
            aptmt.MdiParent = this;
            aptmt.Show();
        }

        private void TSMI2_Click(object sender, EventArgs e)
        {
            SignIn sin = new SignIn();
            sin.MdiParent = this;
            sin.Show(); 
        }
    }
} 
