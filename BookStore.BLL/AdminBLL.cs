using BookStore.DAL;
using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL
{
    public class AdminBLL
    {
        private AdminDAL adminDal = new AdminDAL();

        
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <param name="isDel">0 未删除的用户  1 删除的用户</param>
        /// <returns></returns>
        public List<Admin> GetAllAdmins()
        {
            return adminDal.GetAllAdmins();
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="eName">登录名</param>
        /// <param name="oldPwd"></param>
        /// <param name="newPwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool UpdatePwd(string eName, string oldPwd, string newPwd, out string msg)
        {
            bool result = false;
            Admin admin = adminDal.GetAdminByLoginName(eName, 1);// 有问题
            if (admin != null)
            {
                if (admin.Password == oldPwd)
                {
                    //更新密码
                    result = adminDal.UpdatePwd(eName, newPwd) > 0;
                    if (result)
                    {
                        msg = "更新成功";
                    }
                    else
                    {
                        msg = "更新失败";
                    }
                }
                else
                {
                    msg = "旧密码错误";
                }
            }
            else
            {
                msg = "账号不存在";
            }
            return result;
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool Login(string name, string pwd, out Admin admin)
        {
            //html    js    css

            bool result = false; //假设登录失败

            //user = userDal.GetUserByLoginName(name, type);
            admin = adminDal.GetAdminByLoginNameAndPassword(name, pwd);
            if (admin != null)
            {
                result = true;
            }
            return result;
        }
    }
}
