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

        public SeaTurtle() : base() {}

        public override int Treatment(int affectation, int healOption)
        {
            int value = 5;
            return affectation - (( affectation - 2 ) * ( 2 * affectation + 3 )) - value;
        }

        public override string ToString() => SuperFamily ?? "Null";

        public override string GetDocument() =>
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           DOCUMENT                          |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Name | Super Family       | Species        | Weigth       |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Name}  | {SuperFamily}         | {Species} | {Weight}kg        |\r\n" +
            $"+-------------------------------------------------------------+";
    }
}

