namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Abstract factory for the production of cars.
    /// </summary>
    public interface IAutoFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        ITank CreateTank();
    }
}
