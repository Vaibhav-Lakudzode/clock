using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMapp.Entities.Library;

namespace EFMapp.DbContexts
{
    public class LibraryContext : DbContext
    {
        public string connectionString = @"Data Source=DESKTOP-8IR25PU\SQLEXPRESS;Initial Catalog=EntityFramework;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public DbSet<Author> Author { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public DbSet<Post> Post { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

