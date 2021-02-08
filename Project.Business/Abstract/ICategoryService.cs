using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
