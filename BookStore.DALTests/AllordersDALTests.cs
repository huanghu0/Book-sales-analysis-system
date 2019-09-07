using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Tests
{
    [TestClass()]
    public class AllordersDALTests
    {
        //BookDAL bookDAL = new BookDAL();
        AllordersDAL allordersdal = new AllordersDAL();
        [TestMethod()]
        public void GetAllordersGetAllordersByusernameTest()
        {

            Assert.AreEqual(1, allordersdal.OrderBookByinforma("Java入门", 100, "王五", "成都市", "张三"));
        }

        
    }
}