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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void foregroundshow (object sender)
        {
            this.Hide();
            Foreground fogrd = new Foreground();
            fogrd.Txt = (sender as Button).Name;
            fogrd.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.foregroundshow(sender);
            /*
            this.Hide();
            Foreground fogrd = new Foreground();
            fogrd.Txt = btn1.Name;
            fogrd.Show();
            */
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.foregroundshow(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.foregroundshow(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
