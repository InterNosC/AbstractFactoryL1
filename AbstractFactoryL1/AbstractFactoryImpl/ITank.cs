namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Fuel tanks of the car.
    /// Defines general properties and methods specific to any tank,
    /// no matter what family it belongs to.
    /// </summary>
    public interface ITank : IComponent
    {
        double MaxVolume { get; }
        double Volume { get; }
        bool Empty { get; }
        double SpeedFactor { get; }


        double Spend(double fuel);
    }
}
