using BookStore.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL
{
    public class AdminDAL
    {
        SqlDbHelper db = new SqlDbHelper();

       
        /// <summary>
        /// 查询所有员工
        /// </summary>
        /// <param name="isDel"></param>
        /// <returns></returns>
     
        public List<Admin> GetAllAdmins()
        {
            //1 sql语句
            string sql = "SELECT * FROM admin";
            //2 执行

            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<Admin> admins = new List<Admin>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                Admin admin = DataRowToAdmin(dr);
                admins.Add(admin);
            }
            return admins;
        }
        /*  public DataTable GetAllUsers()
          {
              //1 sql语句
              string sql = "SELECT * FROM users";
              //2 执行

              DataTable dt = db.ExecuteDataTable(sql);

              return dt;
          }*/

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public int UpdatePwd(string Name, string newPwd)
        {
            //1 sql语句
            string sql = "UPDATE admin SET Password=@pwd WHERE Name=@name";
            MySqlParameter[] param = {
                                    new MySqlParameter("@name",MySqlDbType.VarChar),
                                     new MySqlParameter("@pwd",MySqlDbType.VarChar)
                                   };
            param[0].Value = Name;
            param[1].Value = newPwd;
            //2 执行
            return db.ExecuteNonQuery(sql, param);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Admin GetAdminByLoginNameAndPassword(string Name, string password)
        {
            //1 sql语句
            string sql = "SELECT * FROM admin WHERE name=@name AND password=@password";
            MySqlParameter[] param = {
                                        new MySqlParameter("@name",MySqlDbType.VarChar),
                                        new MySqlParameter("@password",MySqlDbType.VarChar)
                                   };
            param[0].Value = Name;
            param[1].Value = password;
            //2 执行sql语句
            DataTable dt = db.ExecuteDataTable(sql, param);
            //3 关系--》对象     orm --》 ef  nhibernate
            Admin admin = null;
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                admin = DataRowToAdmin(dr);
            }
            return admin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Admin GetAdminByLoginName(string Name, int type)
        {
            //1 sql语句
            string sql = "SELECT * FROM admin WHERE name=@name";
            MySqlParameter[] param = {
                                        new MySqlParameter("@name",MySqlDbType.VarChar),
                                        
                                   };
            param[0].Value = Name;
           
            //2 执行sql语句
            DataTable dt = db.ExecuteDataTable(sql, param);
            //3 关系--》对象     orm --》 ef  nhibernate
            Admin admin = null;
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                admin = DataRowToAdmin(dr);
            }
            return admin;
        }

        /// <summary>
        /// 把行转化成对象
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="type">table 表   view视图</param>
        /// <returns></returns>
        private Admin DataRowToAdmin(DataRow dr)
        {
            Admin admin = new Admin();

            
            admin.Password = Convert.ToString(dr["Password"]);
            
            admin.Name = Convert.ToString(dr["Name"]);
           
            return admin;
        }
    }
}
