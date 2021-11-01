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
    public partial class WarehouseListForm : Form
    {
        public WarehouseListForm()
        {
            InitializeComponent();
        }

        public MainForm mainForm { get; set; }

        private void WarehouseListForm_Load(object sender, EventArgs e)
        {
            FormFill();
        }

        void FormFill()
        {
            lstWarehouseList.Items.Clear();
            string[] warehouseList = mainForm.GetWharehouseList();
            for (int i = 0; i < warehouseList.Length; i++)
            {
                lstWarehouseList.Items.Add(warehouseList[i]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = mainForm.WantDeleteMessage();
            
            if (deleteResult== DialogResult.OK)
            {
                if (lstWarehouseList.SelectedIndex > -1)
                {
                    string warehouseName = lstWarehouseList.SelectedItem.ToString();
                    bool result2 = mainForm.DeleteWarehouse(warehouseName);
                    if (result2 == true)
                    {
                        MessageBox.Show("Delete Successful");
                        FormFill();//we need refresh
                    }
                    else
                    {
                        MessageBox.Show("Delete Eror");
                    }
                }
            }

            
        }
    }
}
