using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Author: EntityBase,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get { return Name + " " + Surname; }}
        public ICollection<Book> Books { get; set; }
    }
}
