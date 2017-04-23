using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapSite1.Models
{
    public class Bookstore
    {
    }

    public class Book {
        [Key]
        public string ISBN  { get; set; }
        public string BookName { get; set; }
        
        public string Category { get; set; }
        public ICollection<Author> WrittenBy { get; set; }
        public ICollection<Order> Includes { get; set; }
    }

    
    public class Author {
        public string AuthorID { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Book> BooksWritten { get; set; }

    }
    public class Billing
    {
        [Key]
        public string invoiceno { get; set; }
        public int customerno { get; set; }
        public DateTime date { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
    }

    public class Employee : ApplicationUser
    {
        public string hiredate { get; set; }
        public string position { get; set; }
    }


    public class Customer : ApplicationUser
    {
       public string CreditCard { get; set; }
    }


    public class Order
    {
        
        public Order()
        {
            Books = new HashSet<Book>();
        }


        public string orderid { get; set; }
        public Customer BoughtBy { get; set; }
        public Employee ReceivedBy { get; set; }
        public DateTime orderdate { get; set; }
        public ICollection<Book> Books { get; set; }
    }


    public class Inventory
    {
        public Inventory() {
            Books = new HashSet<Book>();
        }
        [Key]
        public string isbn { get; set; }
        public int quantityInOrder { get; set; }
        public int quantityInHand { get; set; }
        public string title { get; set; }


        public ICollection<Book> Books { get; set; }

    }
    
  
}