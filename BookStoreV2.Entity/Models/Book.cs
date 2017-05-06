using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Entity.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public int WriterId { get; set; }
        public int CategoryId { get; set; }

        public virtual Writer Writer { get; set; }
        public virtual Category Category { get; set; }
    }
}
