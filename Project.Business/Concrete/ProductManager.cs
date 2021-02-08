using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public List<ProductDetailsDto> GetProducts()
        {
           return productDal.GetProductDetails();
        }
    }
}
