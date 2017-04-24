using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class AuthorController : Controller
    {
        [HttpPost]
        public ActionResult Viewx(AuthorViewModel model)
        {
            var db = Globals.GetDatabase();
            var author = new Author();
            author.AuthorName = model.AuthorName;
            if (!db.Authors.Any(c => c.AuthorName == author.AuthorName)){
                db.Authors.Add(author);
                db.SaveChanges();
                ViewBag.Message = "Author Added";
                return View();
            }
            ModelState.AddModelError("a1", "Author already added");
            return View();

        }

        public ActionResult Viewx()
        {
            return View();
        }
    }


}