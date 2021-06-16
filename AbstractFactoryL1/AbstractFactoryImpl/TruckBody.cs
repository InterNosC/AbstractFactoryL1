namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Truck body.
    /// </summary>
    public class TruckBody : IBody
    {
        /// <summary>
        /// Aerodynamic coefficient affecting speed.
        /// </summary>
        public double Aerodynamic => 0.7;
        /// <summary>
        /// Maximum possible weight.
        /// </summary>
        public double MaxWeight => 7900;
        /// <summary>
        /// Title. 
        /// </summary>
        public string Name => "QB5490";
        /// <summary>
        /// Cost. 
        /// </summary>
        public decimal Price => 1500000;
        /// <summary>
        /// Weight. 
        /// </summary>
        public double Weight => 1000;
    }
}
