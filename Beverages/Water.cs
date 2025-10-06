﻿using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments
{
    internal class Water : CondimentDecorator
    {
        public Water(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }
        public override double cost()
        {
            return 0.20 + baseBeverage.cost();
        }
        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Water";
        }
    }
}