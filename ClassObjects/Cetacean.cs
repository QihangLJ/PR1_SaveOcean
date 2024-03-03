using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasses
{
    public class Cetacean : AAnimal
    {
        public Cetacean(string name, string superFamily, string species, float weight) :
            base(name, superFamily, species, weight)
        { }

        public Cetacean() : base() { }

        public override int Treatment(int affectation, int healOption)
        {
            int value = healOption == 1 ? 25 : 0;
            double doubleValue = Convert.ToDouble(affectation);
            return (int)(affectation - Math.Log10(doubleValue) - value);
        }

        public override string ToString() => SuperFamily ?? "Null";

        public override string GetDocument() =>
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           DOCUMENT                          |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Name | Super Family      | Species         | Weigth       |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Name}  | {SuperFamily}        | {Species}  | {Weight}kg       |\r\n" +
            $"+-------------------------------------------------------------+";
    }
}

