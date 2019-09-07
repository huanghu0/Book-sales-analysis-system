using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BookStore.Model;
using MySql.Data.MySqlClient;
using BookStore;

namespace BookStore.DAL
{
   public class AllordersDAL
    {
        SqlDbHelper db = new SqlDbHelper();
        public  string GetAllordersGetAllordersByusername(string username)
        {
            //SELECT* FROM allorders WHERE username = '张三';
            string sql = "SELECT * FROM allorders WHERE username=@username OR ordername=@ordername";
            MySqlParameter[] param = {
                                        new MySqlParameter("@username",MySqlDbType.VarChar),
                                        new MySqlParameter("@ordername",MySqlDbType.VarChar)
                                      };
            param[0].Value = username;
            param[1].Value = username;
            DataTable dt = db.ExecuteDataTable(sql, param);
            string str1="发货单信息:"+"\r\n";
            string str2 = "订货单信息:"+"\r\n";
            string str = "";
            int i = 1,j =   1;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["username"].ToString() == username)
                    {
                        str1 += "" + i + "." + "书籍名: " + item["booksname"] + " " + "购买数量: " + item["buycount"] + " " + "订货人: " + item["ordername"] + " " + "配送地址: " + item["address"] + "\r\n";
                        i++;
                    }
                    else {
                        str2 += "" + j + "." + "书籍名:" + item["booksname"] + " " + "购买数量:" + item["buycount"] + " " + "商家:" + item["username"] + " " + "配送地址:" + item["address"] + "\r\n"; 
                    }
                }
                str = str1 + "\r\n" + str2;
            }
            else {
                str = "无订单";
            }
            return str;
        }
        public int OrderBookByinforma(string booksname, int buycount, string ordername, string address, string username) {
            int count = 0;
            string sql = "INSERT INTO allorders(booksname,buycount,ordername,address,username) VALUES(@booksname,@buycount,@ordername,@address,@username)";
            MySqlParameter[] param = {
                                            new MySqlParameter("@booksname",MySqlDbType.VarChar),
                                            new MySqlParameter("@buycount",MySqlDbType.Int32),
                                            new MySqlParameter("@ordername",MySqlDbType.VarChar),
                                            new MySqlParameter("@address",MySqlDbType.VarChar),
                                            new MySqlParameter("@username",MySqlDbType.VarChar)
                                      };
            param[0].Value = booksname;
            param[1].Value = buycount;
            param[2].Value = ordername;
            param[3].Value = address;
            param[4].Value = username;
            count = db.ExecuteNonQuery(sql, param);
            return count;
        }
    }
}
