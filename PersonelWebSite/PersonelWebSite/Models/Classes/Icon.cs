using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models.Classes
{
    public class Icon
    {
        [Key]
        public int IconID { get; set; }
        public string IconName { get; set; }
        public string Link { get; set; }

    }
}
