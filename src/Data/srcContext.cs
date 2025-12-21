using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data
{
    public class srcContext : DbContext
    {
        public srcContext (DbContextOptions<srcContext> options)
            : base(options)
        {
        }

        public DbSet<src.Models.Article> Article { get; set; } = default!;
    }
}
