using System;
using UtilityClasses;
using ObjectClasses;
using MessageClasses;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string MsgInvalidValue = "Invalid value, please enter a valid value.";
            const string MsgExit = "Leaving the program...";
            const string AnimalName = "Dally", MyLocation = "Barcelona";

            const int Play = 1, Offset = 1, InputMin = 1, InputMax = 2;
            const int SeaTurtleNum = 1, SeaBirdNum = 2, CetaceanNum = 3;
            const int TechnicalExp = 45, VetExp = 80;

            string userName;
            int userInput, userExperience;
            Random random = new Random();

            Print.StartMessage();
            Console.ForegroundColor = ConsoleColor.Green;
            userInput = Utility.ValidateInput(MsgInvalidValue, InputMin, InputMax);
            Console.ResetColor();
            Console.WriteLine();

            if (userInput == Play)
            {
                AAnimal animal;
                switch (random.Next(SeaTurtleNum, CetaceanNum + Offset))
                {
                    case SeaTurtleNum:
                        animal = new SeaTurtle(AnimalName, "Sea Turtle", "Caretta Turtle", 9.5f);
                        break;
                    case SeaBirdNum:
                        animal = new SeaBird(AnimalName, "Sea Bird  ", "Emperor Penguin", 15.2f);
                        break;
                    default:
                        animal = new Cetacean(AnimalName, "Cetacean  ", "Listed Dolphin", 20.7f);
                        break;
                }

                Print.ChooseRole(TechnicalExp, VetExp);
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Utility.ValidateInput(MsgInvalidValue, InputMin, InputMax);
                Console.ResetColor();
                userExperience = userInput == 1 ? TechnicalExp : VetExp;
                Console.WriteLine();

                Print.ChooseName();
                Console.ForegroundColor = ConsoleColor.Green;
                userName = Console.ReadLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Print.RescueMessage(userName);
                Console.WriteLine();

                Rescue rescue = new Rescue(animal);
                rescue.Code = Rescue.GenerateCode();
                rescue.Date = Utility.RegisterDate();
                rescue.AffectationGrade = Utility.RandomAffectationGrade();
                rescue.Location = MyLocation;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(rescue.ToString());
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Print.InformationMessage();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(animal.GetDocument());
                Console.ResetColor();
                Console.WriteLine();

                Print.ChooseTreatment(animal.Name, rescue.AffectationGrade);
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Utility.ValidateInput(MsgInvalidValue, InputMin, InputMax);
                rescue.AffectationGrade = animal.Treatment(rescue.AffectationGrade, userInput);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Print.TreatmentResultMessage(rescue.AffectationGrade);
                userExperience = rescue.AffectationGrade > 5 ? userExperience - 20 : userExperience + 50;
                Console.WriteLine();

                Print.ExperienceResultMessage(userExperience);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Print.EndMessage();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(MsgExit);
                Console.ResetColor();
            }
        }
    }
}