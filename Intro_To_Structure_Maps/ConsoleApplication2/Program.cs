using ConsoleApplication2.Implementations;
using ConsoleApplication2.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static Container _container;

        static void Main(string[] args)
        {
            SetUpContainer();

            var response = string.Empty;

            Console.WriteLine("Enter Vehicle Type (truck, car, bike)");
            response = Console.ReadLine();

            while (response != "exit")
            {
                var vehicle = GetVehicle(response);

                vehicle.Start();
                vehicle.Stop();

                Console.WriteLine("Enter Vehicle Type (truck, car, bike)");
                response = Console.ReadLine();
                
            }

            //Console.ReadLine();
        }

        private static IMotoVehicle GetVehicle(string response)
        {

            var vehicle = _container.GetInstance<IMotoVehicle>(response);

            return vehicle;
        }

        private static void SetUpContainer()
        {
            //MyContainer = new Container(_ =>
            //{
            //    _.For<IMotoVehicle>().Use<Bike>();
            //    //_.For<IBar>().Use<Bar>();
            //});

            //MyContainer = new Container(_ =>
            //{
            //    _.Scan(x =>
            //    {
            //        x.TheCallingAssembly();
            //        x.WithDefaultConventions();
            //    });
            //});

            _container = new Container(x => x.AddRegistry<VehicleRegistry>());
        }
    }
}
