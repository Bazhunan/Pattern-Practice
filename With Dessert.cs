using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Practice
{
    internal class With_Dessert : ICoffee
    {

        private ICoffee coffee;

        public With_Dessert(ICoffee coffee) => this.coffee = coffee;

        public double Cost() => coffee.Cost() + 100; 


    }
}
