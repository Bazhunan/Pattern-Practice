using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Practice
{
    internal class Factory
    {

        public interface IDelivery 
        {

            void Delivery();
            
        }

        public class Truck : IDelivery
        {

            public void Delivery() 
            {

                Console.WriteLine("Delivered by Truck");
            }

        }


        public class Ship : IDelivery
        {

            public void Delivery() 
            {
                Console.WriteLine("Delivered by Ship");
            
            }

        }

        public abstract class Logistic 
        {

            public abstract IDelivery CreateDelivery();
        }

        public class RoadLogistics : Logistic
        {
            public override IDelivery CreateDelivery() 
            {
            
                return new Truck();
            
            }
        }

        public class SeaLogistic : Logistic
        {

            public override IDelivery CreateDelivery()
            {
                return new Ship();
            }
        
        }



    }
}
