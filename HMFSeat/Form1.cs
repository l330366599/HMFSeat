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
            Console.WriteLine("测试1:{0}",lar);
            AreaResult art = new AreaResult();
            Console.WriteLine("打印2:{0},{1}", art.ID, art.Name);
        }
    }
}
