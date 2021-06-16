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
}