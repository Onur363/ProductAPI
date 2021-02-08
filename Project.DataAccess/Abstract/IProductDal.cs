using Project.Commons.DataAccess;
using Project.Entities.Concrete;
using Project.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailsDto> GetProductDetails();
    }
}
