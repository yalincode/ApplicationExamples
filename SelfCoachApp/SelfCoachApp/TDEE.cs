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
    public partial class TDEE : Form
    {
        public TDEE()
        {
            InitializeComponent();
        }

        public MainForm mainForm { get; set; }

        double bodyFat = 0;
        


        private void TDEE_Load(object sender, EventArgs e)
        {
            
        }
        private void btnBodyFatCalculate_Click(object sender, EventArgs e)
        {
            
            string height = txtHeight.Text;
            string neck = txtNeck.Text;
            string waist = txtWaist.Text;
            string hip = txtHip.Text;
            try
            {
                bodyFat = CalculateBodyFat(waist, neck, height, hip);

                if (bodyFat<=0)
                {
                    throw new Exception("Somthing went wrong! Calculate again");
                }
                gbTDEE.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                gbTDEE.Enabled = false;
            }

            string compare = CompareBodyFat(bodyFat);

            lblBodyFatFirs.Text = $"Body Fat(%): {(int)bodyFat}";
            lblCompare.Text = compare;

            lblBodyFatSec.Text = $"Body Fat(%): {(int)bodyFat}";

            comboBox1.SelectedIndex = 0;
        }

        
        public double CalculateBodyFat(string waist,string neck,string height,string hip)
        {
            double waistValue = Convert.ToDouble(waist);
            double neckValue = Convert.ToDouble(neck);
            double heightValue = Convert.ToDouble(height);
            double hipValue = Convert.ToDouble(hip);
            double bfResult = 0;
            
            if (rbMale.Checked)//For male
            {
                bfResult = (495 / (1.0324 - 0.19077 * (Math.Log10(waistValue - neckValue)) + 0.15456 * (Math.Log10(heightValue)))) - 450;   
            }
            else//For Famale
            {
                bfResult = (495 / (1.29579 - 0.35004 * (Math.Log10(waistValue+hipValue - neckValue)) + 0.22100 * (Math.Log10(heightValue)))) - 450;
            }
            if (bfResult>=1 && bfResult<=70)
            {
                return bfResult;
            }
            else
            {
                return 0;
            }
        }
        
        public string CompareBodyFat(double bodyFat)
        {
            if (rbMale.Checked)//For Male
            {
                if (bodyFat >= 1 && bodyFat <= 5)
                {
                    return "Essential fat";
                }
                else if (bodyFat > 5 && bodyFat <= 13)
                {
                    return "Athletes";
                }
                else if (bodyFat > 13 && bodyFat <= 17)
                {
                    return "Fitness";
                }
                else if (bodyFat > 17 && bodyFat <= 24)
                {
                    return "Average";
                }
                else if (bodyFat > 24 && bodyFat <= 65)
                {
                    return "Obese";
                }
                else
                {
                    return "Somthing went wrong!";
                }
                
            }

            else//For Famale
            {
                if (bodyFat >= 10 && bodyFat <= 13)
                {
                    return "Essential fat";
                }
                else if (bodyFat > 13 && bodyFat <= 20)
                {
                    return "Athletes";
                }
                else if (bodyFat > 20 && bodyFat <= 24)
                {
                    return "Fitness";
                }
                else if (bodyFat > 24 && bodyFat <= 31)
                {
                    return "Average";
                }
                else if (bodyFat > 31 && bodyFat <= 70)
                {
                    return "Obese";
                }
                else
                {
                    return "Somthing went wrong!";
                }
            }
        }

        private void btnCalculateCalorie_Click(object sender, EventArgs e)
        {
            //BMI= Weight (kg) / Height (m)²
            //BMR=370+(9,82*Lean Body Mass
            double age = Convert.ToDouble(txtAge.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            

            double BMR=CalculateBMR(height,weight,age);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    BMR=BMR * 1.2;
                    break;
                case 1:
                    BMR = BMR * 1.375;
                    break;
                case 2:
                    BMR = BMR * 1.55;
                    break;
                case 3:
                    BMR = BMR * 1.725;
                    break;
                case 4:
                    BMR = BMR * 1.9;
                    break;
            }

            if (rbGainWeight.Checked==true)
            {
                BMR += 400;
            }
            else if (rbLossWeight.Checked==true)
            {
                BMR -= 500;
            }

            lblCaloriesPerDay.Text =$"Calories Per Day: {(int)BMR}" ;
            lblCaloriesPerWeek.Text = $"Calories Per Week:{(int)BMR * 7} ";

           lblmacros.Text=CalculateMacro(BMR);

        }

        public double CalculateBMR(double Height,double weight,double age)//hata var düzelt!!!
        {
            double BMR = 0;
            
            if (rbMale.Checked)
            {
                BMR = (10 * weight) + (6.25 * Height) - (5 * age) + 5;
            }
            else if (rbFamele.Checked)
            {
                BMR = (10 * weight) + (6.25 * Height) + (5 * age) - 161;
            }
            else
            {
                MessageBox.Show("Select Gender Status!");
            }
            return BMR;
        }

        public string CalculateMacro(double bmr)
        {
            double protein = (bmr * 30 / 100)/4;
            double fat = (bmr * 27 / 100)/9;
            double carb = (bmr * 43 / 100)/4;

            return $"{(int)protein} gr Protein ,{(int)fat} gr Fat, {(int)carb} gr Carb";
        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            txtAge.Text = "27";
            txtHeight.Text = "180";
            txtNeck.Text = "41";
            txtWaist.Text = "96";
            txtWeight.Text = "87";
            txtHip.Text = "100";

        }
    }
}
