using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Model;
using MySql.Data.MySqlClient;

namespace BookStore.DAL
{
    public class QuaterinformationDAL
    {
        SqlDbHelper db = new SqlDbHelper();
        public string GetQuaterinformByQuaterAndusername(int quater, string username) {
            //SELECT* FROM quaterinformation WHERE quater = 1 AND username = '张三';
            string sql = "SELECT * FROM quaterinformation WHERE quater = @quater AND username = @username";
            MySqlParameter[] param = {
                                        new MySqlParameter("@quater",MySqlDbType.Int32),
                                        new MySqlParameter("@username",MySqlDbType.VarChar)
                                      };
            param[0].Value = quater;
            param[1].Value = username;
            DataTable dt = db.ExecuteDataTable(sql, param);
            string str= "本季度数据如下";
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow item in dt.Rows)
                {
                    str += "\r\n" + "书名:" + item["bookname"] + "\r\n" + "订货数量:" + item["ordercount"] + "\r\n" + "销售数量（卖出）:" + item["sellcount"] +"\r\n";
                }
            }
            return str;
        }
    }
}
