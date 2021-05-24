namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public interface IBody : IComponent
    {
        double Aerodynamic { get; }
        double MaxWeight { get; }
    }
}
