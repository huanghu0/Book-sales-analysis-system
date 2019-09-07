using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookStore.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoryDAL
    {
        SqlDbHelper db = new SqlDbHelper();

        /// <summary>
        /// 添加分类
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public int AddCategory(Category category)
        {
            //sql语句
            String sql = "INSERT INTO categories(name,description) VALUES(@Name,@Description)";
            //参数列表
            MySqlParameter[] param = {
                                       new MySqlParameter("@Name",MySqlDbType.VarChar),
                                       new MySqlParameter("@Description",MySqlDbType.VarChar)
                                   };

            //参数赋值
            param[0].Value = category.Name;
            param[1].Value = category.Description;

            return db.ExecuteNonQuery(sql, param);
        }

        /// <summary>
        /// 查询所有类别
        /// </summary>
        /// <returns></returns>
        public List<Category> getAll()
        {
            //1 sql语句
            string sql = "select * from categories";
            //2 执行
            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<Category> categories = new List<Category>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                Category category = DataRowToCategory(dr);
                categories.Add(category);
            }
            return categories;
        }

        /// <summary>
        /// 把行转化成对象
        /// </summary>
        /// <param name="dr"></param>
        /// <param name="type">table 表   view视图</param>
        /// <returns></returns>
        private Category DataRowToCategory(DataRow dr)
        {
            Category category = new Category();
            category.Id = Convert.ToInt32(dr["Id"]);
            category.Name = Convert.ToString(dr["Name"]);
            category.Description = Convert.ToString(dr["Description"]);
            return category;
        }

        // ....

    }
}
