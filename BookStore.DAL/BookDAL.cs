using BookStore.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore;

namespace BookStore.DAL
{
    public class BookDAL
    {
        SqlDbHelper db = new SqlDbHelper();

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int AddBook(Book book)
        {
            //sql语句
            String sql = "INSERT INTO books(id,name,author,price,store) VALUES(@id,@name,@author,@price,@store)";
            //参数列表
            MySqlParameter[] param = {
                                       new MySqlParameter("@id",MySqlDbType.Int32),
                                       new MySqlParameter("@name",MySqlDbType.VarChar),
                                       new MySqlParameter("@author",MySqlDbType.VarChar),
                                       new MySqlParameter("@price",MySqlDbType.Double),
                                       new MySqlParameter("@store",MySqlDbType.Int32),
                                   };

            //参数赋值
            param[0].Value = book.Id;
            param[1].Value = book.Name;
            param[2].Value = book.Author;
            param[3].Value = book.Price;
            param[4].Value = book.store;
            return db.ExecuteNonQuery(sql, param);
        }
        public int BookDeleteByinformation(int id, string name, string cbs, decimal prices, int store) {
            int count = 0;
            //DELETE FROM books WHERE NAME = '男人来自火星女人来自金星';
            string sql = "DELETE FROM books WHERE id = @id";
            MySqlParameter[] param = {
                                            new MySqlParameter("@id",MySqlDbType.Int32)
                                      };
            param[0].Value = id;
            count = db.ExecuteNonQuery(sql, param);
            return count;
        }
        public int UpdateBook(Book book)
        {
            //1.sql语句
            string sql = "UPDATE books SET Name=@name,Author=@author,Price=@price WHERE Id=@Id";

            MySqlParameter[] param = { new MySqlParameter("@name",MySqlDbType.VarChar),
                                       new MySqlParameter("@author",MySqlDbType.VarChar),
                                       new MySqlParameter("@price",MySqlDbType.Decimal),
                                       new MySqlParameter("@Id",MySqlDbType.Int32)
                                    };
            param[0].Value = book.Name;
            param[1].Value = book.Author;
            param[2].Value = book.Price;
            param[3].Value = book.Id;

            return db.ExecuteNonQuery(sql, param);
        }
        public List<Book> GetAllBooks()
        {
            //1 sql语句
            string sql = "SELECT * FROM books ";
            //2 执行

            DataTable dt = db.ExecuteDataTable(sql);
            //3 关系--》对象
            List<Book> books = new List<Book>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                Book book = DataRowToBook(dr);
                books.Add(book);
            }
            return books;
        }
        public List<Book> SelectBooks(string name)
        {
            //1 sql语句
            string sql = "SELECT * FROM books WHERE name = @name";
            //2 执行
            MySqlParameter[] param = { 
                                       new MySqlParameter("@name",MySqlDbType.VarChar)
                                    };
            param[0].Value = name;
            DataTable dt = db.ExecuteDataTable(sql,param);
            //3 关系--》对象
            List<Book> books = new List<Book>();

            foreach (DataRow dr in dt.Rows)
            {
                //行转化成对象
                Book book = DataRowToBook(dr);
                books.Add(book);
            }
            return books;
        }
        private Book DataRowToBook(DataRow dr)
        {
            Book book = new Book();


            book.Id = Convert.ToInt32(dr["id"]);
            book.Name = Convert.ToString(dr["Name"]);
            book.Author= Convert.ToString(dr["Author"]);
            book.Price= Convert.ToDouble(dr["Price"]);
            book.store = Convert.ToInt32(dr["store"]);
            return book;
        }
    }
}