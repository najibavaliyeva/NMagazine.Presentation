using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMagazine.Service.DTOs.Category
{
    public record CategoryUpdateDto
    {
         public string? Name { get; set; }
    }
}
