using Microsoft.EntityFrameworkCore;
using NMagazine.Core.Models;
using NMagazine.Data.Contexts;
using NMagazine.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMagazine.Data.Repositories.Implements
{
    public class CategoryRepository:ICategoryRepository
    {
        readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
         public async Task<bool> AddAsync(Category category)
        {
            var entry = await _context.AddAsync(category);
            return entry.State == EntityState.Added;
        }
    }
}
