using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Practice
{
    internal class With_Milk : ICoffee
    {

        private ICoffee coffee;

        public With_Milk(ICoffee coffee) => this.coffee = coffee;

        public double Cost() => coffee.Cost() + 50;


    }
}
