using Project.Entities.Concrete;
using Project.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface IProductService
    {
        List<ProductDetailsDto> GetProducts();
    }
}
