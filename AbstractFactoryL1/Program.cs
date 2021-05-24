using System;
namespace AbstractFactoryL1
{
    class Program
    {
        static void Main(string[] args)
        {
            var objWithoutPattern = new WithoutPattern();
            objWithoutPattern.StartMove();

            var objWithPatern = new WithPattern();
            objWithPatern.StartMove();
        }
    }
}
