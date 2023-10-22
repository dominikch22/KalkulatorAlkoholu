using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorAlkoholu
{
    class AlcoholCalculator
    {
        public Dictionary<String, Drink> Drinks
        { get; private set; }
        public Dictionary<String, Glassware> Glassware
        { get; private set;}

        public AlcoholCalculator() {
            loadDrinksData();
            loadGlasswareData();
        }

        private void loadDrinksData()
        {
            Drinks = new Dictionary<string, Drink>();

            Drinks.Add("Light Beer", new Drink("Light Beer", 5));
            Drinks.Add("Dark Beer", new Drink("Dark Beer", 6));
            Drinks.Add("Strong Beer", new Drink("Strong Beer", 10));
            Drinks.Add("Red Wine", new Drink("Red Wine", 14));
            Drinks.Add("White Wine", new Drink("White Wine", 13));
            Drinks.Add("Rosé Wine", new Drink("Rosé Wine", 12));
            Drinks.Add("Sparkling Wine", new Drink("Sparkling Wine", 12));
            Drinks.Add("Vodka", new Drink("Vodka", 45));
            Drinks.Add("Bourbon Whiskey", new Drink("Bourbon Whiskey", 45));
            Drinks.Add("Scotch Whisky", new Drink("Scotch Whisky", 50));
            Drinks.Add("Irish Whiskey", new Drink("Irish Whiskey", 50));
            Drinks.Add("Rum", new Drink("Rum", 50));
            Drinks.Add("Tequila", new Drink("Tequila", 39));
            Drinks.Add("Gin", new Drink("Gin", 44));
            Drinks.Add("Fruit Liqueur", new Drink("Fruit Liqueur", 23));
            Drinks.Add("Coffee Liqueur", new Drink("Coffee Liqueur", 23));
            Drinks.Add("Cream Liqueur", new Drink("Cream Liqueur", 18));
            Drinks.Add("Cognac", new Drink("Cognac", 43));
            Drinks.Add("Brandy", new Drink("Brandy", 48));

        }

        private void loadGlasswareData()
        {
            Glassware = new Dictionary<string, Glassware>();

            Glassware.Add("Vodka Shot Glass", new Glassware("Vodka Shot Glass", 40));
            Glassware.Add("Beer Mug", new Glassware("Beer Mug", 750));
            Glassware.Add("Whiskey Glass", new Glassware("Whiskey Glass", 45));
            Glassware.Add("Cognac Glass", new Glassware("Cognac Glass", 125));
            Glassware.Add("Red Wine Glass", new Glassware("Red Wine Glass", 200));
            Glassware.Add("White Wine Glass", new Glassware("White Wine Glass", 175));
            Glassware.Add("Champagne Flute", new Glassware("Champagne Flute", 175));
            Glassware.Add("Cocktail Glass", new Glassware("Cocktail Glass", 300));
            Glassware.Add("Craft Beer Mug", new Glassware("Craft Beer Mug", 500));
            Glassware.Add("Liqueur Glass", new Glassware("Liqueur Glass", 45));

        }

    
        public double calculateDrinkkVolume(String glasswareType, String glasswareNumber)
        {
            double capacity = 0;
            int number = 0;
            try
            {
                number = Convert.ToInt32(glasswareNumber);
            }
            catch
            {
                throw new Exception("Incorrect number of glassware");
            }
            if (number < 0)
                throw new Exception("Incorrect number of glassware");



            if (Glassware.TryGetValue(glasswareType, out Glassware glassware))
            {
                capacity = glassware.CapacityInMl;
            }
            else
            {
                try
                {
                    capacity = Convert.ToDouble(glasswareType);
                }
                catch
                {
                    throw new Exception("Incorrect capacity");
                }
                if (capacity < 0)
                    throw new Exception("Incorrect capacity");
            }

            return capacity * number;
        }

        public double calculateAlcoholContent(String alcoholType, String glasswareType, String glasswareNumber)
        {
            double percentage = 0;


            if (Drinks.TryGetValue(alcoholType, out Drink drink))
            {
                percentage = drink.AlcoholPercentageContent;
            }
            else
            {
                try
                {
                    percentage = Convert.ToDouble(alcoholType);
                }
                catch
                {
                    throw new Exception("Incorrect percentage");
                }
                if (percentage < 0)
                    throw new Exception("Incorrect percentage");
                if (percentage > 100)
                    throw new Exception("Incorrect percentage");

            }

            return (percentage / 100) * calculateDrinkkVolume(glasswareType, glasswareNumber);
        }
    }
}
