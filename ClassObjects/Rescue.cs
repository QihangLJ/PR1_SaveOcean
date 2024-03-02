namespace ObjectClasses
{
    public class Rescue
    {
        private string? code;
        private string? date;
        private int affectationGrade;
        private string? location;

        public string? Code { get; set; }
        public string? Date { get; set; }
        public AAnimal? Specie { get; set; }
        public int AffectationGrade { get; set; }
        public string? Location { get; set; }


        public Rescue(string code, string date, AAnimal specie, int affectationGrade, string location)
        {
            Code = code;
            Date = date;
            Specie = specie;
            AffectationGrade = affectationGrade;
            Location = location;
        }

        public static string GenerateCode()
        {
            Random random = new Random();
            string code = "RES" + random.Next(1000).ToString("000");

            return code;
        }

    }
}

