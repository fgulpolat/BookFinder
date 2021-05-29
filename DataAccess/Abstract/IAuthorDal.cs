using Core.Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IAuthorDal: IEntityRepository<Author>
    {
    }
}
