using System.Net.Http.Headers;
using static Decorator_Pattern_Practice.AbstractFactory;
using static Decorator_Pattern_Practice.Factory;

namespace Decorator_Pattern_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             ICoffee coffee = new Regular_Coffee();

             Console.WriteLine($"Regular Coffee Cost: {coffee.Cost()}");

             coffee = new With_Milk(coffee);
             Console.WriteLine($"Coffee with Milk Cost: {coffee.Cost()}");

             coffee = new With_Dessert(coffee);
             Console.WriteLine($"Coffee with Dessert Cost: {coffee.Cost()}");

            */



            /*
            var registered = Singleton.Instance;
            var display = Singleton.Instance;

            registered.RegisterStudent("Kate");
            registered.RegisterStudent("Rap");

            display.DisplayStudent();
            */



            /*
            Logistic logistic = new RoadLogistics();

            IDelivery landDelivery = logistic.CreateDelivery();
            landDelivery.Delivery();
           
            */



            // Prototype prototype = new Prototype();



            IabstractFactory factory = new modernFactory();
            
            IChair chair = factory.CreateChair();
            ISofa sofa = factory.CreateSofa();

            chair.sitOn();
            sofa.lieOn();

            factory = new oldFactory();
            factory.CreateChair(); 
            factory.CreateSofa();
            
            



        }

    }
}
