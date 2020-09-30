using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BusinesssCampagneMail.Models;

namespace BusinesssCampagneMail.Database
{
    class EfContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Campagne> Campagnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=campagne.db");
    }
}
