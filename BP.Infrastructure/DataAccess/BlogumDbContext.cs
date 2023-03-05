using BP.Domain.Entities;
using BP.Infrastructure.EntityMapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.DataAccess
{
    public class BlogumDbContext:IdentityDbContext<AppUser>
    {

        public BlogumDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMapping());
            builder.ApplyConfiguration(new CategoryMapping());


            base.OnModelCreating(builder);
        }


    }
}
