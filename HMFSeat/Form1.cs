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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string sql = "select * from Area";
            List<AreaResult> lar = MySqlHelper.Area(sql);
            for(int i=0; i<lar.Count; i++)
            {
                Console.WriteLine("缓冲表AreaRusult结果为--ID为:{0};区域为:{1}", lar[i].ID, lar[i].Name);
            }

        }
    }
}
