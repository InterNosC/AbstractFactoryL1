namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// The body of a passenger car.
    /// </summary>
    public class CarBody : IBody
    {
        /// <summary>
        /// Aerodynamic coefficient affecting speed.
        /// </summary>
        public double Aerodynamic => 1.1;

        /// <summary>
        /// Maximum possible weight.
        /// </summary>
        public double MaxWeight => 985;

        /// <summary>
		/// Title. 
		/// </summary>
        public string Name => "Q1111";

        /// <summary>
		/// Cost. 
		/// </summary>
        public decimal Price => 30000;

        /// <summary>
		/// Weight. 
		/// </summary>
        public double Weight => 350;
    }
}
