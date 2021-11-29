using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiApp
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        public Form1 form1 { get; set; }

        public (string name, string phone) kisi;
        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string phone = txtPhone.Text;
            kisi = (name, phone);

            
            this.Close();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            string name = "";
            string phone = "";
            kisi = (name, phone);
            this.Close();
        }
    }
}
