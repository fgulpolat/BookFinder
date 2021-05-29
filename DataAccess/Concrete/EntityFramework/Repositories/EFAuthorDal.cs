using Core.Data.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
   public class EFAuthorDal:EFRepositoryBase<Author,BookFinderContext>,IAuthorDal
    {
    }
}
