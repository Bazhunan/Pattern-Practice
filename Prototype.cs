using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Practice
{
    internal class Prototype
    {
        public record Monster
        (string Name,
         int Level,
         string Element
        );

        public Prototype() 
        {

            var monster1 = new Monster
           (
            "Goblin",
            10,
            "Earth"
           );

            var monster2 = monster1 with
            {
               Name = "Minotaur",
               Level =  80,
               Element = "Earth"

            };

            var monster3 = monster1;

            var monster4 = monster1 with
            {
                Name = "Chaos Goblin",
                Level = 9999,
                Element = "Chaos"
            };

            Console.WriteLine($"1 Default {monster1}");
            Console.WriteLine($"2 {monster2} ");
            Console.WriteLine($"3 {monster3}");
            Console.WriteLine($"4 {monster4}");

        }

    }
}
