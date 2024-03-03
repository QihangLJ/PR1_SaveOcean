namespace ObjectClasses
{
    public abstract class AAnimal(string name, string superFamily, string species, float weight)
    {
        public string? Name { get; set; } = name;
        public string? SuperFamily { get; set; } = superFamily;
        public string? Species { get; set; } = species;
        public float Weight { get; set; } = weight;

        protected AAnimal() : this("", "", "", 0) {}

        public abstract int Treatment(int afectation, int value);

        public abstract string GetDocument();
    }
}
