namespace ObjectClasses
{
    public class Rescue
    {
        private string? code;
        private string? date;
        private AAnimal? family;
        private int affectationGrade;
        private string? location;

        public string? Code { get; set; }
        public string? Date { get; set; }
        public AAnimal? Family { get; set; }
        public int AffectationGrade { get; set; }
        public string? Location { get; set; }


        public Rescue(string code, string date, AAnimal family, int affectationGrade, string location)
        {
            Code = code;
            Date = date;
            Family = family;
            AffectationGrade = affectationGrade;
            Location = location;
        }

        public Rescue(AAnimal family) : this ("", "", family, 0, "") {}

        public static string GenerateCode()
        {
            Random random = new Random();
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

