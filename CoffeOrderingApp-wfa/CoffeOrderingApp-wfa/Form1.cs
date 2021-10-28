using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeOrderingApp_wfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] menu = new string[0];
        double[] price = new double[0];

        private void btnReady_Click(object sender, EventArgs e)
        {
            Array.Resize(ref menu, 7);
            string[] cofees = { "Filtre kahve", "Gingerbread Frappuccino", "Toffee Nut Frappuccino", "Caramel Cream Frappuccino", "Buzlu Toffee Nut Latte", "White Chocolate Mocha", "Buzlu Cappuccino" };
            Array.Copy(cofees, menu, 7);

            double[] coffeePrices = { 8, 15, 20, 22, 18, 14, 35 };
            Array.Resize(ref price, 7);
            Array.Copy(coffeePrices, price, 7);

            for (int i = 0; i < menu.Length; i++)
            {
                lstMenu.Items.Add($"{i + 1} - {menu[i]} - {price[i]} TL");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbSmall.Checked = true;
        }

        private void btnEkleMunu_Click(object sender, EventArgs e)
        {
            try
            {
                string coffee = txtMenuCoffee.Text;
                double cofeePrice = Convert.ToDouble(txtMenuPrice.Text);
                Array.Resize(ref menu, menu.Length + 1);
                menu[menu.Length - 1] = coffee;
                Array.Resize(ref price, price.Length + 1);
                price[price.Length - 1] = cofeePrice;
                lstMenu.Items.Add($"{menu.Length} - {menu[menu.Length - 1]} - {price[price.Length - 1]} TL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSilMenu_Click(object sender, EventArgs e)
        {

            try
            {
                if (menu.Length > 0)
                {
                    lstMenu.Items.Clear();
                    Array.Resize(ref menu, 0);
                    Array.Resize(ref price, 0);
                }
                else
                {
                    MessageBox.Show("Menü boş olduğu için silme işlemi yapamazsınız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        
        double TotalNumber = 0;
        double[] TotalNumberArray =new double[0];
        string[] totalOrder = new string[0];

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int coffeNumber = Convert.ToInt32(txtCoffeeChoice.Text);
                double number = 0;

                if (rbSmall.Checked)
                {
                    number = price[coffeNumber - 1] * 1;
                }
                else if (rbTall.Checked)
                {
                    number = price[coffeNumber - 1] * 1.25;
                }
                else if (rbGrande.Checked)
                {
                    number = price[coffeNumber - 1] * 1.50;
                }
                Array.Resize(ref TotalNumberArray, TotalNumberArray.Length + 1);
                TotalNumberArray[TotalNumberArray.Length - 1] = number;

                TotalNumber += TotalNumberArray[TotalNumberArray.Length - 1];
                
                listBox1.Items.Add($"{menu[coffeNumber - 1]} eklendi.");
                listBox1.Items.Add($"Toplam Fiyat: {TotalNumber}");

                Array.Resize(ref totalOrder, totalOrder.Length + 1);
                totalOrder[totalOrder.Length - 1] = menu[coffeNumber - 1];

                txtCoffeeChoice.Text = "";

                txtName.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtName.Enabled = true;
            }
        }

        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (cbChocolate.Checked)
            {
                TotalNumber += 5;
            }
            if (cbCoffee.Checked)
            {
                TotalNumber += 10;
            }
            if (cbCookie.Checked)
            {
                TotalNumber += 15;
            }
            if (cbCake.Checked)
            {
                TotalNumber += 25;
            }

            lblTotalPrice.Text = TotalNumber.ToString()+" TL";
            lstSiparisDurumEkrani.Items.Add($"{name} isimli kişinin siparişi hazırlanıyor.");
            lstSiparisDurumEkrani.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            timer1.Start();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            Array.Resize(ref TotalNumberArray, 0);
            Array.Resize(ref totalOrder, 0);
            TotalNumber = 0;
            lstSiparisDurumEkrani.Items.Clear();
            listBox1.Items.Clear();
            cbChocolate.Checked = false;
            cbCoffee.Checked = false;
            cbCookie.Checked = false;
            cbCake.Checked = false;
            rbSmall.Checked = false;
            rbTall.Checked = false;
            rbGrande.Checked = false;
            txtCoffeeChoice.Text = "";
            txtMenuCoffee.Text = "";
            txtName.Text = "";
            lblTotalPrice.Text = "";
            txtName.Enabled = true;
            label11.ForeColor = Color.Red;
            lblSaniye.ForeColor = Color.Red;
            label11.Text = "Sipariş Hazırlanmasına Kalan süre:";
        }

        int sec = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            lblSaniye.Text = sec.ToString();
            lstSiparisDurumEkrani.Cursor = Cursors.WaitCursor;

            if (sec==0)
            {
                lstSiparisDurumEkrani.Cursor = Cursors.Default;
                string name = txtName.Text;
                lstSiparisDurumEkrani.Items.Add($"{name} isimli kişinin siparişi hazır!");
                
                foreach (var item in totalOrder)
                {
                    lstSiparisDurumEkrani.Items.Add(item);
                }
                lstSiparisDurumEkrani.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                label11.Text = "Siparişiniz Hazır!";
                label11.ForeColor = Color.Green;
                lblSaniye.ForeColor= Color.Green;
                sec += 5;

                timer1.Stop();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                TotalNumber -= TotalNumberArray[TotalNumberArray.Length - 1];
                Array.Resize(ref TotalNumberArray, TotalNumberArray.Length - 1);
                Array.Clear(totalOrder, totalOrder.Length - 1, 1);
                Array.Resize(ref totalOrder, totalOrder.Length - 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
