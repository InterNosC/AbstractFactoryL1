namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Fuel tank of a passenger car.
    /// </summary>
    public class CarTank : ITank
    {
        /// <summary>
        /// Maximum tank volume.
        /// </summary>
        public double MaxVolume => 30;

        /// <summary>
        /// Current tank volume.
        /// </summary>
        public double Volume { get; private set; }

        /// <summary>
        /// A flag indicating whether the tank is empty.
        /// </summary>
        public bool Empty => Volume == 0;

        /// <summary>
        /// Tank void multiplier that affects speed.
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
        /// Title.
        /// </summary>
        public string Name => "QT1111";

        /// <summary>
        /// Tank cost.
        /// </summary>
        public decimal Price => 20000;

        /// <summary>
        /// The weight of the tank including the fuel in it.
        /// </summary>
        public double Weight => 45 + Volume;

        /// <summary>
        /// Create a tank for a passenger car.
        /// </summary>
        public CarTank()
        {
            Volume = MaxVolume;
        }

        /// <summary>
        /// Use up some of the fuel from the tank for driving.
        /// </summary>
        /// <param name = "fuel"> Required amount of fuel. </param>
        /// <returns>
        /// A multiplier indicating how much fuel was actually used.
        /// Value on the segment [0; 1], where 0 - there is no fuel, 1 - there is all the necessary fuel.
        /// The value affects the actual path traveled.
        /// If there was a request for 10 liters of fuel, and there was only 3 in the tank,
        /// then a value of 0.3 will be returned, indicating that a third of the empty has been passed.
        /// </returns>
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
