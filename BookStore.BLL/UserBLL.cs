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
    public class UserBLL
    {
        private UserDAL userDal = new UserDAL();

        public bool UpdateUser(User user)
        {
            return userDal.UpdateUser(user) > 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool AddUser(User user)
        {
            return userDal.AddUser(user) > 0;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="pid">id</param>
        /// <param name="flag">1 真删除  0 软删除</param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            int result;
            
                result = userDal.Deletes(ids);
            
            return result;
        }
        public int Softdelete(string ids)
        {
            int result;

            result = userDal.SoftDelete(ids);

            return result;
        }
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <param name="isDel">0 未删除的用户  1 删除的用户</param>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            return userDal.GetAllUsers();
        }
        public List<User> GetUsers(string name)
        {
            return userDal.GetUsers(name);
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
            User user = userDal.GetUserByLoginName(eName, 1);// 有问题
            if (user != null)
            {
                if (user.Password == oldPwd)
                {
                    //更新密码
                    result = userDal.UpdatePwd(eName, newPwd) > 0;
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
        public bool Login(string name, string pwd, out User user)
        {
            //html    js    css

            bool result = false; //假设登录失败

            //user = userDal.GetUserByLoginName(name, type);
            user = userDal.GetUserByLoginNameAndPassword(name, pwd);
            if (user != null)
            {
                result = true;
            }
            return result;
        }
        public int Updateinform(int id,DateTime birthday,string email,int type) {
            int count = 0;
            UserDAL userdal = new UserDAL();
            count = userdal.UpdateinformByID(id, birthday, email, type);
            return count;
        }
    }
}
