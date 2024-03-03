namespace ObjectClasses
{
    public abstract class AAnimal(string name, string superFamily, string species, float weight)
    {
        public string? Name { get; set; } = name;
        public string? SuperFamily { get; set; } = superFamily;
        public string? Species { get; set; } = species;
        public float Weight { get; set; } = weight;

        protected AAnimal() : this("", "", "", 0) {}

        /// <summary>
        /// Method that calculates the affectation grade after the application of a treatment.
        /// </summary>
        /// <param name="affectation">The level of affectation that have the animal at the beginning.</param>
        /// <param name="healOption">The option that the user has chosen. (1) Heal (2) Move to a medical center</param>
        /// <returns>The final value of the affectation grade in a integer value</returns>
        public abstract int Treatment(int affectation, int healOption);

        /// <summary>
        /// Method to get the document of the animal, with all the information about it.
        /// </summary>
        /// <returns>A String with all the information in a table format</returns>
        public abstract string GetDocument();

    }
}
