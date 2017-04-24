using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class AuthorViewModel
    {
        [Required]
        public string AuthorName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string ContactNumber { get; set; }
    }
}