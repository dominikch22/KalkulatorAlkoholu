using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorAlkoholu
{
    class Drink
    {
        public Drink(String name, double alcoholConcentration) {
            this.name = name;
            this.alcoholConcentration = alcoholConcentration;
        }
        public String name
        { get; private set; }

        public double alcoholConcentration
        { get; private set; }
    }
}
