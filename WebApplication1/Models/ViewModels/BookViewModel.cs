using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Ask wajeeh why added
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class BookViewModel
    {
        [Required]
        public string BookName { get; set; }
        public string Author { get; set; }
       
    }
}