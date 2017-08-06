using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SotreSite.Areas.Admin.Models
{
    public class DeveloperModel
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string PhotoUrl { get; set; }
        public HttpPostedFileBase PhotoFile { get; set; }
    }
}