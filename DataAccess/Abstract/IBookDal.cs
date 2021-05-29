using Core.Data.Abstract;
using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IBookDal:IEntityRepository<Book>
    {

    }
}
