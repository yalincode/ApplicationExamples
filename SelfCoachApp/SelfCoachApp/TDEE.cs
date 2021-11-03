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
        bool status;

        private void TDEE_Load(object sender, EventArgs e)
        {
            
        }

        private void rbFamele_CheckedChanged(object sender, EventArgs e)
        {
            status = false;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            status = true;
        }

        private void btnBodyFatCalculate_Click(object sender, EventArgs e)
        {
            
            string height = txtHeight.Text;
            string neck = txtNeck.Text;
            string waist = txtWaist.Text;
            string hip = txtHip.Text;
            try
            {
                bodyFat = CalculateBodyFat(waist, neck, height, status, hip);

                if (bodyFat==0)
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

            string compare = CompareBodyFat(bodyFat, status);

            lblBodyFatFirs.Text = $"Body Fat(%): {(int)bodyFat}";
            lblCompare.Text = compare;

            lblBodyFatSec.Text = $"Body Fat(%): {(int)bodyFat}";

            comboBox1.SelectedIndex = 0;
        }

        
        public double CalculateBodyFat(string waist,string neck,string height,bool rbStatus,string hip)
        {
            double waistValue = Convert.ToDouble(waist);
            double neckValue = Convert.ToDouble(neck);
            double heightValue = Convert.ToDouble(height);
            double hipValue = Convert.ToDouble(hip);
            double bfResult = 0;
            
            if (rbStatus)//For male
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
        
        
        public string CompareBodyFat(double bodyFat,bool rbSatatus2)
        {
            if (rbSatatus2)//For Male
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
            string age = txtAge.Text;
            string weight = txtWeight.Text;

            double BMR=CalculateBMR(bodyFat,weight);

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
                BMR += 500;
            }
            else
            {
                BMR = BMR;
            }

            lblCaloriesPerDay.Text =$"Calories Per Day: {(int)BMR}" ;
            lblCaloriesPerWeek.Text = $"Calories Per Week:{(int)BMR * 7} ";

           lblmacros.Text=CalculateMacro(BMR);

        }

        public double CalculateBMR(double bodyFat,string weight)
        {
            double weightValue = Convert.ToDouble(weight);
           
            double LBM= (1 - bodyFat / 100) * weightValue;
            double BMR = 370 + (9.82 * LBM);

            
            return BMR;
        }

        public string CalculateMacro(double bmr)
        {
            double protein = (bmr * 30 / 100)/4;
            double fat = (bmr * 30 / 100)/9;
            double carb = (bmr * 40 / 100)/4;

            return $"{(int)protein} gr Protein ,{(int)fat} gr Fat, {(int)carb} gr Carb";
        }

       
    }
}
