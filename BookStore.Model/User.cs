using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        public User()
        {
        }
        public User(int Id, string Name, string Password, string Email, string No, DateTime Birthday, bool IsDel, int Type)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.No = No;
            this.Birthday = Birthday;
            this.IsDel = IsDel;
            this.Type = Type;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string No { get; set; }

        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Type { get; set; }
    }
}
