namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public interface IEngine : IComponent
    {
        double MaxSpeed { get; }

        double GetConsumption(double speed);
    }
}
