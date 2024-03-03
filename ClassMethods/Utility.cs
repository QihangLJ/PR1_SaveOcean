namespace UtilityClasses
{
    public class Utility
    {
        public static bool CheckIntInput(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
        public static int ValidateInput(string errorMessage, int min, int max)
        {
            int input;
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (!CheckIntInput(input, min, max))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!CheckIntInput(input, min, max));

            return input;
        }

        public static string RegisterDate()
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            return date;
        }

        public static int RandomAffectationGrade()
        {
            Random random = new();
            return random.Next(1,100);
        }

    }
}
