using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model
{
    public class Allorders
    {
        public Allorders() { }
        public Allorders(string Booksname,int Buycount,string Ordername,string Address,string username) {
            this.Booksname = Booksname;
            this.Buycount = Buycount;
            this.Ordername = Ordername;
            this.Address = Address;
            this.Usersname = Usersname;
        }
        public string Booksname { get; set; }
        public int Buycount { get; set; }
        public string Ordername { get; set; }
        public string Address { get; set; }
        public string Usersname { get; set; }
    }
}
