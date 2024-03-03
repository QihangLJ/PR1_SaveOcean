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

        public SeaBird() : base() { }

        public override int Treatment(int affectation, int healOption)
        {
            int value = healOption == 1 ? 5 : 0;
            return affectation - ( (affectation * affectation) + value);
        }

        public override string ToString() => SuperFamily ?? "Null";

        public override string GetDocument() =>
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           DOCUMENT                          |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Name | Super Family      | Species         | Weigth       |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Name}  | {SuperFamily}        | {Species} | {Weight}kg       |\r\n" +
            $"+-------------------------------------------------------------+";

    }
}

