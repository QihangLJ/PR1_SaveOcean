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

        public static string GenerateCode()
        {
            Random random = new();
            string code = "RES" + random.Next(1000).ToString("000");

            return code;
        }

        public override string ToString() => 
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           RESCUE                            |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Rescue | Rescue Date | Super Family      | AG | Location  |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Code}   | {Date}  | {Family}        | {AffectationGrade} | {Location} |\r\n" +
            $"+-------------------------------------------------------------+";
        

    }
}

