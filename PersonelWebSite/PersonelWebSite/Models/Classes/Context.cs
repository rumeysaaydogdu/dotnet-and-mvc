using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonelWebSite.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}