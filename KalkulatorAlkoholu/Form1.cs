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
            loadDrinksData();
            loadGlasswareData();
        }

        private void loadDrinksData() {
            Drinks = new Dictionary<string, Drink>();

            Drinks.Add("Piwo jasne", new Drink("Piwo jasne", 5));
            Drinks.Add("Piwo ciemne", new Drink("Piwo ciemne", 6));
            Drinks.Add("Piwo mocne", new Drink("Piwo mocne", 10));
            Drinks.Add("Wino czerwone", new Drink("Wino czerwone", 14));
            Drinks.Add("Wino białe", new Drink("Wino białe", 13));
            Drinks.Add("Wino różowe", new Drink("Wino różowe", 12));
            Drinks.Add("Wino musujące", new Drink("Wino musujące", 12));
            Drinks.Add("Wódka", new Drink("Wódka", 45));
            Drinks.Add("Whisky (bourbon)", new Drink("Whisky (bourbon)", 45));
            Drinks.Add("Whisky (scotch)", new Drink("Whisky (scotch)", 50));
            Drinks.Add("Irish whiskey", new Drink("Irish whiskey", 50));
            Drinks.Add("Rum", new Drink("Rum", 50));
            Drinks.Add("Tequila", new Drink("Tequila", 39));
            Drinks.Add("Gin", new Drink("Gin", 44));
            Drinks.Add("Likier owocowy", new Drink("Likier owocowy", 23));
            Drinks.Add("Likier kawowy", new Drink("Likier kawowy", 23));
            Drinks.Add("Likier kremowy", new Drink("Likier kremowy", 18));
            Drinks.Add("Koniak (Cognac)", new Drink("Koniak (Cognac)", 43));
            Drinks.Add("Brandy", new Drink("Brandy", 48));

        }

        private void loadGlasswareData() { 
            //nwm
        }
    }
}
