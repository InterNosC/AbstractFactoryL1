namespace AbstractFactoryL1.BaseImpl
{
    public class Tank
    {
        public string Name { get; }

        public double MaxVolume { get; }

        public double Volume { get; private set; }

        public decimal Price { get; }

        public double Weight { get; private set; }

        public bool Empty => Volume == 0;

        public double SpeedFactor
        {
            get
            {
                var currentVolumePercent = Volume / MaxVolume;
                return -0.4 * currentVolumePercent + 1.2;
            }
        }


        public Tank(string name, double maxVolume, decimal price, double weight) // TODO check var
        {
            Name = name;
            MaxVolume = maxVolume;
            Volume = maxVolume;
            Price = price;
            Weight = weight;
        }

        public double Spend(double fuel)
        {
            if (fuel <= Volume)
            {
                Volume -= fuel;
                return 1;
            }
            else
            {
                var wayPercent = Volume / fuel;
                Volume = 0;
                return wayPercent;
            }
        }



        public override string ToString()
        {
            return Name;
        }
    }
}
