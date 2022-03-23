#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using biancarazorpages.Pages.bianca;

namespace biancarazorpages.Data
{
    public class biancarazorpagesContext : DbContext
    {
        public biancarazorpagesContext (DbContextOptions<biancarazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<biancarazorpages.Pages.bianca.Class> Class { get; set; }
    }
}
