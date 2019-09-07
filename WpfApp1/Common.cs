using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Model;
namespace BookStore
{
    /// <summary>
    /// 
    /// </summary>
    public static class Common
    {
        // 保存当前登录用户对象
        public static User LoginUser { get; set; }


        public static List<UserType> getTypes()
        {
            List<UserType> types = new List<UserType>();
            types.Add(new UserType() { No = 1, Name = "普通员工" });
            types.Add(new UserType() { No = 2, Name = "经理" });
            types.Add(new UserType() { No = 3, Name = "图书管理员" });
            types.Add(new UserType() { No = 4, Name = "订单管理员" });
            return types;

        }

        public static Admin LoginAdmin { get; set; }


        

    }
    public class UserType
    {
        public int No { get; set; }

        public string Name { get; set; }
    }

}
