using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EticaretWFA.DAL
{
    public class DetailRepository
    {
        public void AddDetailProduct(DetailOrder detail)
        {
            detail.OrderId = (++DataBase.DetailsId);
            DataBase.Details.Add(detail);
        }

        public DetailOrder FindById(int id)
        {
            var dbOrder = DataBase.Details.FirstOrDefault(t0 => t0.OrderId == id);
            return dbOrder;
        }

        public void Delete(int id)
        {
            var dbOrder = FindById(id);
            if (dbOrder!=null)
            {
                DataBase.Details.Remove(dbOrder);
            }
        }

        public void Update(DetailOrder detail)
        {
            var dbOrder = FindById(detail.OrderId);
            if (dbOrder!=null)
            {
                dbOrder.OrderCount = detail.OrderCount;
            }
        }

        public List<DetailOrder> Get (int PersonId)
        {
            return DataBase.Details.Where(t0 => t0.PersonId == PersonId).ToList();
        }
    }
}
