namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Factory for the production of trucks.
    /// Defines a family of trucks.
    /// Contains factory methods.
    /// </summary>
    public class TruckFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new TruckBody();
        }

        public IEngine CreateEngine()
        {
            return new TruckEngine();
        }

        public ITank CreateTank()
        {
            return new TruckTank();
        }
    }
}
