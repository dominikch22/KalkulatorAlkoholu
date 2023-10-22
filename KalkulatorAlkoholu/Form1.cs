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
        private Dictionary<String, Drink> Drinks;
        private Dictionary<String, Glassware> Glassware;
        public Form1()
        {
            InitializeComponent();        
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

        }

        private void label1_Click(object sender, EventArgs e) {}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
