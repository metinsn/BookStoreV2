using BookStoreV2.Entity.DBContext;
using BookStoreV2.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Data.Repos
{
    public class CategoryRepo
    {
        public static int Add(Category cat)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                cat.Name.Trim().ToUpper();
                db.Category.Add(cat);
                db.SaveChanges();
                return db.Category.FirstOrDefault(w => w.Name == cat.Name).Id;
            }
        }

        public static int GetOrAdd(string categoryName)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                var cat = db.Category.FirstOrDefault(c => c.Name == categoryName.Trim().ToUpper());

                if (cat != null)
                {
                    return cat.Id;
                }
                else
                {
                    return Add(new Category() { Name = categoryName });
                }
            }
        }

        public static List<Category> GetAll()
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.Category.ToList();
            }
        }
    }
}
