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

        string[] users = new string[0];
        private void btnStart_Click(object sender, EventArgs e)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = textBox1.Text;
            
            this.Hide();
            var Tdee = new TDEE();
            Tdee.mainForm = this;
            Tdee.ShowDialog();

            
        }
    }
}
