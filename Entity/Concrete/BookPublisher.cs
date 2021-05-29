using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class BookPublisher:EntityBase,IEntity
    {
      
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
