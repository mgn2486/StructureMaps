using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Implementations
{
    public class Truck : IMotoVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck: Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Trunk: Stopping");
        }
    }
}
