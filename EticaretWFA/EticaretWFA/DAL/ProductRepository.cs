using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretWFA.DAL
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            product.ProductId = (++DataBase.ProductId);
            DataBase.products.Add(product);
        }
    }
}
