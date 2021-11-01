using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        string userName = "Yalın";
        string password = "123";

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ChangePicture("LoginPicture");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tryName = txtuserName.Text;
            string tryPassword = txtpassWord.Text;

            if (tryName == userName && tryPassword == password)
            {
                this.Hide();
                var mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password eror.","WarehouseSolutions",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtuserName_Leave(object sender, EventArgs e)
        {
            string tryName = txtuserName.Text;
            ChangePicture(tryName);
        }

        void ChangePicture(string imageName)
        {
            try
            {
                pbloginPicture.Image = Image.FromFile($"{path}\\images\\{imageName}.jpg");
            }
            catch (Exception)
            {
                pbloginPicture.Image = Image.FromFile($"{path}\\images\\LoginPicture.png");
            }
        }
    }
}
