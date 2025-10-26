using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2.Interfaces
{
    public interface IRentable
    {

        bool IsAvailable(DateTime startDate,DateTime endDate);


    }
}
