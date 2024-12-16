using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Banciu_Adrian_Lab2.Models;

namespace Banciu_Adrian_Lab2.Data
{
    public class Banciu_Adrian_Lab2Context : DbContext
    {
        public Banciu_Adrian_Lab2Context (DbContextOptions<Banciu_Adrian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Banciu_Adrian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Banciu_Adrian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Banciu_Adrian_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
