using Core.Data.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
   public class EFBookDal:EFRepositoryBase<Book,BookFinderContext>
    {
    }
}
