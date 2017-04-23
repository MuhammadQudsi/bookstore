using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Bookstore
    {
    }

    public class Book {
        [Key]
        public int ISBN  { get; set; }
        public string BookName { get; set; }
        public Publisher PublishedBy { get; set; }
        public string Category { get; set; }
        public Author WrittenBy { get; set; }
        public Order Includes { get; set; }
    }

    public class Publisher {
        [Key]
        public int publisherID { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string email { get; set; }

    }
    public class Author {
        [Key]
        public int AuthorID { get; set; }
        public int BookID { get; set; }
        public string AuthorName { get; set; }

    }
    public class Billing{
        [Key]
        public int InvoiceNo { get; set; }
        public int CustomerNo { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int ISBN { get; set; }
        public string BookName { get; set; }
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

        [Key]
        public int OrderId { get; set; }
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

        public int ISBN { get; set; }
        public int QuantityInOrder { get; set; }
        public int QuantityInHand { get; set; }
        public string BookName { get; set; }


        public ICollection<Book> Books { get; set; }

    }
    
  
}