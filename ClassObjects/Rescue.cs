namespace ObjectClasses
{
    public class Rescue(string code, string date, AAnimal family, int affectationGrade, string location)
    {
        public string? Code { get; set; } = code;
        public string? Date { get; set; } = date;
        public AAnimal? Family { get; set; } = family;
        public int AffectationGrade { get; set; } = affectationGrade;
        public string? Location { get; set; } = location;

        public Rescue(AAnimal family) : this ("", "", family, 0, "") {}

        /// <summary>
        /// Method that returns a code which is a string with the next format ("RES" + a random number between 0 and 999 with 3 digits).
        /// </summary>
        /// <returns> A String which contains "RES" + number of 3 digits  between 0 and 999. </returns>
        public static string GenerateCode()
        {
            Random random = new();
            string code = "RES" + random.Next(1000).ToString("000");

            return code;
        }

        /// <summary>
        /// Method to get the document of the rescue, with all the information about it.
        /// </summary>
        /// <returns>A String with all the information in a table format. </returns>
        public string GetDocument() => 
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           RESCUE                            |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Rescue | Rescue Date | Super Family      | AG | Location  |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Code}   | {Date}  | {Family}        | {AffectationGrade} | {Location} |\r\n" +
            $"+-------------------------------------------------------------+";
        

    }
}

