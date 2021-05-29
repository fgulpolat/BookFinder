using DataAccess.Concrete.EntityFramework.Configuration;
using Entity.Concrete;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
   public class BookFinderContext:DbContext
    {
       
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookFinder;Trusted_Connection=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Book>(new BookConfiguration());
            modelBuilder.ApplyConfiguration<Author>(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration<Publisher>(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<BookPublisher>(new BookPublisherConfiguration());
           
        }
    }
}
