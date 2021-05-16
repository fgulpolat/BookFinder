using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity.Abstract
{
   public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
