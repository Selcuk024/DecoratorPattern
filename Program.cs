﻿using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso(Size.TALL);
            PrintBeverage(espresso);

            Beverage lungo = new Espresso(Size.GRANDE);
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso(Size.VENDI);
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine("Ingredients: " + beverage.GetDescription());
            Console.WriteLine("Price: $" + beverage.cost().ToString("#.##"));
            Console.WriteLine("Size: " + beverage.Size);
        }
    }
}