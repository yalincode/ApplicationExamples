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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string[] warehouse = new string[0];

        public void AddWarehouse(string warehousenew)
        {
            if (!warehouse.Contains(warehousenew))
            {
                Array.Resize(ref warehouse, warehouse.Length + 1);
                warehouse[warehouse.Length - 1] = warehousenew;
            }
            else
            {
                throw new Exception("This warehouse has alredy been added");
            }
            
        }

        public bool DeleteWarehouse(string warehousenew)
        {
            int index = Array.IndexOf(warehouse, warehousenew); 
            
            if (index>-1)
            {
                Array.Clear(warehouse, index, 1);
                warehouse = ArrayNullClear(warehouse);
                return true;
            }
            else
            {
                return false;
            }
        }

        private string[] ArrayNullClear(string[] array)
        {
            string[] temp = new string[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (!string.IsNullOrEmpty(array[i]))
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = array[i];
                }
            }

            return temp;
        }


        /// <summary>
        /// Give us to warehouse list.
        /// </summary>
        /// <returns></returns>
        public string[] GetWharehouseList()
        {
            return this.warehouse;
        }

        public DialogResult WantDeleteMessage()
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Warehouse Solutions", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            return result;
        }

        private void newWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var warehouseForm = new WarehouseForm();
            warehouseForm.mainForm = this;
            warehouseForm.ShowDialog();
        }

        private void warehouseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var warehouseListForm = new WarehouseListForm();
            warehouseListForm.mainForm = this;
            warehouseListForm.ShowDialog();
        }
    }
}
