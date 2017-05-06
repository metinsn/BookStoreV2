using BookStoreV2.Data.Repos;
using BookStoreV2.Entity.Models;
using BookStoreV2.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreV2.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var result = BookRepo.GetAll((int)id);
                return View(result);
            }
            else
            {
                var result = BookRepo.GetAll();
                return View(result);
            }
            
        }

        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(BookVM model)
        {
            Book book = new Book();
            book.Name = model.BookName;
            book.Price = model.Price;
            book.PhotoUrl = model.PhotoUrl;
            book.WriterId = WriterRepo.GetOrAdd(model.WriterName);
            book.CategoryId = CategoryRepo.GetOrAdd(model.CategoryName);

            BookRepo.Add(book);

            return RedirectToAction("Index");
        }
    }
}