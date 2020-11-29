using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Momeu_Olivia_Lab8.Models;

namespace Momeu_Olivia_Lab8.Data
{
    public class Momeu_Olivia_Lab8Context : DbContext
    {
        public Momeu_Olivia_Lab8Context (DbContextOptions<Momeu_Olivia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Momeu_Olivia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Momeu_Olivia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Momeu_Olivia_Lab8.Models.Category> Category { get; set; }

        public DbSet<Momeu_Olivia_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
