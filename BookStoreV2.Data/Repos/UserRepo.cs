using BookStoreV2.Entity.DBContext;
using BookStoreV2.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Data.Repos
{
    public class UserRepo
    {
        public static void Add(User user)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public static List<User> GetAll()
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.User.ToList();
            }
        }
    }
}
