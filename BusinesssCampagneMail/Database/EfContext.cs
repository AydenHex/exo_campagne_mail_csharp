using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BusinesssCampagneMail.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BusinesssCampagneMail.Database
{
    class EfContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Campagne> Campagnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\royer\source\repos\CampagneMail\database.db");
    }
}
