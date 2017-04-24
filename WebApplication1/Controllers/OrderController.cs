using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult NewItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewItem(OrderViewModel model) {
            var db = Globals.GetDatabase();
            var order = new Order();
            var Book1 = new Book();
            var newcustomer = new Customer();
            Book1.BookName = model.book;
            newcustomer.FirstName = model.name;
            order.Books.Add(Book1);
            order.BoughtBy.FirstName = newcustomer.FirstName;
            return View();

        }

    }
}