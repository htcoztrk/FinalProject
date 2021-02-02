using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ CategoryId=1, ProductId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15  }
                new Product{ CategoryId=2, ProductId=2, ProductName="Camera", UnitPrice=500, UnitsInStock=3  }
                new Product{ CategoryId=2, ProductId=3, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2  }
                new Product{ CategoryId=2, ProductId=4, ProductName="Klavye", UnitPrice=150, UnitsInStock=65  }
                new Product{ CategoryId=2, ProductId=5, ProductName="Bardak", UnitPrice=82, UnitsInStock=1  }
            };
        }
        public void Add(Product prodct)
        {
            
        }

        public void Delete(Product product)
        {
           
        }

        public List<Product> GetAll()
        {
            
        }

        public void Update(Product product)
        {
          
        }
    }
}
