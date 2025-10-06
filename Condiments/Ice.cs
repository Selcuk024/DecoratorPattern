﻿using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Ice : CondimentDecorator
    {
        public Ice(Beverage beverage)
        {
            this.baseBeverage = beverage;
            this.Size = beverage.Size;
        }

        public double GetCondimentPriceBySize(double tallPrice, double grandePrice, double vendiPrice)
        {
            switch (baseBeverage.Size)
            {
                case Size.TALL:
                    return tallPrice;
                case Size.GRANDE:
                    return grandePrice;
                case Size.VENDI:
                    return vendiPrice;
                default:
                    return tallPrice;
            }
        }

        public override double cost()
        {
            return GetCondimentPriceBySize(0.10, 0.15, 0.20) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Ice";
        }
    }
}
