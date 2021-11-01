using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseProject
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        public MainForm mainForm { get; set; }

        private void WharehouseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                string warehouseName = txtWarehouseName.Text;
                mainForm.AddWarehouse(warehouseName);
                MessageBox.Show("Addition Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
