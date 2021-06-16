namespace AbstractFactoryL1.BaseImpl
{
    /// <summary>
    /// Car engine.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Maximum possible speed.
        /// </summary>
        public double MaxSpeed { get; }

        /// <summary>
        /// Cost.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
		/// Weight.
		/// </summary>
        public double Weight { get; }

        /// <summary>
        /// Create engine.
        /// </summary>
        /// <param name = "name"> Name. </param>
        /// <param name = "maxSpeed"> Maximum speed. </param>
        /// <param name = "price"> Cost. </param>
        /// <param name = "weight"> Weight. </param>
        public Engine(string name, double maxSpeed, decimal price, double weight) // TODO check var
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
            Weight = weight;
        }

        /// <summary>
        /// We calculate the fuel consumption per 100 km, depending on the speed.
        /// </summary>
        /// <param name = "speed"> Speed (km / h). </param>
        /// <returns> Fuel consumption (liters per 100 km). </returns>
        public double GetConsumption(double speed) 
        {
            var actulaSpeed = speed > 0 ? speed : 1;

            // The formula was selected according to certain values,
            // to be roughly true.
            var fuel = 0.0008 * actulaSpeed * actulaSpeed - 0.2 * actulaSpeed + 17;
            return fuel;
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
