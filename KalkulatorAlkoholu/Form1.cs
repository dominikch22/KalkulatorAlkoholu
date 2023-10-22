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

namespace KalkulatorAlkoholu
{
    public partial class Form1 : Form
    {
        private AlcoholCalculator AlcoholCalculator;
        public Form1()
        {
            InitializeComponent();
            
            AlcoholCalculator = new AlcoholCalculator();

            foreach (KeyValuePair<string, Drink> entry in AlcoholCalculator.Drinks)
            {
                alkoholComboBox.Items.Add(entry.Key);
            }

            foreach (KeyValuePair<string, Glassware> entry in AlcoholCalculator.Glassware)
            {
                capacityComboBox.Items.Add(entry.Key);
            }
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alkoholComboBox_SelectedIndexChanged(object sender, EventArgs e) //alkoholComboBox (wybor alkoholu)
        {

        }

        private void capacityComboBox_SelectedIndexChanged(object sender, EventArgs e) //capacityComboBox (wybor objetosci)
        {

        }


        private void capacityTextBox_TextChanged(object sender, EventArgs e) //capacityTextBox (pokazuje mililitry)
        {

        }

        private void alkoholScoreTextBox_TextChanged(object sender, EventArgs e) //alkoholScoreTextBox (koncowa ilosc spirytusu)
        {

        }

        private void capacityScoreTextBox_TextChanged(object sender, EventArgs e) //capacityScoreTextBox (koncowa objetosc alkoholu)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e) //calculateButton (oblicz)
        {
            try
            {
                alkoholScoreTextBox.Text = AlcoholCalculator.calculateAlcoholContent(alkoholComboBox.Text, capacityComboBox.Text, glasswareTextBox.Text).ToString();
                capacityScoreTextBox.Text = AlcoholCalculator.calculateDrinkkVolume(capacityComboBox.Text, glasswareTextBox.Text).ToString();
                errorInfo.Text = "";
            }
            catch (Exception ex)
            {
                errorInfo.Text = ex.Message;
            }
        }

        private void glasswareTextBox_TextChanged(object sender, EventArgs e) //glasswareTextBox ilosc szklanek
        {

        }

        private void label1_Click(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
