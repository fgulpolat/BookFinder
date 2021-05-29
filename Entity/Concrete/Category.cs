using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Category:EntityBase,IEntity
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
