using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5.Data
{
    public class Lab5Context : DbContext
    {
        public Lab5Context (DbContextOptions<Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Lab5.Models.Book> Book { get; set; } = default!;
    }
}
