using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int PersonID { get; set; }
        public string PPhoto { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Contact { get; set; }
    }
}