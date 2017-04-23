using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Index (BookViewModel model) {

            var db = Globals.GetDatabase();
            var book = new Book();
            var Author = new Author();

            book.BookName = model.BookName;
            Author.AuthorName = model.Author;
            book.WrittenBy = Author; 
            if (!db.Books.Any(c => c.BookName == book.BookName)) {
                db.Books.Add(book);
                db.SaveChanges();
                ViewBag.Message = "Book Added";
                return View();
            }

            ModelState.AddModelError(string.Empty, "Book Already in Records.");
            return View();

            
        }

    }
}