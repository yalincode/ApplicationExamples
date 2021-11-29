using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretWFA.Entities
{
    public class DetailOrder
    {
        public int PersonId { get; set; }
        public int OrderId { get; set; }
        public int ProductCode { get; set; }
        public string OrderName { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
