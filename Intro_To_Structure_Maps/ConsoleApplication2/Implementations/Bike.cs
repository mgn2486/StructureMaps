using ConsoleApplication2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Implementations
{
    public class Bike : IMotoVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike: Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Bike: Stopping");
        }
    }
}
