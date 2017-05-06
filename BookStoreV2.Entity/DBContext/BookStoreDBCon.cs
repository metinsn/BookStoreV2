namespace BookStoreV2.Entity.DBContext
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookStoreDBCon : DbContext
    {
        public BookStoreDBCon()
            : base("name=BookStoreDB")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Writer> Writer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    }
}