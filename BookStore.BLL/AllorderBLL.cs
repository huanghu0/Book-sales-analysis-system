using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL;
using BookStore.Model;

namespace BookStore.BLL
{
    public class AllorderBLL
    {
        AllordersDAL allordersdal = new AllordersDAL();
        public string GetAllorders(string username) {
            string str = "无订单";
            str = allordersdal.GetAllordersGetAllordersByusername(username);
            return str;
        }
        public int OrderBook(string booksname,int buycount,string ordername,string address,string username) {
            int count = 0;
            count = allordersdal.OrderBookByinforma(booksname,buycount,ordername,address,username);
            return count;
        }
    }
}
