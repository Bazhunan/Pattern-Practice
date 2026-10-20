using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern_Practice
{
    internal class Singleton
    {

        private static Singleton instance;

        private List<string> students = new List<string>();

        public static Singleton Instance => instance ??= new Singleton();

        private Singleton() { }


        public void RegisterStudent(string student) 
        {
            students.Add(student);
            Console.WriteLine($"{student} Successfully Registered");
        }


        public void DisplayStudent() 
        {
            Console.WriteLine("\nRegistered Students");
            foreach (var student in students)
            {

                Console.WriteLine(student);
            
            }
        
        }


    }
}
