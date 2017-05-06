using BookStoreV2.Entity.DBContext;
using BookStoreV2.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Data.Repos
{
    public class WriterRepo
    {
        public static int Add(Writer writer)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                writer.Name.Trim().ToUpper();
                db.Writer.Add(writer);
                db.SaveChanges();
                return db.Writer.FirstOrDefault(w => w.Name == writer.Name).Id;
            }
        }

        public static int GetOrAdd(string writerName)
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                var writer = db.Writer.FirstOrDefault(w => w.Name == writerName.Trim().ToUpper());

                if (writer != null)
                {
                    return writer.Id;
                }
                else
                {
                    return Add(new Writer() { Name = writerName });
                }
            }
        }

        public static List<Writer> GetAll()
        {
            using (BookStoreDBCon db = new BookStoreDBCon())
            {
                return db.Writer.ToList();
            }
        }
    }
}
