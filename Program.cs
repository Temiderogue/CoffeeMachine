using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.Start();
            coffeeMachine.WaterAmount = 1000;
            coffeeMachine.ChoosePower();
        }
    }
}
