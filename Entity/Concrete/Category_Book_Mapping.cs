using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Category_Book_Mapping
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
