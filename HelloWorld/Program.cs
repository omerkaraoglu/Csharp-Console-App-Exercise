using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);

            Car Opel = new Car("Astra", "White", 2005);
            Console.WriteLine(Opel.color + " " + Opel.year + " " + Opel.model);

            Ford.fullThrottle();
            Opel.fullThrottle();
        }
    }
}
