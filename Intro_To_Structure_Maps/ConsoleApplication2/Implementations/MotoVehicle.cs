using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApplication2.Interfaces;

namespace ConsoleApplication2.Implementations
{
    public class MotoVehicle : IMotoVehicle
    {
        public void Start()
        {
            Console.WriteLine("Default: Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Default: Stopping");
        }
    }
}
