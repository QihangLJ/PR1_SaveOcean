namespace UtilityClasses
{
    public class Utility
    {
        public static bool CheckIntInput(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
