using Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Dto
{
    public class ProductDetailsDto:IDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string CategoryName { get; set; }
    }
}
