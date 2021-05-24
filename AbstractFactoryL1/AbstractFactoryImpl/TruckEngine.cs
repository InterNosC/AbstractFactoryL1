using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class TruckEngine : IEngine
    {
        public double MaxSpeed => 110;

        public string Name => "QEVV457LA";

        public decimal Price => 2000000;

        public double Weight => 1500;

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
