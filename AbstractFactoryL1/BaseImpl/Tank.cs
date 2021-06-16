namespace AbstractFactoryL1.BaseImpl
{
    /// <summary>
    /// Car fuel tank.
    /// </summary>
    public class Tank
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The maximum possible tank volume (liters).
        /// </summary>
        public double MaxVolume { get; }

        /// <summary>
        /// Current fuel volume (liters).
        /// </summary>
        public double Volume { get; private set; }

        /// <summary>
		/// Cost.
		/// </summary>
        public decimal Price { get; }

        /// <summary>
		/// Weight.
		/// </summary>
        public double Weight { get; private set; }

        /// <summary>
        /// Is there any fuel left in the tank?
        /// </summary>
        public bool Empty => Volume == 0;

        /// <summary>
        /// Acceleration coefficient depending on the fullness of the tank.
        /// The less fuel, the less weight, the higher the speed.
        /// </summary>
        public double SpeedFactor
        {
            get
            {
                var currentVolumePercent = Volume / MaxVolume;
                return -0.4 * currentVolumePercent + 1.2;
            }
        }

        /// <summary>
        /// Create a new fuel tank.
        /// </summary>
        /// <param name = "name"> Name. </param>
        /// <param name = "maxVolume"> Maximum volume (liters). </param>
        /// <param name = "price"> Cost. </param>
        /// <param name = "weight"> Weight. </param>
        public Tank(string name, double maxVolume, decimal price, double weight) // TODO check var
        {
            Name = name;
            MaxVolume = maxVolume;
            Volume = maxVolume;
            Price = price;
            Weight = weight;
        }


        /// <summary>
        /// Spend fuel.
        /// </summary>
        /// <param name = "fuel"> Requested amount of fuel. </param>
        /// <returns> Actual percentage of fuel consumption. </returns>
        public double Spend(double fuel)
        {
            // If there is more fuel in the tank than needed, just consume this volume
            // and return 1 (= 100%)
            if (fuel <= Volume)
            {
                Volume -= fuel;
                return 1;
            }
            else
            {
                // If there is less in the tank than needed, then we spend everything we have,
                // and return the percentage of what you want.
                var wayPercent = Volume / fuel;
                Volume = 0;
                return wayPercent;
            }
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
