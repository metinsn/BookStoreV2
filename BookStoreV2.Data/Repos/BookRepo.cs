using BookStoreV2.Entity.DBContext;
using BookStoreV2.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Data.Repos
{
    public class BookRepo
    {
        public static void Add(Book book)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }
        public static List<Book> GetAll()
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.Book.ToList();
            }
        }

        public static List<Book> GetAll(int id)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.Book.Where(b => b.CategoryId == id).ToList();
            }
        }

        public static Book Get(int id)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.Book.FirstOrDefault(b => b.Id == id);
            }
        }

        public static void Delete(int id)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                var result = db.Book.FirstOrDefault(b => b.Id == id);
                db.Book.Remove(result);
                db.SaveChanges();
            }
        }
    }
}
