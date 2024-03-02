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
            const string MsgInvalidValue = "Invalid value, please enter a valid value.";
            const int InputMin = 1, InputMax = 2;
            int userInput;

            Print.StartMessage();
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (!Utility.CheckIntInput(userInput, InputMin, InputMax))
                {
                    Console.WriteLine(MsgInvalidValue);
                }
            } while (!Utility.CheckIntInput(userInput, InputMin, InputMax));

        }
    }
}