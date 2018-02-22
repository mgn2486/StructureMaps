using StructureMap;
using ConsoleApplication2.Interfaces;
using ConsoleApplication2.Implementations;

namespace ConsoleApplication2
{
    public class VehicleRegistry : Registry
    {
        public VehicleRegistry()
        {
            For<IMotoVehicle>().AddInstances(x => 
            {
                x.Type<Bike>()
                 .Named("bike");

                x.Type<Car>()
                 .Ctor<string>("name").Is("it's working")
                 .Ctor<string>("lastname").Is("gumede")
                 .Singleton()
                 .Named("car2");

                x.Type<Car>()
                 .Singleton()
                 .Named("car");

                x.Type<Truck>()
                 .Transient()
                 .Named("truck");

                x.Type<MotoVehicle>()
                 .Named("default");
            });
        }
    }
}
