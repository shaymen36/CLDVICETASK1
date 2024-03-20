using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryApplication1.Models;

namespace LibraryApplication1.Data
{
    public class LibraryApplication1Context : DbContext
    {
        public LibraryApplication1Context (DbContextOptions<LibraryApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<LibraryApplication1.Models.Book> Book { get; set; } = default!;
    }
}
