using AbstractFactoryL1.BaseImpl;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryL1
{
    class WithoutPattern
    {
		private Car CreateBaseImplementation()
		{
			var body = new Body("Priora", 1.0, 100000, 2000, 300);
			var engine = new Engine("v8", 200, 150000, 200);
			var tank = new Tank("Standard", 48, 30000, 40);

			var car = new Car(body, engine, tank);
			car.Moved += BaseCarMoved;

			return car;
		}


		private void BaseCarMoved(object sender, double e)
		{
			var x = (int)e;
			Console.WriteLine($"Complete: {x}");
		}

		public void StartMove()
		{
			var speed = 50;
			var baseCar = CreateBaseImplementation();
			baseCar.Start(speed);
		}
	}
}
