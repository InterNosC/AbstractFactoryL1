using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
	/// Car Endine.
	/// </summary>
    public class CarEngine : IEngine
    {
        /// <summary>
        /// The fastest possible speed.
        /// </summary>
        public double MaxSpeed => 80;

        /// <summary>
        /// Title.
        /// </summary>
        public string Name => "QE1111";

        /// <summary>
        /// Cost
        /// </summary>
        public decimal Price => 50000;

        /// <summary>
        /// Weight
        /// </summary>
        public double Weight => 250;

        /// <summary>
        /// Calculation of fuel consumption depending on the speed.
        /// </summary>
        /// <param name = "speed"> Speed. </param>
        /// <returns> Fuel consumption for 1 hour. </returns>
        public double GetConsumption(double speed)
        {
            if (speed < 0)
            {
                throw new ArgumentException("Speed can not be less then 0", nameof(speed));
            }

            if (speed == 0)
            {
                return 0;
            }

            var fuel = 0.0008 * speed * speed - 0.2 * speed + 15;
            return fuel;
        }
    }
}
