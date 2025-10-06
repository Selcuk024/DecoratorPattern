using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage Espresso_ = new Espresso(Size.GRANDE);
            PrintBeverage(Espresso_, "Espresso");

            Beverage Doppio = new Espresso(Size.GRANDE);
            PrintBeverage(Doppio, "Doppio");

            Beverage Lungo = new Espresso(Size.GRANDE);
            Lungo = new Water(Lungo);
            PrintBeverage(Lungo, "Lungo");

            Beverage Macchiato = new Espresso(Size.GRANDE);
            Macchiato = new MilkFoam(Macchiato);
            PrintBeverage(Macchiato, "Macchiato");

            Beverage Corretta = new Espresso(Size.GRANDE);
            Corretta = new Liquor(Corretta);
            PrintBeverage(Corretta, "Corretta");

            Beverage Con_Panna = new Espresso(Size.GRANDE);
            Con_Panna = new Whip(Con_Panna);
            PrintBeverage(Con_Panna, "Con Panna");

            Beverage Cappuccino = new Espresso(Size.GRANDE);
            Cappuccino = new SteamedMilk(Cappuccino);
            Cappuccino = new MilkFoam(Cappuccino);
            PrintBeverage(Cappuccino, "Cappuccino");

            Beverage Americano = new Espresso(Size.GRANDE);
            Americano = new Water(Americano);
            Americano = new Water(Americano);
            PrintBeverage(Americano, "Americano");

            Beverage Caffe_Latte = new Espresso(Size.GRANDE);
            Caffe_Latte = new SteamedMilk(Caffe_Latte);
            Caffe_Latte = new SteamedMilk(Caffe_Latte);
            Caffe_Latte = new MilkFoam(Caffe_Latte);
            PrintBeverage(Caffe_Latte, "Caffé Latte");

            Beverage Flat_White = new Espresso(Size.GRANDE);
            Flat_White = new SteamedMilk(Flat_White);
            Flat_White = new SteamedMilk(Flat_White);
            PrintBeverage(Flat_White, "Flat White");

            Beverage Romana = new Espresso(Size.GRANDE);
            Romana = new Lemon(Romana);
            PrintBeverage(Romana, "Romana");

            Beverage Morocchino = new Espresso(Size.GRANDE);
            Morocchino = new DecoratorPattern.Condiments.Chocolate(Morocchino);
            Morocchino = new MilkFoam(Morocchino);
            PrintBeverage(Morocchino, "Morocchino");

            Beverage Mocha = new Espresso(Size.GRANDE);
            Mocha = new DecoratorPattern.Condiments.Chocolate(Mocha);
            Mocha = new SteamedMilk(Mocha);
            Mocha = new Whip(Mocha);
            PrintBeverage(Mocha, "Mocha");

            Beverage Bicerin = new Espresso(Size.GRANDE);
            Bicerin = new BlackChocolate(Bicerin);
            Bicerin = new WhiteChocolate(Bicerin);
            Bicerin = new Whip(Bicerin);
            PrintBeverage(Bicerin, "Bicerin");

            Beverage Breve = new Espresso(Size.GRANDE);
            Breve = new MilkFoam(Breve);
            Breve = new HalfMilk(Breve);
            PrintBeverage(Breve, "Breve");

            Beverage Raf_coffee = new Espresso(Size.GRANDE);
            Raf_coffee = new VanillaSugar(Raf_coffee);
            Raf_coffee = new Cream(Raf_coffee);
            PrintBeverage(Raf_coffee, "Raf coffee");

            Beverage Mead_raf = new Espresso(Size.GRANDE);
            Mead_raf = new Honey(Mead_raf);
            Mead_raf = new Cream(Mead_raf);
            PrintBeverage(Mead_raf, "Mead raf");

            Beverage Galao = new Espresso(Size.GRANDE);
            Galao = new MilkFoam(Galao);
            Galao = new MilkFoam(Galao);
            PrintBeverage(Galao, "Galao");

            Beverage Caffe_affogato = new Espresso(Size.GRANDE);
            Caffe_affogato = new Espresso(Size.GRANDE, Caffe_affogato);
            Caffe_affogato = new IceCream(Caffe_affogato);
            PrintBeverage(Caffe_affogato, "Caffé affogato");

            Beverage Vienna_coffee = new Espresso(Size.GRANDE);
            Vienna_coffee = new Whip(Vienna_coffee);
            Vienna_coffee = new Whip(Vienna_coffee);
            PrintBeverage(Vienna_coffee, "Vienna coffee");

            Beverage Glace = new Espresso(Size.GRANDE);
            Glace = new IceCream(Glace);
            PrintBeverage(Glace, "Glace");

            Beverage Chocolate_milk = new DecoratorPattern.Beverages.Chocolate(Size.GRANDE);
            Chocolate_milk = new Milk(Chocolate_milk);
            PrintBeverage(Chocolate_milk, "Chocolate milk");

            Beverage Demi_creme = new Espresso(Size.GRANDE);
            Demi_creme = new Cream(Demi_creme);
            Demi_creme = new Cream(Demi_creme);
            PrintBeverage(Demi_creme, "Demi – créme");

            Beverage Latte_macchiato = new Espresso(Size.GRANDE);
            Latte_macchiato = new SteamedMilk(Latte_macchiato);
            Latte_macchiato = new SteamedMilk(Latte_macchiato);
            Latte_macchiato = new MilkFoam(Latte_macchiato);
            PrintBeverage(Latte_macchiato, "Latte macchiato");

            Beverage Freddo = new Espresso(Size.GRANDE);
            Freddo = new Liquor(Freddo);
            Freddo = new Ice(Freddo);
            PrintBeverage(Freddo, "Freddo");

            Beverage Frappuccino = new Espresso(Size.GRANDE);
            Frappuccino = new Ice(Frappuccino);
            Frappuccino = new SteamedMilk(Frappuccino);
            Frappuccino = new Whip(Frappuccino);
            PrintBeverage(Frappuccino, "Frappuccino");

            Beverage Caramel_frappuccino = new Espresso(Size.GRANDE);
            Caramel_frappuccino = new Ice(Caramel_frappuccino);
            Caramel_frappuccino = new SteamedMilk(Caramel_frappuccino);
            Caramel_frappuccino = new Cream(Caramel_frappuccino);
            Caramel_frappuccino = new Syrup(Caramel_frappuccino);
            PrintBeverage(Caramel_frappuccino, "Caramel frappuccino");

            Beverage Frappe = new Espresso(Size.GRANDE);
            Frappe = new SteamedMilk(Frappe);
            Frappe = new MilkFoam(Frappe);
            PrintBeverage(Frappe, "Frappe");

            Beverage Irish_Coffee = new Espresso(Size.GRANDE);
            Irish_Coffee = new Whiskey(Irish_Coffee);
            Irish_Coffee = new Cream(Irish_Coffee);
            PrintBeverage(Irish_Coffee, "Irish Coffee");
        }

        static void PrintBeverage(Beverage beverage, string name)
        {
            Console.WriteLine($"Naam: {name}");
            Console.WriteLine("Maat: " + beverage.Size);
            Console.WriteLine("Beschrijving: " + beverage.GetDescription());
            Console.WriteLine("Prijs: " + beverage.cost().ToString("#.##") + " Euro");
            Console.WriteLine();
        }
    }
}
