using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Model;

namespace BookStore.DAL.Tests
{
    [TestClass()]
    public class UserDALTests
    {
        UserDAL userDAL = new UserDAL();

        [TestMethod()]
        public void AddUserTest()
        {
            User user = new User(0, Name: "赵六", Password: "123",
                Email: "zl@qq.com", No: "100200",
                Birthday: new DateTime(), IsDel: false, Type: 1);
            Assert.AreEqual(1, userDAL.AddUser(user));
        }

        [TestMethod()]
        public void UpdateUserTest()
        {
            //Assert.Fail();
            //李员工	123456	li_sir@qq.com	100002	1996-12-13	0	1
            User user = new User(2, Name: "李员工", Password: "12345",
                Email: "li_sir@qq.com", No: "100002",
                Birthday: new DateTime(), IsDel: false, Type: 1);
            //(0, Name: "赵六", Password: "123",
            //Email: "zl@qq.com", No: "100200",
            //Birthday: new DateTime(), IsDel: false, Type: 1);
            Assert.AreEqual(1, userDAL.UpdateUser(user));
        }

        [TestMethod()]
        public void SoftDeleteTest()
        {
            int flag = userDAL.SoftDelete("1100001");
            Assert.AreEqual(0, flag);

            // Assert.Fail();
        }

        [TestMethod()]
        public void RealDeleteTest()
        {

            int flag = userDAL.SoftDelete("1100001");
            Assert.AreEqual(0, flag);
        }

        [TestMethod()]
        public void DeletesTest()
        {
            //Assert.Fail();
            int flag = userDAL.Deletes("1");
            Assert.AreEqual(0, flag);
        }

        [TestMethod()]
        public void GetAllUsersTest()
        {
            List<User> users = userDAL.GetAllUsers();
            Assert.AreEqual(10, users.Count);
        }



        [TestMethod()]
        public void UpdatePwdTest()
        {
            int flag = userDAL.UpdatePwd("王五", "111");
            Assert.AreEqual(1, flag);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetUserByLoginNameTest()
        {
            //Assert.Fail();
            User user = userDAL.GetUserByLoginName("李欣", 1);
            Assert.IsNotNull(user);
        }

        [TestMethod()]
        public void GetUserByLoginNameAndPasswordTest()
        {
            User user = userDAL.GetUserByLoginNameAndPassword("李欣", "111");
            Assert.IsNotNull(user);
        }
    }
}
