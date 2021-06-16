using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Truck engine.
    /// </summary>
    public class TruckEngine : IEngine
    {
        /// <summary>
        /// The fastest possible speed.
        /// </summary>
        public double MaxSpeed => 110;

        /// <summary>
        /// Title.
        /// </summary>
        public string Name => "QEVV457LA";

        /// <summary>
        /// Cost.
        /// </summary>
        public decimal Price => 2000000;

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight => 1500;

        /// <summary>
        /// Calculation of fuel consumption depending on the speed.
        /// </summary>
        /// <param name = "speed"> Speed. </param>
        /// <returns> Fuel consumption for 1 hour. </returns>
        public double GetConsumption(double speed)
        {
            if (speed < 0)
            {
                throw new ArgumentException("Speed can not be less then 0.", nameof(speed));
            }

            if (speed == 0)
            {
                return 0;
            }

            var fuel = 0.005 * speed * speed - 0.8 * speed + 60;
            return fuel;
        }

    }
}
