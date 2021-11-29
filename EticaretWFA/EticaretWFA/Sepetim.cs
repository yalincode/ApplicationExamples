using EticaretWFA.DAL;
using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using EticaretWFA.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EticaretWFA
{
    public partial class Sepetim : Form
    {
        DetailRepository detailRepository;

        public Sepetim()
        {
            InitializeComponent();
        }

        private void Sepetim_Load(object sender, EventArgs e)
        {
            detailRepository = new DetailRepository();
            RefreshGridData();
        }

        
        public void RefreshGridData()
        {
            int id=DataBase.people[0].PersonId;
            grdSepet.DataSource = null;
            grdSepet.DataSource = GetVMGrid(detailRepository.Get(id));
            GridVisibility();
        }

        public List<VMGridSepet> GetVMGrid (List<DetailOrder> sepet)
        {
            List<VMGridSepet> gridSepet = new List<VMGridSepet>();
            
            foreach (var item in sepet)
            {
                VMGridSepet newSepet = new VMGridSepet();
                newSepet.ProductId = item.OrderId;
                newSepet.ProductName = item.OrderName;
                newSepet.ProductCount = item.OrderCount;
                newSepet.TotalPrice = item.OrderCount*item.OrderPrice;
                gridSepet.Add(newSepet);
            }
            return gridSepet;
        }
        private void GridVisibility()
        {
            grdSepet.Columns["ProductId"].HeaderText = "Sipariş Kodu";
            grdSepet.Columns["ProductName"].HeaderText = "Ürün Adı";
            grdSepet.Columns["ProductCount"].HeaderText = "Ürün Adedi";
            grdSepet.Columns["TotalPrice"].HeaderText = "Toplam Fiyat";
        }



    }
}
