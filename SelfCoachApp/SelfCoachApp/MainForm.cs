using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCoachApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         List<(string id, string name, string phone)> users = new List<(string id, string name, string phone)>();
        public (string id, string name, string phone) user;


        private void btnStart_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string userPhone = txtPhone.Text;
            string userİd = GenerateId();
            user = (userİd, userName, userPhone);
            users.Add(user);
            
            this.Hide();
            var Tdee = new TDEE();
            Tdee.mainForm = this;
            Tdee.ShowDialog();

            
        }
        public string GenerateId()
        {
            
            string id ="";
            foreach (var user in users)
            {
                if (!user.phone.Contains(txtPhone.Text))
                {
                    string customerCode = "MN";
                    id = customerCode + (users.Count + 1).ToString().PadLeft(7, '0');
                    
                }
            }

            return id;
        }
    }
}
