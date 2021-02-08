using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Products", @"dbo");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.ProductID).HasColumnName("ProductID");
            builder.Property(x => x.ProductName).HasColumnName("ProductName");
            builder.Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(x => x.UnitsInStock).HasColumnName("UnitsInStock");
            builder.Property(x => x.CategoryID).HasColumnName("CategoryID");

        }
    }
}
