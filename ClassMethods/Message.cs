using System.Diagnostics;

namespace MessageClasses
{
    public class Print
    {

        /// <summary>
        /// Procedure that prints a start message of the program.
        /// </summary>
        public static void StartMessage()
        {
            const string Message = "Save the ocean! \nWhat you want to do?";
            const string MsgOptions = "1. Play! \n2. Exit";

            Console.WriteLine(Message);
            Console.WriteLine(MsgOptions);
        }

        /// <summary>
        /// Procedure that prints a message to ask the user to choose a role.
        /// </summary>
        /// <param name="technical_xp">A integer value of the Technical Experience.</param>
        /// <param name="vet_exp">A integer value of the Vet Experience.</param>
        public static void ChooseRole(int technical_xp, int vet_exp)
        {
            const string Message = "Perfect! What do you want to be?";
            const string MsgOptions = "1. Technical ({0} XP) \n2. Vet ({1} XP)";

            Console.WriteLine(Message);
            Console.WriteLine(MsgOptions, technical_xp, vet_exp);
        }

        /// <summary>
        /// Procedure that prints a message to ask the user to write a name.
        /// </summary>
        public static void ChooseName()
        {
            const string Message = "Nice! And what's your name?";
            Console.WriteLine(Message);
        }

        /// <summary>
        /// Procedure that prints a message of the program.
        /// </summary>
        /// <param name="name">A user name.</param>
        public static void RescueMessage(string? name)
        {
            const string Message = "Hello {0}! The 112 has recieved a call of warning to rescue an animal. The information that they  give us is the next:";
            Console.WriteLine(Message, name);
        }

        /// <summary>
        /// Procedure that prints a message of the program.
        /// </summary>
        public static void InformationMessage()
        {
            const string Message = "Here you have the document, for more information:";
            Console.WriteLine(Message);
        }

        /// <summary>
        /// Procedure that prints a message to ask the user to choose a action for a treatment.
        /// </summary>
        /// <param name="animalName"> The name of the animal.</param>
        /// <param name="affectationGrade">The grade of affectation that have the animal.</param>
        public static void ChooseTreatment(string? animalName, int affectationGrade) 
        { 
            const string Message = "The {0} have {1}% of Affectation Grade (AG).";
            const string MsgOptions = "You want to heal it here (1) or move it to a medical centir (2)";
            
            Console.WriteLine(Message, animalName, affectationGrade);
            Console.WriteLine(MsgOptions);
        }

        /// <summary>
        /// Procedure that prints a message about the result of the treatment.
        /// </summary>
        /// <param name="value"> The value of the affecation grade after the treatment.</param>
        public static void TreatmentResultMessage(int value)
        {
            const string MsgReduce = "The applied treatment has reduce the (AG) to {0}%. ";
            const string MsgNotEffective = "It wasn't effective so we need to move the animal to a medical center. Your experience reduce -20XP.";
            const string MsgEffective = "The animal has recovered and it can returns to his habitat. Your experience increase +50XP.";

            Console.Write(MsgReduce, value);
            Console.WriteLine(value > 5 ? MsgNotEffective : MsgEffective);
        }

        /// <summary>
        /// Procedure that prints a message with the final experience of the user.
        /// </summary>
        /// <param name="value"> The value of final experience of the user.</param>
        public static void ExperienceResultMessage(int value)
        {
            const string Message = "Your total experience {0}XP!";
            Console.WriteLine(Message, value);
        }

        /// <summary>
        /// Procedure that prints a message that ends the program.
        /// </summary>
        public static void EndMessage()
        {
            const string Message = "See you at the next rescue!";
            Console.WriteLine(Message);
        }
    }
}
