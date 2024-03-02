namespace UtilityClasses
{
    public class Utility
    {
        public static bool CheckIntInput(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        public static string RegisterDate()
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            return date;
        }
    }
}
