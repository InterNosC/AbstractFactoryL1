using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class CarEngine : IEngine
    {
        public double MaxSpeed => 80;

        public string Name => "QE1111";

        public decimal Price => 50000;

        public double Weight => 250;

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
