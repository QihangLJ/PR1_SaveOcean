using System;
using UtilityClasses;
using ObjectClasses;
using InterfaceClasses;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            string uwu = Rescue.GenerateCode();
            Console.WriteLine(uwu);
            Console.WriteLine(Utility.RegisterDate());
        }
    }
}