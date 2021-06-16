namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Car engines.
    /// Defines general properties and methods specific to any engine,
    /// no matter what family it belongs to.
    /// </summary>
    public interface IEngine : IComponent
    {
        double MaxSpeed { get; }

        double GetConsumption(double speed);
    }
}
