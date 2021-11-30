using EticaretWFA.DAL;
using EticaretWFA.Entities;
using EticaretWFA.Helper;
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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text=="")
            {
                Utilities.ShowErrorMessage("Düzgün bir isim girin");
            }
            else
            {
                if (txtPhone.MaskCompleted)
                {
                    try
                    {
                        PersonRepository personRepository = new PersonRepository();
                        Person person = new Person();
                        person.PersonName = txtAdSoyad.Text;
                        person.PersonPhoneNumber = txtPhone.Text;
                        personRepository.AddPerson(person);
                        MainForm form = new MainForm();
                        form.ShowDialog();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Utilities.ShowErrorMessage(ex.Message);
                    }

                }
                else
                {
                    Utilities.ShowErrorMessage("Düzgün bir telefon numarası girin.");
                }
            }
        }
    }
}
