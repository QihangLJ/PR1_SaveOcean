

namespace ObjectClasses
{
    public abstract class AAnimal
    {
        protected string? Name { get; set ; }
        protected string? SuperFamily { get; set; }
        protected string? Species { get; set; }
        protected float Weight { get; set; }


        protected AAnimal(string name, string superFamily, string species, float weight)
        {
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }

        public abstract void Treatment();
    }
}
