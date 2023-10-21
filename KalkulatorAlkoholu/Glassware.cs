using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorAlkoholu
{
    class Glassware
    {
        public Glassware(String name, double capacityInMl) {
            this.Name = name;
            this.CapacityInMl = capacityInMl;
        }
        public String Name
        { get; private set; }

        public double CapacityInMl
        { get; private set; }
    }
}
