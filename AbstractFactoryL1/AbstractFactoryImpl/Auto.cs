using System;

namespace AbstractFactoryL1.AbstractFactoryImpl
{
    /// <summary>
    /// Vehicle.
    /// The main components that make up any car and
    /// implemented their interaction.
    /// In this case, not specific implementations are used, but basic interfaces,
    /// which allows you to dynamically configure the constituent components of the car.
    /// The configuration is done by passing it to the factory constructor.
    /// It is important to understand that this class is in fact already a client of the abstract factory.
    /// An abstract factory does not have to return a single object. It returns individual components,
    /// which can both be assembled into a single whole (as here),
    /// it is easy to interact with each other.
    /// But the abstract factory guarantees that these components will be
    /// correctly compatible and interact correctly with each other.
    /// </summary>
    public class Auto
    {
        /// <summary>
        /// Car body.
        /// </summary>
        public IBody Body { get; }

        /// <summary>
        /// Car engine.
        /// </summary>
        public IEngine Engine { get; }

        /// <summary>
        /// Car fuel tank.
        /// </summary>
        public ITank Tank { get; }

        /// <summary>
        /// Unique number.
        /// </summary>
        public string Vin { get; }

        /// <summary>
        /// Cost.
        /// </summary>
        public decimal Price
        {
            get
            {
                if (Body != null && Engine != null && Tank != null)
                {
                    var markup = 1.5M; // Extra charge
                    return (Body.Price + Engine.Price + Tank.Price) * markup;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Weight.
        /// </summary>
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

        /// <summary>
		/// Автомобиль переместился.
		/// Возвращает пройденный путь.
		/// </summary>
        public event EventHandler<double> Moved;

        /// <summary>
        /// Create a new car.
        /// </summary>
        /// <param name = "factory"> A factory that determines what kind of car this will be. </param>

        public Auto(IAutoFactory factory)
        {
            Body = factory.CreateBody();
            Engine = factory.CreateEngine();
            Tank = factory.CreateTank();

            Vin = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Start moving the car.
        /// </summary>
        /// <param name = "speed"> Speed. </param>
        /// <returns> Traveled path. </returns>
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

        /// <summary>
        /// Moving the car for an hour.
        /// </summary>
        /// <param name = "speed"> Speed. </param>
        /// <returns> Distance traveled per hour. </returns>
        public double Step(double speed)
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
