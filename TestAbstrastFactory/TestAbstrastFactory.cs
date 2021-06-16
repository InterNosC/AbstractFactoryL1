using AbstractFactoryL1.AbstractFactoryImpl;
using NUnit.Framework;

namespace TestAbstrastFactory
{
    public class Tests
    {
        [TestFixture]
        public class TestCarEngine
        {
            [Test]
            public void GetConsumption_SpeedIsLowThanZero_TermIsTrue()
            {
                var speed = 1;
                var result = 0.0008 * speed * speed - 0.2 * speed + 15;
                var factory = new CarFactory();
                var engine = factory.CreateEngine();

                Assert.That(engine.GetConsumption(1) == result);
            }

            [Test]
            public void GetConsumption_SpeedIsHigherThanZero_TermIsTrue()
            {
                var speed = 2;
                var result = 0.0008 * speed * speed - 0.2 * speed + 15;
                var factory = new CarFactory();
                var engine = factory.CreateEngine();

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
                double valuemOfFuel = 30;
                double result = valuemOfFuel / fuel;
                var factory = new CarFactory();
                var tank = factory.CreateTank();

                Assert.That(tank.Spend(fuel) == result);
            }
        }
    }
}