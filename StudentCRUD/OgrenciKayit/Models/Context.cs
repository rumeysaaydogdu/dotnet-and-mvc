using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OgrenciKayit.Models
{
    public class Context : DbContext
    {
        public DbSet<Ogrenci> Ogrencis { get; set; }
    }
}