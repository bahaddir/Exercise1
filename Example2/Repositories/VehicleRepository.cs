using Example2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Repositories
{
    public class VehicleRepository<T> : GenericRepository<T> where T : BaseVehicle
    {

    }
}
