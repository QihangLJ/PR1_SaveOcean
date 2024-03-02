namespace ObjectClasses
{
    public class Rescue
    {
        private string? code;
        private string? date;
        private AAnimal? specie;
        private int afectationGrade;
        private string? location;

        public string? Code { get; set; }
        public string? Date { get; set; }
        public AAnimal? Specie { get; set; }
        public int AfectationGrade { get; set; }
        public string? Location { get; set; }


        public Rescue(string code, string date, AAnimal specie, int afectationGrade, string location)
        {
            Code = code;
            Date = date;
            Specie = specie;
            AfectationGrade = afectationGrade;
            Location = location;
        }

    }
}

