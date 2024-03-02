using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasses
{
    public class SeaBird : AAnimal
    {
        public SeaBird(string name, string superFamily, string species, float weight) :
            base(name, superFamily, species, weight)
        { }

        public override int Treatment(int afectation, int value)
        {
            return afectation - ( (afectation * afectation) + value);
        }
    }
}

