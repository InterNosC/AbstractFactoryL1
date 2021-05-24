using AbstractFactoryL1.AbstractFactoryImpl;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryL1
{
    class WithPattern
    {
        private IAutoFactory factory;

        private void AutoMoved(object sender, double e)
        {
            var x = (int)e;
            Console.WriteLine($"Complete: {x}");
        }

        public void StartMove()
        {
            if (factory == null)
            {
                Console.WriteLine("Choose type: \n1.small \n2.big");
                string key = Console.ReadLine().ToString();
                switch (key)
                {
                    case "1":
                        factory = new CarFactory();
                        break;
                    case "2":
                        factory = new TruckFactory();
                        break;
                    default:
                        return;
                }
            }

            var speed = 50;
            var auto = new Auto(factory);
            auto.Moved += AutoMoved;
            auto.Start(speed);
        }
    }
}
