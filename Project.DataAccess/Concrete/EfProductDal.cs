using Project.Commons.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete.Context;
using Project.Entities.Concrete;
using Project.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ProjectContext>, IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (var context=new ProjectContext())
            {
                var result = (from product in context.Products
                              join category in context.Categories on product.CategoryID equals category.CategoryID
                              select new ProductDetailsDto
                              {
                                  ProductID = product.ProductID,
                                  CategoryID = product.CategoryID,
                                  CategoryName = category.CategoryName,
                                  ProductName = product.ProductName,
                                  QuantityPerUnit = product.QuantityPerUnit,
                                  UnitPrice = product.UnitPrice,
                                  UnitsInStock = product.UnitsInStock
                              }).ToList<ProductDetailsDto>();

                return result;
            }
        }
    }
}
