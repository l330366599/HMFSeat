using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HMFSeat
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        //private List<CheckBox> _ckbs = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from Area";
            List<AreaResult> lar = MySqlHelper.Area(sql);
            int ckbwidth = 150;
            int singlerowchbcount = this.panel1.Width / ckbwidth;
            int currentchbindex = 0;

            //if (lar.Count > 0)
            //    _ckbs = new List<CheckBox>();

            for (int i = 0; i < lar.Count; i++)
            {
                CheckBox ckb = new CheckBox();
                int tmpxindex = i % singlerowchbcount;
                if (tmpxindex == 0)
                {
                    currentchbindex++;
                }
                ckb.Name = lar[i].ID;
                ckb.Text = lar[i].Name;
                ckb.AutoSize = true;
                ckb.Location = new Point(tmpxindex * ckbwidth + ckbwidth / 3, 25 * currentchbindex);
                ckb.Visible = true;
                ckb.CheckedChanged += CKB_CheckedChanged;
                this.panel1.Controls.Add(ckb);
                //_ckbs.Add(ckb);
            }
        }
        /// <summary>
        /// 每次点击某个ckb时都会重新创建rbs
        /// </summary>
        /// <param name="ckbs"></param>
        private void createrbs(string ckbs)
        {
            int rowindex = 0;
            int rdbwidth = 150;
            int rdbheight = 20;
            string fomat1 = @"select * from seat where Area_ID in ({0}) order by Area_ID";
            //areaid = tmpchb.Name;
            string sql1 = string.Format(fomat1, ckbs);
            List<SeatRusult> lsr = MySqlHelper.Seat(sql1);
            //rdbsinglerowcount:panel里承载的每行最大控件数量
            int rdbsinglerowcount = this.panel2.Width / rdbwidth;
            string areaid = "";
            int columnindex = 0;
            for (int i = 0; i < lsr.Count; i++)
            {
                string tmpareaid = lsr[i].AreaID;
                RadioButton rab = new RadioButton();
                rab.Name = lsr[i].SeatID;
                rab.Text = lsr[i].SeatDesk;
                rab.AutoSize = true;
                //int irange = i % rdbsinglerowcount;
                if (areaid != tmpareaid || columnindex == rdbsinglerowcount)
                {
                    rowindex++;
                    areaid = tmpareaid;
                    columnindex = 0;
                }


                rab.Location = new Point(rdbwidth * columnindex, rdbheight * (rowindex - 1));
                columnindex++;
                rab.Visible = true;
                this.panel2.Controls.Add(rab);
                Console.WriteLine("irange = {0},rdbcurrentindex={1}", columnindex, rowindex);
                //Console.WriteLine("seatID = {0},seatdesk = {1},areaid = {2}", lsr[eleindex].SeatID, lsr[eleindex].SeatDesk, lsr[eleindex].AreaID);
            }
        }

        private void CKB_CheckedChanged(object sender, EventArgs e)
        {
            //每次清理panel2
            int pandel2contrls = this.panel2.Controls.Count;
            if(pandel2contrls > 0)
                for (int i = pandel2contrls - 1; i >= 0; i--)
                    this.panel2.Controls.RemoveAt(i);
            //获取panel1下所有已选择的ckbs
            string ckbs = "";
            if (this.panel1.Controls.Count > 0)
            {
                foreach (CheckBox ckb in this.panel1.Controls)
                {
                    if(ckb.Checked)
                        ckbs += string.Format("'{0}',", ckb.Name);
                }
            }
            if(string.IsNullOrEmpty(ckbs))
                return;
            else
                ckbs = ckbs.Remove(ckbs.Length - 1);
            //重新创建rbs
            this.createrbs(ckbs);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
