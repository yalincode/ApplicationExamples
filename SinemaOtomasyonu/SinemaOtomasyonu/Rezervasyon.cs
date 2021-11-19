using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        public Form1 form1 { get; set; }
        public int x;
        Ziyaretci ziyaretci = new Ziyaretci();
        private void button2_Click(object sender, EventArgs e)
        {
            
            ziyaretci.Ad = txtAd.Text;
            ziyaretci.TC = txtTC.Text;
            if (rbBay.Checked == true)
            {
                ziyaretci.Cinsiyet = "Bay";
            }
            else
            {
                ziyaretci.Cinsiyet = "Bayan";
            }

            form1.koltukDoldur(ziyaretci,x);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.koltukBosalt(ziyaretci,x);
            this.Close();
        }
    }
}
