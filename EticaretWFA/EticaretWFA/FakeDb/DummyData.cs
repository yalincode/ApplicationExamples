using EticaretWFA.DAL;
using EticaretWFA.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EticaretWFA.Entities.Product;

namespace EticaretWFA.FakeDb
{
    public class DummyData
    {
        public static void Seed()
        {
            ProductRepository productRepository = new ProductRepository();

            var ProductNameArray = Enum.GetNames(typeof(Products));

            Product product1 = new Product() { ProductCode = 1, ProductName = ProductNameArray[0],ProductPrice=10000m,ProductDescription="En yenilikçi telefon",ProductPicture=@"C:\Users\Yalın SONATYÜKSEL\Desktop\TelefonResim\Iphone.jpg"};
            productRepository.AddProduct(product1);
            Product product2 = new Product() { ProductCode = 2, ProductName = ProductNameArray[1], ProductPrice = 9000m, ProductDescription = "2. en iyi telefon", ProductPicture = @"C:\Users\Yalın SONATYÜKSEL\Desktop\TelefonResim\Samsung.jpg" };
            productRepository.AddProduct(product2);
            Product product3 = new Product() { ProductCode = 3, ProductName = ProductNameArray[2], ProductPrice = 8000m, ProductDescription = "En fiyat performans telefonu", ProductPicture = @"C:\Users\Yalın SONATYÜKSEL\Desktop\TelefonResim\Xaomi.jpg" };
            productRepository.AddProduct(product3);
            Product product4 = new Product() { ProductCode = 4, ProductName = ProductNameArray[3], ProductPrice = 5000m, ProductDescription = "Acunun telefonu", ProductPicture = @"C:\Users\Yalın SONATYÜKSEL\Desktop\TelefonResim\Oppo.jpg" };
            productRepository.AddProduct(product4);
        }
    }
}
