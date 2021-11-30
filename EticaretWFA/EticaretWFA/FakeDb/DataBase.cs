using EticaretWFA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EticaretWFA.Entities.Product;

namespace EticaretWFA.FakeDb
{
    public class DataBase
    {
        public static int PersonId=0;
        public static List<Person> people = new List<Person>();

        public static int ProductId = 0;
        public static List<Product> products = new List<Product>();

        public static int DetailsId = 0;
        public static List<DetailOrder> Details = new List<DetailOrder>();

        public static List<DetailOrder> HistoryOrder = new List<DetailOrder>();
    }
}
