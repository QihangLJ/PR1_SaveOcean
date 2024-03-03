namespace ObjectClasses
{
    public abstract class AAnimal
    {
        public string? Name { get; set ; }
        public string? SuperFamily { get; set; }
        public string? Species { get; set; }
        public float Weight { get; set; }

        protected AAnimal(string name, string superFamily, string species, float weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }

        protected AAnimal() : this("", "", "", 0) {}

        public abstract int Treatment(int afectation, int value);

        public abstract string GetDocument();
    }
}
