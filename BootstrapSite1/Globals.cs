using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Web;
using BootstrapSite1.Models;

namespace BootstrapSite1
{
    public static class Globals
    {
        public static ApplicationDbContext GetDatabase() {

            return HttpContext.Current.GetOwinContext().Get<ApplicationDbContext>();
            
            }

        public static string ToCamelCase(string line) {

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(line.ToLower());
        }
    }
}