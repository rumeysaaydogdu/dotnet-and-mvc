using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciKayit.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrID { get; set; }
        [StringLength(50)]
        public string OgrAd { get; set; }
        [StringLength(50)]
        public string OgrSoyad { get; set; }
        [StringLength(50)]
        public string OgrMail { get; set; }
        [StringLength(100)]
        public string OgrAdres { get; set; }
    }
}