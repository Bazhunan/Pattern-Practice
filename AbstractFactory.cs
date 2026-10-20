using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace Decorator_Pattern_Practice
{
    internal class AbstractFactory
    {
        public interface IChair { void sitOn(); }
        

        public interface ISofa { void lieOn(); }

        public class modernChair : IChair 
        {
            public void sitOn() 
            {
                Console.WriteLine("Sitting on modern chair");
            } 

        }

        public class modernSofa : ISofa
        {
            public void lieOn() { Console.WriteLine("Liedown on modern sofa"); }
        }

        public class oldChair : IChair 
        {
            public void sitOn() { Console.WriteLine("Sitting on an old chair"); }
        
        }
       
        public class oldSofa : ISofa
        {
            public void lieOn() => Console.WriteLine("Sitting on an old chair");
        }


        public interface IabstractFactory 
        {
            IChair CreateChair();
            ISofa  CreateSofa();

        }

        public class modernFactory()  : IabstractFactory
        {

            public IChair CreateChair() { return new modernChair(); }
            public ISofa CreateSofa() { return new modernSofa(); }
        
        }

        public class oldFactory : IabstractFactory 
        {
            public IChair CreateChair() => new oldChair();
            public ISofa CreateSofa() => new oldSofa();
        
        }

        
    }
}
