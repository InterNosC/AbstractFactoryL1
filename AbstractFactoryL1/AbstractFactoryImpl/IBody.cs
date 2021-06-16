namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Car bodies.
    /// Defines general properties and methods specific to any corpus,
    /// no matter what family it belongs to.
    /// </summary>
    public interface IBody : IComponent
    {
        double Aerodynamic { get; }
        double MaxWeight { get; }
    }
}
