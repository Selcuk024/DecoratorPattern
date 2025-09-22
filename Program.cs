﻿using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso(Size.GRANDE);
            PrintBeverage(espresso);

            Beverage lungo = new Espresso(Size.VENDI);
            lungo = new Water(lungo.Size, lungo);
            PrintBeverage(lungo);

            Beverage americano = new Espresso(Size.VENDI);
            americano = new Water(americano.Size, americano);
            americano = new Water(americano.Size, americano);
            PrintBeverage(americano);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine("Maat: " + beverage.Size);
            Console.WriteLine("Beschrijving: " + beverage.GetDescription());
            Console.WriteLine("Prijs: " + beverage.cost().ToString("#.##") + "Euro");
            Console.WriteLine();
        }


    }
}