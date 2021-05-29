using Core.Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Book: EntityBase,IEntity
    {
        public string ISBN{ get; set; }
        public string Name { get; set; }
        public virtual Author Author { get; set; }
        public virtual int AuthorId { get; set; }
        public ICollection<BookPublisher> BookPublishers { get; set; }
        public int BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; }
       
    }
}
