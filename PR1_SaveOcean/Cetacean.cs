using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectClasses
{
    public class Cetacean : AAnimal
    {
        public Cetacean(string name, string superFamily, string species, float weight) :
            base(name, superFamily, species, weight)
        { }

        public override int Treatment(int afectation, int value)
        {
            double doubleValue = Convert.ToDouble(afectation);
            return (int)(afectation - Math.Log10(doubleValue) - value);
        }

    }
}

