namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public interface IAutoFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        ITank CreateTank();
    }
}
