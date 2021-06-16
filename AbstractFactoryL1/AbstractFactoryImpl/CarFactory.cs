namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Factory for a passenger car.
    /// Defines a family of components for a passenger car.
    /// Contains factory methods.
    /// </summary>
    public class CarFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new CarBody();
        }

        public IEngine CreateEngine()
        {
            return new CarEngine();
        }

        public ITank CreateTank()
        {
            return new CarTank();
        }
    }
}
