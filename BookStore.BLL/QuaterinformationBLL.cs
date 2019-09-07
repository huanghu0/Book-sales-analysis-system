using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL;
using BookStore.Model;

namespace BookStore.BLL
{
    public class QuaterinformationBLL
    {
        QuaterinformationDAL QuaterInformdal = new QuaterinformationDAL();
        public string GetQuater(int quater,string username) {
            string str = "无数据";
            str = QuaterInformdal.GetQuaterinformByQuaterAndusername(quater,username);
            return str;
        }
    }
}
