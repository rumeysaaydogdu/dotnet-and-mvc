using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendMail.Models
{
    public class Mail
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}