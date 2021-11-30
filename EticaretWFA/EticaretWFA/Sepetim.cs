using EticaretWFA.Core;
using EticaretWFA.DAL;
using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using EticaretWFA.Helper;
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
            int id = DataBase.people[0].PersonId;
            grdSepet.DataSource = null;
            grdSepet.DataSource = GetVMGrid(detailRepository.Get(id));
            GridVisibility();
        }

        public List<VMGridSepet> GetVMGrid(List<DetailOrder> sepet)
        {
            List<VMGridSepet> gridSepet = new List<VMGridSepet>();

            foreach (var item in sepet)
            {
                VMGridSepet newSepet = new VMGridSepet();
                newSepet.ProductId = item.OrderId;
                newSepet.ProductName = item.OrderName;
                newSepet.ProductCount = item.OrderCount;
                newSepet.TotalPrice = item.OrderCount * item.OrderPrice;
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


        int SelectedId;
        private void grdSepet_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var item = FindItem(grdSepet.SelectedRows[0].Index);
                SelectedId = item.OrderId;
                Utilities.ShowSuccessMessage("Ürün seçimi yaptınız.");
            }
            catch (Exception ex)
            {

                Utilities.ShowErrorMessage(ex.Message);
            }

        }
        public DetailOrder FindItem(int index)
        {
            var item = DataBase.Details[index];
            return item;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedId > 0)
            {
                DialogResult dialogResult = Utilities.ShowDialogResultInformationMessage(ConstMessages.RecordDeleteQuestionMessage);
                if (dialogResult == DialogResult.OK)
                {
                    detailRepository.Delete(SelectedId);
                    RefreshGridData();
                    Utilities.ShowSuccessMessage(ConstMessages.RecordDeleteSuccessMessage);
                    RefreshSelections();
                }
            }
            else
            {
                Utilities.ShowErrorMessage(ConstMessages.RecordUrunSecimErorMessage);
            }
        }

        public void RefreshSelections()
        {
            SelectedId = 0;
        }

        private void btnProductCountUp_Click(object sender, EventArgs e)
        {
            if (SelectedId > 0)
            {
                var item = detailRepository.FindById(SelectedId);
                item.OrderCount++;
                RefreshGridData();
                GridFocus();
            }
            else
            {
                Utilities.ShowSuccessMessage("Ürün seçimi yaptınız.");
            }
        }
        private void btnProductCountDown_Click(object sender, EventArgs e)
        {
            if (SelectedId > 0)
            {
                var item = detailRepository.FindById(SelectedId);
                if (item.OrderCount > 1)
                {
                    item.OrderCount--;
                    RefreshGridData();
                    GridFocus();
                }
                else
                {
                    Utilities.ShowErrorMessage("Ürün daha fazla azaltılamaz");
                }
            }
            else
            {
                Utilities.ShowSuccessMessage("Ürün seçimi yaptınız.");
            }

        }
        public void GridFocus()
        {
            var items = grdSepet.DataSource as List<VMGridSepet>;
            int index;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ProductId == SelectedId)
                {
                    index = i;
                    grdSepet.Rows[index].Selected = true;
                }
            }
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {

            decimal toplamAdet = grdSepet.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells[2].Value));
            decimal toplamFiyat = grdSepet.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells[3].Value));

            MessageBox.Show($"Siparişiniz verildi.\nSipariş Adedi=> {toplamAdet} \nSipariş Toplam Fiyatı {toplamFiyat} TL");

            DataBase.HistoryOrder = new List<DetailOrder>(DataBase.Details);
            DataBase.Details.Clear();

            grdSepet.DataSource = null;

            this.Close();

        }
    }
}
