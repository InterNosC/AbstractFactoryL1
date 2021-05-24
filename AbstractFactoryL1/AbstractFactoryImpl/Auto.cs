using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    public class Auto
    {
        public IBody Body { get; }

        public IEngine Engine { get; }

        public ITank Tank { get; }

        public string Vin { get; }

        public decimal Price
        {
            get
            {
                if (Body != null && Engine != null && Tank != null)
                {
                    var markup = 1.5M;
                    return (Body.Price + Engine.Price + Tank.Price) * markup;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double Weight
        {
            get
            {
                if (Body != null && Engine != null && Tank != null)
                {
                    var weight = Body.Weight + Engine.Weight + Tank.Weight;
                    if (weight <= Body.MaxWeight)
                    {
                        return weight;
                    }
                    else
                    {
                        throw new Exception("Weight is too hight.");
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public event EventHandler<double> Moved;

        public Auto(IAutoFactory factory)
        {
            Body = factory.CreateBody();
            Engine = factory.CreateEngine();
            Tank = factory.CreateTank();

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
                path += Step(speed);
                Moved?.Invoke(this, path);
            }

            return path;
        }

        protected double Step(double speed)
        {
            var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
            actualSpeed *= Body.Aerodynamic;
            actualSpeed *= Tank.SpeedFactor;
            var needFuel = Engine.GetConsumption(actualSpeed);
            var pathRate = Tank.Spend(needFuel);
            var path = actualSpeed * pathRate;
            return path;
        }
    }
}
