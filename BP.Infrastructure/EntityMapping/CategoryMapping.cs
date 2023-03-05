using BP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure.EntityMapping
{
    public class CategoryMapping: BaseEntityMapping<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(35).HasColumnType("varchar");
            builder.Property(x => x.Code).IsRequired().HasMaxLength(18).HasColumnType("varchar");


            base.Configure(builder);
        }

    }
}
