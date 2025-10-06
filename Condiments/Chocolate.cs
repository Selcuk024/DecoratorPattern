using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Chocolate : CondimentDecorator
    {
        public Chocolate(Beverage beverage)
        {
            this.baseBeverage = beverage;
            this.Size = beverage.Size;
        }

        public override double cost()
        {
            double price = 0.0;
            switch (Size)
            {
                case Size.TALL: price = 0.40; break;
                case Size.GRANDE: price = 0.50; break;
                case Size.VENDI: price = 0.60; break;
            }

            return price + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Chocolate";
        }
    }
}
