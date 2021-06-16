using System;

namespace AbstractFactoryL1.BaseImpl
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Body.
        /// </summary>
        public Body Body { get; }

        /// <summary>
		/// Engine.
		/// </summary>
        public Engine Engine { get; }

        /// <summary>
		/// Tank.
		/// </summary>
        public Tank Tank { get; }

        /// <summary>
        /// Unique engine number.
        /// </summary>
        public string Vin { get; }

        /// <summary>
        /// The cost of the entire car.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The weight of the entire car.
        /// </summary>
        public double Weight
        {
            get
            {
                return Body.Weight + Engine.Weight + Tank.Weight;
            }
        }

        /// <summary>
        /// Event of car movement in 1 hour.
        /// Returns the distance traveled.
        /// </summary>
        public event EventHandler<double> Moved;

        /// <summary>
        /// Create a new car.
        /// </summary>
        /// <param name = "body"> Body. </param>
        /// <param name = "engine"> Engine. </param>
        /// <param name = "tank"> Tank. </param>
        public Car(Body body, Engine engine, Tank tank)
        {

            Body = body;
            Engine = engine;
            Tank = tank;
            Price = (Body.Price + Engine.Price + Tank.Price) * 1.5M;

            Vin = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Start moving the car.
        /// </summary>
        /// <param name = "speed"> Speed of movement. </param>
        /// <returns> Distance traveled. </returns>
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

        /// <summary>
        /// Move the car one step.
        /// The step is set by speed. If the speed is in km / h, then the step is 1 hour.
        /// </summary>
        /// <param name = "speed"> The speed of the movement. </param>
        /// <returns> Distance traveled per step. </returns>
        public double Step(double speed)
        {
            // Determine the actual speed.
            var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
            actualSpeed *= Body.Aerodynamic;
            actualSpeed *= Tank.SpeedFactor;

            // Calculate the amount of fuel consumed.
            var needFuel = Engine.GetConsumption(actualSpeed);

            // Calculate how much of the path the car can go.
            // This is done if the fuel consumption is 10 liters per 100 km,
            // 5 liters remain in the tank. Then the car will go half way.
            var pathRate = Tank.Spend(needFuel);
            var path = actualSpeed * pathRate;
            return path;
        }

        /// <summary>
        /// Casting an object to a string.
        /// </summary>
        /// <returns> Unique norm. </returns>
        public override string ToString()
        {
            return Vin;
        }
    }
}
