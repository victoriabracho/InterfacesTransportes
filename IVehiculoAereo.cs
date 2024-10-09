using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehiculoAereo : IVehiculo
    {
        string Despegar();
        string Aterrizar();
        string Accidente();
    }
}

