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
        public static string conn = "Server='127.0.0.1';Database='hmfseat';User Id='root';Password='root'";
        //public static DataSet getAllCustomerInfo(string sql)
        //{
        //    MySqlConnection mysqlconn = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
        //    mysqlconn.Open();
        //    DataSet ds = new DataSet();
        //    MySqlDataAdapter adp = new MySqlDataAdapter("set names gb2312;" + sql, mysqlconn);
        //    adp.Fill(ds);
        //    mysqlconn.Close();
        //    return ds;
        //}
        //public static DataSet getAllData(string sql)
        //{
        //    MySqlConnection mysqlconn = new MySqlConnection(Conn);//创建一个C#连接MySQL的对象
        //    mysqlconn.Open();
        //    DataSet ds = new DataSet();
        //    MySqlDataAdapter adp = new MySqlDataAdapter("set names gb2312;" + sql, mysqlconn);
        //    adp.Fill(ds);
        //    mysqlconn.Close();
        //    return ds;

        //}
        public static List<AreaResult> Area(string sql)
        {
            MySqlConnection mysqlconn = new MySqlConnection(conn);//创建一个C#连接MySQL的对象
            List<AreaResult> logins = null;
            mysqlconn.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, mysqlconn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                logins = new List<AreaResult>();
                while (dr.Read())
                {
                    logins.Add(new AreaResult
                    {
                        ID = dr[0].ToString(),
                        Name = dr[1].ToString()

                    });
                }
            }
            mysqlconn.Close();
            return logins;
        }

        public static List<SeatRusult> Seat (string sql)
        {
            MySqlConnection mysqlconn = new MySqlConnection(conn);//创建一个C#连接MySQL的对象
            List<SeatRusult> logins = null;
            mysqlconn.Open();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, mysqlconn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                logins = new List<SeatRusult>();
                while (dr.Read())
                {
                    logins.Add(new SeatRusult
                    {
                        SeatID = dr[0].ToString(),
                        SeatDesk = dr[1].ToString(),
                        AreaID = dr[2].ToString()
                    });
                }
            }

            mysqlconn.Close();
            return logins;
        }


        //public static int ExcuteSql(string sql)
        //{
        //    MySqlConnection mysqlconn = new MySqlConnection(Conn);
        //    mysqlconn.Open();
        //    MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, mysqlconn);
        //    int count = cmd.ExecuteNonQuery();

        //    return count;
        //}

        //public static List<SingleRowResult> GetSingleRows(string sql)
        //{
        //    MySqlConnection mysqlconn = new MySqlConnection(Conn);
        //    mysqlconn.Open();
        //    MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, mysqlconn);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    List<SingleRowResult> r = null;

        //    if (dr.HasRows)
        //    {
        //        r = new List<SingleRowResult>();

        //        while (dr.Read())
        //        {
        //            if (dr[0] != System.DBNull.Value)
        //                r.Add(new SingleRowResult
        //                {
        //                    Value = dr[0].ToString()
        //                });
        //        }
        //    }
        //    mysqlconn.Close();
        //    return r;
        //}

        //public static int GetRowCount(string sql)
        //{
        //    MySqlConnection mysqlconn = new MySqlConnection(Conn);
        //    mysqlconn.Open();
        //    MySqlCommand cmd = new MySqlCommand("set names gb2312;" + sql, mysqlconn);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    int r = 0;
        //    if (dr.HasRows)
        //    {
        //        //r = new List<SingleRowResult>();

        //        while (dr.Read())
        //        {
        //            r = int.Parse(dr[0].ToString());
        //            break;
        //        }
        //    }

        //    mysqlconn.Close();
        //    return r;
        //}
    }
}
