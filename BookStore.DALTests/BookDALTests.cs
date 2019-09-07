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
    public class BookDALTests
    {
        BookDAL bookDAL = new BookDAL();
        [TestMethod()]
        public void AddBookTest()
        {
            Book book = new Book(65555, "看见", "柴静", 45, 12);
            Assert.AreEqual(1, bookDAL.AddBook(book));
        }

        [TestMethod()]
        public void BookDeleteByinformationTest()
        {
            Assert.AreEqual(1, bookDAL.BookDeleteByinformation(65555, "看见", "柴静", 45, 12));
        }

        [TestMethod()]
        public void UpdateBookTest()
        {
            Book book = new Book(25, "简爱", "愚见", 30, 12);
            Assert.AreEqual(1, bookDAL.UpdateBook(book));
        }

        [TestMethod()]
        public void GetAllBooksTest()
        {
            List<Book> books = bookDAL.GetAllBooks();
            Assert.AreEqual(19, books.Count);
        }

        [TestMethod()]
        public void SelectBooksTest()
        {
            //Assert.Fail();
            List<Book> books = bookDAL.SelectBooks("JavaScript高级程序设计");
            Assert.AreEqual(1, books.Count);
        }
    }
}