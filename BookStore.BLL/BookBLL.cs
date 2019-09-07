using BookStore.DAL;
using BookStore.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DAL;

namespace BookStore.BLL
{
    public class BookBLL
    {
        private BookDAL bookDal = new BookDAL();

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool AddBook(Book book)
        {
            return bookDal.AddBook(book) > 0;
        }
        public int BookDelete(int id, string name, string cbs, decimal prices, int store) {
            int count = 0;
            BookDAL bookdal = new BookDAL();
            count = bookdal.BookDeleteByinformation(id,name,cbs,prices,store);
            return count;
        }
        public List<Book> GetAllBooks()
        {
            return bookDal.GetAllBooks();
        }
        public List<Book> SelectBooks(string name)
        {
            return bookDal.SelectBooks(name);
        }
    }
}