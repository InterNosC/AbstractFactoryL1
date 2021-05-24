namespace AbstractFactoryL1.BaseImpl
{
    public class Engine
    {
        public string Name { get; }

        public double MaxSpeed { get; }

        public decimal Price { get; }

        public double Weight { get; }

        public Engine(string name, double maxSpeed, decimal price, double weight) // TODO check var
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
            Weight = weight;
        }

        public double GetConsumption(double speed) 
        {
            var actulaSpeed = speed > 0 ? speed : 1;

            var fuel = 0.0008 * actulaSpeed * actulaSpeed - 0.2 * actulaSpeed + 17; // Random formul near to real)
            return fuel;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
