using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Admin
    {
        public Admin()
        {
        }
        public Admin(int Id, string Name, string Password)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            
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
       
    }
}

