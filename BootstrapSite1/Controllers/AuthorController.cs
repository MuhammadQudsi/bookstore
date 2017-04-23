using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapSite1.Models;
using BootstrapSite1.Models.ViewModels;

namespace BootstrapSite1.Controllers
{
    public class AuthorController : Controller
    {
        [HttpPost]
        public ActionResult View(AuthorViewModel model)
        {
            var db = Globals.GetDatabase();
            var author = new Author();
            author.AuthorName = model.AuthorName;
            db.Authors.Add(author);
            db.SaveChanges();

            if (!db.Authors.Any(c => c.AuthorName == model.AuthorName))
            {
                db.Authors.Add(author);
                db.SaveChanges();
                ViewBag.Message = "Author Added";
                return View();
            }

            ModelState.AddModelError(string.Empty, "Author Already in Records.");
            return View();


        }

        public ActionResult View(FormCollection form)
        {

           string name = form["AuthorName"];
            return View();
        }

    }


}