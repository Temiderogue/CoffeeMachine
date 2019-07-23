using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        public int waterAmount = 0;
        private int MaxwaterAmount = 5000;
        public int power = 0;

        public void Start()
        {
            Console.WriteLine("Кофеварка запущена и готова к работе!");
        }

        public int WaterAmount
        {
            get
            {
                return waterAmount;
            }
            set
            {
                if (value < MaxwaterAmount)
                {
                    waterAmount = value;
                    Console.WriteLine($"Вы налили {waterAmount} мл");
                }
                else
                {
                    Console.WriteLine("Молодец, ты залил всю кухню водой, неси тряпку!");
                }
            }
        }

        public void ChoosePower()
        {
            Console.WriteLine("Выберите мощность: \n1.200\n2.400\n3.600");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    power = 200;
                    break;
                case "2":
                    power = 400;
                    break;
                case "3":
                    power = 600;
                    break;
            }
        }
    }
}
