﻿namespace AbstractFactoryL1.BaseImpl
{
    public class Body
    {
        public string Name { get; }

        public double Aerodynamic { get; }

        public decimal Price { get; }

        public double MaxWeight { get; }

        public double Weight { get; }

        public Body(string name, double aerodynamic, decimal price, double maxWeight, double weight)
        {
            // TODO: проверка входных аргументов.

            Name = name;
            Aerodynamic = aerodynamic;
            Price = price;
            MaxWeight = maxWeight;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}