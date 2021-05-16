using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Publisher_Book_Mapping
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
