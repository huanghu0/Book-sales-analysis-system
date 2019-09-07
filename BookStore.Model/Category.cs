using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    /// <summary>
    /// 图书类别实体
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Category() { }
        /// <summary>
        /// 带两个参数的构造器
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name">类别的名称</param>
        public Category(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 图书类别名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Id:" + this.Id + ",Name:" + this.Name + ",Description:" + this.Description + "]";
        }
    }
}
