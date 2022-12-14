using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet <Admin> Admins { get; set; }
        public DbSet <Blog> Blogs { get; set; }
        public DbSet <Hakkimizda> Hakkimizdas { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Yorumlar> Yorumlars { get; set; }
        public DbSet <SubMail> SubMails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}