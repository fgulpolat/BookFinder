using Entity;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(200);
            builder.Ignore(a => a.Fullname);
            //  builder.HasMany<Book>(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
          
        }
    }
}
