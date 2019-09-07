using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    /// <summary>
    /// 图书实体
    /// </summary>
    public class Book
    {
        public Book() { }
        public Book(int Id,string Name,Category category,string ISBN,string Author,double Price,int SalesAmount,int store)
        {
            this.Id = Id;
            this.Name = Name;
            this.category = category;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Price = Price;
            this.SalesAmount = SalesAmount;
            this.store = store;
        }
        public Book(int Id, string Name, string Author, double Price, int store)
        {
            this.Id = Id;
            this.Name = Name;
            this.category = category;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Price = Price;
            this.SalesAmount = SalesAmount;
            this.store = store;
        }
        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 图书类别
        /// </summary>
        public Category category { get; set; }
        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 销售量
        /// </summary>
        public int SalesAmount { get; set; }
        /// <summary>
        /// 库存量
        /// </summary>
        public int store { get; set; }
    }
}
