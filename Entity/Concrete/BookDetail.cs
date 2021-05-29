using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Concrete
{
   
   public class BookDetail: EntityBase, IEntity
    {
        public int NuberOfPages { get; set; }
        public DateTime? YearOfPrinting { get; set; }
        public Book Book { get; set; }
    }
}

