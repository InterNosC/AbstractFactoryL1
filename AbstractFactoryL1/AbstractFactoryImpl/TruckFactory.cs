namespace AbstractFactoryL1.AbstractFactoryImpl
{
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
