using Microsoft.EntityFrameworkCore.Migrations.Operations;
using NMagazine.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMagazine.Data.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<bool> AddAsync(Category category);
    }
}
