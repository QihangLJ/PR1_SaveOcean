using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasses
{
    public class SeaTurtle : AAnimal
    {
        public SeaTurtle(string name, string superFamily, string species, float weight) : 
            base(name, superFamily, species, weight) {}

        public override int Treatment(int afectation, int value)
        {
            return afectation - (( afectation - 2 ) * ( 2 * afectation + 3 )) - value;
        }

    }
}

