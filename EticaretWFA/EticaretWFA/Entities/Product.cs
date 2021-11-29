using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EticaretWFA.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public string ProductPicture { get; set; }

        public enum Products
        {
            Iphone,
            Samsung,
            Xaomi,
            Oppo
        }
    }
}
