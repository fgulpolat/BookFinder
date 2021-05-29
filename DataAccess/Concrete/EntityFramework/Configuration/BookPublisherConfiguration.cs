using Entity.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Configuration
{
    public class BookPublisherConfiguration : IEntityTypeConfiguration<BookPublisher>
    {
        public void Configure(EntityTypeBuilder<BookPublisher> builder)
        {
            builder.ToTable("BookPublisher");
            builder.HasKey(bp => new { bp.PublisherId, bp.BookId });
    //        builder.HasOne<Book>(bp => bp.book)
    //.WithMany(s => s.StudentCourses)
    //.HasForeignKey(sc => sc.SId);


    //        modelBuilder.Entity<StudentCourse>()
    //            .HasOne<Course>(sc => sc.Course)
    //            .WithMany(s => s.StudentCourses)
    //            .HasForeignKey(sc => sc.CId);

        }
    }
}
