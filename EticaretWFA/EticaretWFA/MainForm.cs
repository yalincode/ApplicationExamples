using EticaretWFA.Core;
using EticaretWFA.DAL;
using EticaretWFA.Entities;
using EticaretWFA.FakeDb;
using EticaretWFA.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EticaretWFA
{
    public partial class MainForm : Form
    {
        DetailRepository detailRepository;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DummyData.Seed();
            FillForm();
        }
        private void FillForm()
        {
            FillCmbData(); 
        }
        private void FillCmbData()
        {
            foreach (var item in DataBase.products)
            {
                cmbProducts.Items.Add(item.ProductName);
            }
        }
        public void FillLblData()
        {
            if (cmbProducts.SelectedIndex>-1)
            {
                ShowPrice(cmbProducts.SelectedIndex);
            }
        }
        public void ShowPrice(int index)
        {
            lblProductPrice.Text = $"Ürün Fiyatı=> {DataBase.products[index].ProductPrice} TL";
        }
        public void FillImage()
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Image = Image.FromFile(DataBase.products[cmbProducts.SelectedIndex].ProductPicture);
        }
        public void FillDescription()
        {
            txtDescription.Text = DataBase.products[cmbProducts.SelectedIndex].ProductDescription;
        }
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillLblData();
            FillImage();
            FillDescription();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nudCount.Value>0)
            {
                UrunEkle(cmbProducts.SelectedIndex, (int)nudCount.Value);
                Utilities.ShowSuccessMessage(ConstMessages.RecordSuccessMessage);
                RestartSelection();
            }
            else
            {
                Utilities.ShowErrorMessage(ConstMessages.RecordErrorOrderMessage);
            }
            
        }
        public void UrunEkle(int id,int count)
        {
            detailRepository = new DetailRepository();
            var Product = DataBase.products[id];
            DetailOrder detailOrder = new DetailOrder();
            detailOrder.PersonId = DataBase.people[0].PersonId;
            detailOrder.OrderName = Product.ProductName;
            detailOrder.OrderPrice = Product.ProductPrice;
            detailOrder.OrderCount = count;
            detailOrder.ProductCode = Product.ProductCode;
            detailRepository.AddDetailProduct(detailOrder);
            lblProductCount.Text = $"Ürün Adedi: {UrunAdetHesapla()}";
            lblToplamFiyat.Text= $"Toplam Fiyat: {UrunToplamFiyatHesapla()} TL";
        }

        public int UrunAdetHesapla()
        {
            var count=0;
            foreach (var item in DataBase.Details)
            {
                count += item.OrderCount;
            }
            return count;
        }
        public decimal UrunToplamFiyatHesapla()
        {
            decimal Toplam = 0;
            foreach (var item in DataBase.Details)
            {
                Toplam += item.OrderPrice * item.OrderCount;
                
                
            }
            return Toplam;
        }

        private void btnSepeteGit_Click(object sender, EventArgs e)
        {
            Sepetim sepet = new Sepetim();
            sepet.ShowDialog();
        }

        public void RestartSelection()
        {
            nudCount.Value = 0;
            cmbProducts.SelectedIndex = 0;
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            if (DataBase.HistoryOrder.Count>0)
            {
                SiparisGecmisi form = new SiparisGecmisi();
                form.ShowDialog();
            }
            else
            {
                Utilities.ShowErrorMessage("Bir Sipariş geçmişi bulunamadı");
            }
            
        }
    }
}
