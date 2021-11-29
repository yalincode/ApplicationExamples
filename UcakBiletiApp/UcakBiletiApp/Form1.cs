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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<(string name, string phone)> kisiler = new List<(string name, string phone)>();

        private void Form1_Load(object sender, EventArgs e)
        {
            int koltukNo = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j==2)
                    {
                        continue;
                    }
                    Button btn = new Button();
                    btn.Height = btn.Width = 30;
                    btn.BackColor = Color.Blue;
                    btn.Text = koltukNo.ToString();
                    koltukNo++;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font,FontStyle.Bold);//Yazıyı kalınlaştırmak.
                    btn.Top = 105 + 40 * i;
                    btn.Left = 5 + 40 * j;
                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);
                }
            }
        }

        public string btnName = "";
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            Rezervasyon rezervasyon=new Rezervasyon();
            rezervasyon.form1 = this;
            rezervasyon.ShowDialog();

           
        }
    }
}
