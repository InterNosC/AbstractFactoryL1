namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class CarBody : IBody
    {
        public double Aerodynamic => 1.1;

        public double MaxWeight => 985;

        public string Name => "Q1111";

        public decimal Price => 30000;

        public double Weight => 350;
    }
}
