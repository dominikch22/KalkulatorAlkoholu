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
            Glassware = new Dictionary<string, Glassware>();

            Glassware.Add("Kieliszek do wódki", new Glassware("Kieliszek do wódki", 40));
            Glassware.Add("Kufel do piwa", new Glassware("Kufel do piwa", 750));
            Glassware.Add("Kieliszek do whisky", new Glassware("Kieliszek do whisky", 45));
            Glassware.Add("Kieliszek do koniaku", new Glassware("Kieliszek do koniaku", 125));
            Glassware.Add("Kieliszek do wina czerwonego", new Glassware("Kieliszek do wina czerwonego", 200));
            Glassware.Add("Kieliszek do wina białego", new Glassware("Kieliszek do wina białego", 175));
            Glassware.Add("Kieliszek do szampana", new Glassware("Kieliszek do szampana", 175));
            Glassware.Add("Szklanka do drinków", new Glassware("Szklanka do drinków", 300));
            Glassware.Add("Kubek do piwa rzemieślniczego", new Glassware("Kubek do piwa rzemieślniczego", 500));
            Glassware.Add("Kieliszek do likieru", new Glassware("Kieliszek do likieru", 45));

        }

        private double calculateAlcoholContent(String alcoholType, String glasswareType, int glasswareAmount) {
            double percentage = 0;
            double capacity = 0;


            if (Drinks.TryGetValue(alcoholType, out Drink drink))
            {
                percentage = drink.AlcoholPercentageContent;
            }
            else {
                try
                {
                    percentage = Convert.ToDouble(alcoholType);
                }
                catch
                {
                }

            }

            if (Glassware.TryGetValue("glasswareType", out Glassware glassware))
            {
                capacity = glassware.CapacityInMl;
            }
            else {
                try
                {
                    capacity = Convert.ToDouble(glasswareType);
                }
                catch
                {
                }
            }
           
            

            return (percentage/100)*capacity*2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
