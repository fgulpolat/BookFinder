using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Category
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
