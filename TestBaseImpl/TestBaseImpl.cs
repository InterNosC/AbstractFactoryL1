using AbstractFactoryL1.BaseImpl;
using NUnit.Framework;

namespace TestBaseImpl
{
    [TestFixture]
    public class TestCarEngine
    {
        [Test]
        public void GetConsumption_SpeedIsLowThanZero_TermIsTrue()
        {
            var speed = 1;
            var result = 0.0008 * speed * speed - 0.2 * speed + 17;
            var engine = new Engine("car", 10, 10, 10);

            Assert.That(engine.GetConsumption(1) == result);
        }

        [Test]
        public void GetConsumption_SpeedIsHigherThanZero_TermIsTrue()
        {
            var speed = 2;
            var result = 0.0008 * speed * speed - 0.2 * speed + 17;
            var engine = new Engine("car", 10, 10, 10);

            Assert.That(engine.GetConsumption(2) == result);
        }
    }

    [TestFixture]
    public class TestCarTank
    {
        [Test]
        public void Spend_HigherThenValumOfFuel_TermIsTrue()
        {
            double fuel = 150;
            double valuemOfFuel = 128;
            double result = valuemOfFuel / fuel;
            var tank = new Tank("car", valuemOfFuel, 10, 10);

            Assert.That(tank.Spend(fuel) == result);
        }

        [Test]
        public void Spend_LowerThenValumOfFuel_TermIsTrue()
        {
            double fuel = 34;
            double valuemOfFuel = 128;
            var tank = new Tank("car", valuemOfFuel, 10, 10);

            
            Assert.That(tank.Spend(fuel) == 1);
        }
    }

    [TestFixture]
    public class TestStep
    {
        [Test]
        public void Step_CarStep_TermIsTrue()
        {
            var body = new Body("Priora", 1.0, 100000, 2000, 300);
            var engine = new Engine("v8", 200, 150000, 200);
            var tank = new Tank("Standard", 48, 30000, 40);

            var body2 = new Body("Priora", 1.0, 100000, 2000, 300);
            var engine2 = new Engine("v8", 200, 150000, 200);
            var tank2 = new Tank("Standard", 48, 30000, 40);

            var car = new Car(body2, engine2, tank2);

            var speed = 150;
            var actualSpeed = speed < engine.MaxSpeed ? speed : engine.MaxSpeed;
            actualSpeed *= body.Aerodynamic;
            actualSpeed *= tank.SpeedFactor;
            var needFuel = engine.GetConsumption(actualSpeed);
            var pathRate = tank.Spend(needFuel);
            var path = actualSpeed * pathRate;


            Assert.That(car.Step(speed) == path);
        }
    }
}