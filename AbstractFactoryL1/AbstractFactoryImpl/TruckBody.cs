﻿namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class TruckBody : IBody
    {
        public double Aerodynamic => 0.7;

        public double MaxWeight => 7900;

        public string Name => "QB5490";

        public decimal Price => 1500000;

        public double Weight => 1000;
    }
}
