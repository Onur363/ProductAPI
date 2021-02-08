using Project.Commons.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete.Context;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ProjectContext>,ICategoryDal
    {

    }
}
