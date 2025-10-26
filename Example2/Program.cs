using Example2.AbstractClasses;
using Example2.Interfaces;
using Example2.Repositories;
using Example2.Classes;
using Example2.Classes.CustomerClasses;
using Example2.Classes.VehicleClasses;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car c1 = new Car("mercedes", "e200", 2020, 1400, 5, true);
            Truck t1 = new Truck("volvo", "ax1", 2015, 6000, 15000, true);
            VehicleRepository<BaseVehicle> vehRepo = new VehicleRepository<BaseVehicle>();
            IndividualCustomer ic1 = new IndividualCustomer("bahadir", "dogan", "baha@baha", "b1", DateTime.Now,"113asd");
            vehRepo.Add(c1);
            vehRepo.Add(t1);
            vehRepo.GetById(c1.Guid);
            Rental r1 = new Rental(c1, ic1, new DateTime(2025, 05, 05), new DateTime(2025, 05, 10));
            Console.WriteLine(r1.TotalPrice);

        }
    }
}
