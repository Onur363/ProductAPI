using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Concrete;
using System;


namespace Project.DataAccess.Concrete.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(@"Categories", @"dbo");
            builder.HasKey(x => x.CategoryID);
            builder.Property(x => x.CategoryID).HasColumnName("CategoryID");
            builder.Property(x => x.CategoryName).HasColumnName("CategoryName");
            builder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
