using ConsoleApplication2.Interfaces;
using System;

namespace ConsoleApplication2.Implementations
{
    public class Car : IMotoVehicle
    {
        private string _name;
        private DateTime _date;

        public Car()
        {
            _name = "default";
            _date = DateTime.Now;
        }

        public Car(string name, string lastname)
        {
            _name = name;
            _date = DateTime.Now;
        }

        public void Start()
        {
            Console.WriteLine($"Car: Starting. {_name}, {_date}");
        }

        public void Stop()
        {
            Console.WriteLine("Car: Stopping");
        }
    }
}
