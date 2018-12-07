using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace HMFSeat
{
    public static class MySqlHelper
    {
        //数据库连接字符串
        public static string Conn = "Database='hmfseat';Data Source='localhost';User Id='root';Password='root';charset='utf8';pooling=true";
        public static DataSet getAllCustomerInfo(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
            com.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter("set names gb2312;" + sql, com);
            adp.Fill(ds);
            com.Close();
            return ds;
        }
        public static DataSet getAllData(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
            com.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter("set names gb2312;" + sql, com);
            adp.Fill(ds);
            com.Close();
            return ds;

        }
        public static List<LoginResult> GetKaiKas(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
            List<LoginResult> logins = null;
            com.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, com);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                logins = new List<LoginResult>();
                while (dr.Read())
                {
                    logins.Add(new LoginResult
                    {
                        ID = dr[0].ToString(),
                        Name = dr[1].ToString(),
                        WorkerNO = dr[2].ToString()
                    });
                }
            }

            com.Close();
            return logins;
        }

        public static List<MenjinjiluResult> GetMenJijilus(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
            List<MenjinjiluResult> logins = null;
            com.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, com);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                logins = new List<MenjinjiluResult>();
                while (dr.Read())
                {
                    string yx = dr[4].ToString();

                    MenjinjiluResult r = new MenjinjiluResult
                    {
                        MJJLID = dr[0].ToString(),
                        CardID = dr[1].ToString(),
                        entryTime = DateTime.Parse(dr[2].ToString()),
                        YX = (yx == "1")
                    };
                    if (dr[3] == System.DBNull.Value)
                        r.departureTime = null;
                    else
                        r.departureTime = DateTime.Parse(dr[3].ToString());

                    logins.Add(r);
                }
            }

            com.Close();
            return logins;
        }


        public static int ExcuteSql(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);
            com.Open();
            MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, com);
            int count = cmd.ExecuteNonQuery();

            return count;
        }

        public static List<SingleRowResult> GetSingleRows(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);
            com.Open();
            MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, com);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<SingleRowResult> r = null;

            if (dr.HasRows)
            {
                r = new List<SingleRowResult>();

                while (dr.Read())
                {
                    if (dr[0] != System.DBNull.Value)
                        r.Add(new SingleRowResult
                        {
                            Value = dr[0].ToString()
                        });
                }
            }
            com.Close();
            return r;
        }

        public static int GetRowCount(string sql)
        {
            MySqlConnection com = new MySqlConnection(Conn);
            com.Open();
            MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, com);
            MySqlDataReader dr = cmd.ExecuteReader();
            int r = 0;
            if (dr.HasRows)
            {
                //r = new List<SingleRowResult>();

                while (dr.Read())
                {
                    r = int.Parse(dr[0].ToString());
                    break;
                }
            }

            com.Close();
            return r;
        }
    }
}
