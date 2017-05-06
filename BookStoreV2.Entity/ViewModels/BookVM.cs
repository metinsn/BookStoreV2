using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreV2.Entity.ViewModels
{
    public class BookVM
    {
        public string BookName { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public string WriterName { get; set; }
        public string CategoryName { get; set; }
    }
}
