using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GelAllByCategoryId(int id);
        List<Product> GelByUnitPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails(); 
    }
}
