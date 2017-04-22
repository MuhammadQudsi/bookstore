using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Bookstore
    {
    }
    public class book {
        public int BookID { get; set; }
        public string name { get; set; }
        public int PublisherID { get; set; }
        public string Category { get; set; }
        public int AuthorID { get; set; }
        public string bookType { get; set; }

    }
    public class publisher {
        public int publisherID { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string emaail { get; set; }

    }
    public class author {
        public int authorID { get; set; }
        public int BookID { get; set; }
        public string name { get; set; }

    }
    public class billing
    {
        public int invoiceno { get; set; }
        public int customerno { get; set; }
        public string date { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int isbn { get; set; }
        public string title { get; set; }
    }

    public class employee
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int telephone { get; set; }
        public string hiredate { get; set; }
        public string position { get; set; }
    }


    public class customer
    {
        public int customerid { get; set; }
        public int contact { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }


    public class order
    {
        public int orderid { get; set; }
        public int customerid { get; set; }
        public int empid { get; set; }
        public string orderdate { get; set; }
    }


    public class inventory
    {
        public inventory() {
            books = new HashSet<book>();
        }

        public int isbn { get; set; }
        public int quantityInOrder { get; set; }
        public int quantityInHand { get; set; }
        public string title { get; set; }


        public ICollection<book> books { get; set; }

    }

    public class hhh {

    }
}