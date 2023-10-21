﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorAlkoholu
{
    class Drink
    {
        public Drink(String name, double alcoholPercentageContent) {
            this.Name = name;
            this.AlcoholPercentageContent = alcoholPercentageContent;
        }
        public String Name
        { get; private set; }

        public double AlcoholPercentageContent
        { get; private set; }
    }
}
