using Microsoft.EntityFrameworkCore;
using NMagazine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMagazine.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> categories { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
