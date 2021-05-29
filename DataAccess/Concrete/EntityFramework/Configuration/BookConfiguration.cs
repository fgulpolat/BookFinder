using Entity;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(b =>b.Id);
            builder.Property(b => b.ISBN).HasMaxLength(12);
            builder.Property(b => b.Name).HasMaxLength(100).IsRequired(true);
            builder.HasOne<Author>(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
            builder.HasOne<BookDetail>(b => b.BookDetail).WithOne(b => b.Book).HasForeignKey<Book>(b => b.BookDetailId);

        }
    }
}
