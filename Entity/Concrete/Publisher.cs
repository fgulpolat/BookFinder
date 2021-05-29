using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Publisher:EntityBase,IEntity
    {
        public string Name { get; set; }
        public ICollection<BookPublisher> BookPublishers { get; set; }
    }
}
