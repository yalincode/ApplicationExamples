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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KoltukAta();
        }

        List<Ziyaretci> ziyaretciList = new List<Ziyaretci>();
        List<PictureBox> pictureBox = new List<PictureBox>();
        

        public void KoltukAta()
        {

            for (int i = 0; i < 110; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = i.ToString();
                pb.Width = 40;
                pb.Height = 30;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ImageLocation = @"D:\freeSeat.jpg";
                pb.Click += Pb_Click;
                pictureBox.Add(pb);
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        public void koltukDoldur(Ziyaretci z1,int i)
        {
            ziyaretciList.Add(z1);
            pictureBox[i].Image = SinemaOtomasyonu.Properties.Resources.dolu;

        }

        public void koltukBosalt(Ziyaretci z2,int i)
        {
            
            pictureBox[i].Image = SinemaOtomasyonu.Properties.Resources.freeSeat;
        }

        

        //List<List<string>> liste=new List<List<string>>();

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            var rezervasyon = new Rezervasyon();
            rezervasyon.form1 = this;
            rezervasyon.x = pictureBox.IndexOf(pb);
            
            rezervasyon.ShowDialog();
            
        }
    }
}
