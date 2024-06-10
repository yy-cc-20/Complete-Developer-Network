using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CDN.API.Models;

namespace CDN.API.Data
{
    public class CDNAPIContext : DbContext
    {
        public CDNAPIContext (DbContextOptions<CDNAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CDN.API.Models.User> User { get; set; } = default!;
    }
}
