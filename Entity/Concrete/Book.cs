using Core.Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Book: EntityBase,IEntity
    {
        public string ISBN{ get; set; }
        public string Name { get; set; }
        public DateTime? YearOfPrinting { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<Publisher> Publishers { get; set; }

    }
}
