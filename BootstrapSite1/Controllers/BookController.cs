using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapSite1.Models;
using BootstrapSite1.Models.ViewModels;

namespace BootstrapSite1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BookViewModel model)
        {
            var db = Globals.GetDatabase();
            var book = new Book();
            var Author = new Author();
            Author.AuthorID = Guid.NewGuid().ToString();
            book.BookName = model.BookName;
            Author.AuthorName = model.Author;
            //book.WrittenBy = Author;
            db.Authors.Add(Author);
            db.SaveChanges();

            if (!db.Books.Any(c => c.BookName == model.BookName))
            {
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