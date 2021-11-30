using EticaretWFA.FakeDb;
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
    public partial class SiparisGecmisi : Form
    {
        public SiparisGecmisi()
        {
            InitializeComponent();
        }

        private void SiparisGecmisi_Load(object sender, EventArgs e)
        {
            FillForm();

        }

        public void FillForm()
        {
            lblName.Text = DataBase.people[0].PersonName;

            grdGecmis.DataSource = null;
            grdGecmis.DataSource = DataBase.HistoryOrder;
        }
    }
}
