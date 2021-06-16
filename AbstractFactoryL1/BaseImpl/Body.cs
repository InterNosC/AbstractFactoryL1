namespace AbstractFactoryL1.BaseImpl
{
    /// <summary>
    /// Car body.
    /// </summary>
    public class Body
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Aerodynamic coefficient.
        /// </summary>
        public double Aerodynamic { get; }

        /// <summary>
        /// Cost.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The maximum total weight that the enclosure can support.
        /// </summary>
        public double MaxWeight { get; }

        /// <summary>
        /// The weight of the body itself.
        /// </summary>
        public double Weight { get; }

        /// <summary>
        /// Create a new car body.
        /// </summary>
        /// <param name = "name"> Name. </param>
        /// <param name = "aerodynamic"> Aerodynamic coefficient. </param>
        /// <param name = "price"> Cost. </param>
        /// <param name = "maxWeight"> Maximum weight. </param>
        /// <param name = "weight"> Weight. </param>
        public Body(string name, double aerodynamic, decimal price, double maxWeight, double weight)
        {
            Name = name;
            Aerodynamic = aerodynamic;
            Price = price;
            MaxWeight = maxWeight;
            Weight = weight;
        }

        /// <summary>
        /// Casting an object to a string.
        /// </summary>
        /// <returns> Title. </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
