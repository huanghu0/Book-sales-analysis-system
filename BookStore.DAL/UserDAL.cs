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
    public class UserDAL
    {
        SqlDbHelper db = new SqlDbHelper();

        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public int AddUser(User user)
        {
            //sql语句
            String sql = "INSERT INTO users(Name,Password,Birthday,Email,IsDel,Type) VALUES(@Name,@Password,@Birthday,@Email,@IsDel,@Type)";
            //参数列表
            MySqlParameter[] param = {
                                       new MySqlParameter("@Name",MySqlDbType.VarChar),
                                       new MySqlParameter("@Password",MySqlDbType.VarChar),
                                       new MySqlParameter("@Birthday",MySqlDbType.Date),
                                       new MySqlParameter("@Email",MySqlDbType.VarChar),
                                       new MySqlParameter("@IsDel",MySqlDbType.Int32),
                                       new MySqlParameter("@Type",MySqlDbType.Int32)
                                   };

            //参数赋值
            param[0].Value = user.Name;
            param[1].Value = user.Password;
            param[2].Value = user.Birthday;
            param[3].Value = user.Email;
            param[4].Value = user.IsDel;
            param[5].Value = user.Type;

            return db.ExecuteNonQuery(sql, param);
        }


        public int UpdateUser(User user)
        {
            //1.sql语句
            string sql = "UPDATE users SET Birthday=@Birthday,Email=@Email,Type=@Type WHERE Id=@Id";

            MySqlParameter[] param = { new MySqlParameter("@Birthday",MySqlDbType.Date),
                                   new MySqlParameter("@Email",MySqlDbType.VarChar),
                                   new MySqlParameter("@Type",MySqlDbType.Int32),
                                   new MySqlParameter("@Id",MySqlDbType.Int32)};
            param[0].Value = user.Birthday;
            param[1].Value = user.Email;
            param[2].Value = user.Type;
            param[3].Value = user.Id;

            return db.ExecuteNonQuery(sql, param);
        }


        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public int SoftDelete(string id)
        {
            string sql = "UPDATE users SET IsDel=1 WHERE id ='" + id + "'"; // 存在SQL注入的风险

            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 硬删除
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public int RealDelete(string No)
        {
            string sql = "DELETE FROM users WHERE No =" + No;

            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids">2,3,4,5</param>
        /// <returns></returns>
        public int Deletes(string ids)
        {
            string sql = "DELETE FROM users WHERE No in (" + ids + ")";

            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 查询所有员工
        /// </summary>
        /// <param name="isDel"></param>
        /// <returns></returns>
     /*   public List<User> GetAllUsers(int isDel)
        {
            //1 sql语句
            string sql = "SELECT * FROM users WHERE IsDel=" + isDel;
            //2 执行

            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<User> users = new List<User>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                User user = DataRowToUser(dr);
                users.Add(user);
            }
            return users;
        }*/
        public List<User> GetAllUsers()
        {
            //1 sql语句
            string sql = "SELECT * FROM users ";
            //2 执行

            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<User> users = new List<User>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                User user = DataRowToUser1(dr);
                users.Add(user);
            }
            return users;
        }
        public List<User> GetUsers(string name)
        {
            //1 sql语句
            string sql = "SELECT * FROM users WHERE name ='name'";
            //2 执行

            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<User> users = new List<User>();


            //行转化成对象
            User user = DataRowToUser2();
            users.Add(user);

            return users;
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
            string sql = "UPDATE users SET Password=@pwd WHERE Name=@name";
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
        public User GetUserByLoginNameAndPassword(string Name, string password)
        {
            //1 sql语句
            string sql = "SELECT * FROM users WHERE name=@name AND password=@password AND isdel=0";
            MySqlParameter[] param = {
                                        new MySqlParameter("@name",MySqlDbType.VarChar),
                                        new MySqlParameter("@password",MySqlDbType.VarChar)
                                   };
            param[0].Value = Name;
            param[1].Value = password;
            //2 执行sql语句
            DataTable dt = db.ExecuteDataTable(sql, param);
            //3 关系--》对象     orm --》 ef  nhibernate
            User user = null;
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                user = DataRowToUser(dr);
            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public User GetUserByLoginName(string Name, int type)
        {
            //1 sql语句
            string sql = "SELECT * FROM users WHERE name=@name AND type=@type AND isdel=0";
            MySqlParameter[] param = {
                                        new MySqlParameter("@name",MySqlDbType.VarChar),
                                        new MySqlParameter("@type",MySqlDbType.Int32)
                                   };
            param[0].Value = Name;
            param[1].Value = type;
            //2 执行sql语句
            DataTable dt = db.ExecuteDataTable(sql, param);
            //3 关系--》对象     orm --》 ef  nhibernate
            User user = null;
            if (dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];
                user = DataRowToUser(dr);
            }
            return user;
        }

        /// <summary>
        /// 把行转化成对象
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="type">table 表   view视图</param>
        /// <returns></returns>
        private User DataRowToUser(DataRow dr)
        {
            User user = new User();

            if (dr["Birthday"] != DBNull.Value)
            {
                user.Birthday = Convert.ToDateTime(dr["Birthday"]);
            }
            user.Password = Convert.ToString(dr["Password"]);
            user.No = Convert.ToString(dr["No"]);
            user.Name = Convert.ToString(dr["Name"]);
            user.Email = Convert.ToString(dr["Email"]);
            user.IsDel = Convert.ToBoolean(dr["Isdel"]);
            user.Type = Convert.ToInt32(dr["Type"]);
            return user;
        }
        private User DataRowToUser1(DataRow dr)
        {
            User user = new User();

            if (dr["Birthday"] != DBNull.Value)
            {
                user.Birthday = Convert.ToDateTime(dr["Birthday"]);
            }
            // user.Password = Convert.ToString(dr["Password"]);
            user.No = Convert.ToString(dr["No"]);
            user.Name = Convert.ToString(dr["Name"]);
            user.Email = Convert.ToString(dr["Email"]);
            // user.IsDel = Convert.ToBoolean(dr["Isdel"]);
            user.Type = Convert.ToInt32(dr["Type"]);
            return user;
        }
        private User DataRowToUser2()
        {
            User user = new User();
            DataRow dr=null;
          /*  if (dr["Birthday"] != DBNull.Value)
            {
                user.Birthday = Convert.ToDateTime(dr["Birthday"]);
            }*/
            // user.Password = Convert.ToString(dr["Password"]);
            user.No = Convert.ToString(dr["No"]);
            user.Name = Convert.ToString(dr["Name"]);
            user.Email = Convert.ToString(dr["Email"]);
            // user.IsDel = Convert.ToBoolean(dr["Isdel"]);
            user.Type = Convert.ToInt32(dr["Type"]);
            return user;
        }
        public int UpdateinformByID(int id,DateTime birthday,string email,int type) {
            int count = 0;
            string sql = "UPDATE users SET birthday=@birthday,email=@email,type=@type WHERE id=@id";

            MySqlParameter[] param = { new MySqlParameter("@birthday",MySqlDbType.Date),
                                   new MySqlParameter("@email",MySqlDbType.VarChar),
                                   new MySqlParameter("@type",MySqlDbType.Int32),
                                   new MySqlParameter("@id",MySqlDbType.Int32)};
            param[0].Value = birthday;
            param[1].Value = email;
            param[2].Value = type;
            param[3].Value = id;
            count = db.ExecuteNonQuery(sql, param);
            return count;
        }
    }
}
