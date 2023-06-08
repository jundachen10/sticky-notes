using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stickynotes.Models;

namespace stickynotes.Data
{
    public class stickynotesContext : DbContext
    {
        public stickynotesContext (DbContextOptions<stickynotesContext> options)
            : base(options)
        {
        }

        public DbSet<stickynotes.Models.Note> Note { get; set; } = default!;
    }
}
