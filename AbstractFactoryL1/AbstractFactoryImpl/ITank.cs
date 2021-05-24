namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public interface ITank : IComponent
    {
        double MaxVolume { get; }
        double Volume { get; }
        bool Empty { get; }
        double SpeedFactor { get; }


        double Spend(double fuel);
    }
}
