namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class TruckTank : ITank
    {
        public double MaxVolume => 800;

        public double Volume { get; private set; }

        public bool Empty => Volume == 0;

        public double SpeedFactor
        {
            get
            {
                var currentVolumePercent = Volume / MaxVolume;
                return -0.15 * currentVolumePercent + 1.1;
            }
        }

        public string Name => "QTVV5490";

        public decimal Price => 300000;

        public double Weight => 200 + Volume;

        public TruckTank()
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
