using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns
{
    public class FactoryMethod
    {
        public static void Man(string[] args)
        {
            Console.WriteLine("Factory Method Design Pattern");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Creating a new ConcreteCreator1 object");
 
            Console.WriteLine("Calling the FactoryMethod of ConcreteCreator1 object");
         

            Console.WriteLine("Creating a new ConcreteCreator2 object");
      
            Console.WriteLine("Calling the FactoryMethod of ConcreteCreator2 object");
            
            Console.WriteLine("-------------------------------");
        }

    }
}
