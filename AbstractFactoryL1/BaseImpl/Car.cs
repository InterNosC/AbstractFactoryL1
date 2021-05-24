using System;

namespace AbstractFactoryL1.BaseImpl
{
    public class Car
    {
        public Body Body { get; }

        public Engine Engine { get; }

        public Tank Tank { get; }

        public string Vin { get; }

        public decimal Price { get; }

        public double Weight
        {
            get
            {
                return Body.Weight + Engine.Weight + Tank.Weight;
            }
        }

        public event EventHandler<double> Moved;


        public Car(Body body, Engine engine, Tank tank)
        {

            Body = body;
            Engine = engine;
            Tank = tank;
            Price = (Body.Price + Engine.Price + Tank.Price) * 1.5M;

            Vin = Guid.NewGuid().ToString();
        }

        public double Start(double speed)
        {
            if (Weight > Body.MaxWeight)
            {
                throw new Exception("Weight is too hight.");
            }

            var path = 0.0;
            while (!Tank.Empty)
            {
                path += Step(speed); Moved?.Invoke(this, path);
            }

            return path;
        }

        private double Step(double speed)
        {
            var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
            actualSpeed *= Body.Aerodynamic;
            actualSpeed *= Tank.SpeedFactor;

            var needFuel = Engine.GetConsumption(actualSpeed);

            var pathRate = Tank.Spend(needFuel);
            var path = actualSpeed * pathRate;
            return path;
        }

        public override string ToString()
        {
            return Vin;
        }
    }
}
