namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class CarTank : ITank
    {
        public double MaxVolume => 30;

        public double Volume { get; private set; }

        public bool Empty => Volume == 0;

        public double SpeedFactor
        {
            get
            {
                var currentVolumePercent = Volume / MaxVolume;
                return -0.4 * currentVolumePercent + 1.2;
            }
        }

        public string Name => "QT1111";

        public decimal Price => 20000;

        public double Weight => 45 + Volume;

        public CarTank()
        {
            Volume = MaxVolume;
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
    }
}
