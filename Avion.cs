using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Interfaces
{
    internal class Avion : Transporte, IVehiculoAereo
    {
        private int velocidad = 900;

        public Avion(string nombre) : base(nombre)
        {
        
        }

        public override string Encender()
        {
            velocidad = 900;
            return "El avión está encendido.\nVas a una velocidad de " + velocidad+ "k/h";
        }

        public override string Apagar()
        {
            velocidad = 0;
            return "El avión se ha apagado.";
        }

        public string Acelerar()
        {
            velocidad += 100;
            return "El avión está acelerando. Ahora llevas una velocidad de "+ velocidad+"k/h";
        }

        public string Frenar()
        {
            velocidad -= 100;
            return "El avión está frenando. Ahora llevas una velocidad de " + velocidad+ "k/h";
        }

        public string ObtenerVelocidad()
        {
            return "Tu velocidad actual es de " + velocidad + "k/h";
        }

        public string Despegar()
        {
            velocidad = 900;
            return "El avión está despegando. Vas a una velocidad de " + velocidad + "k/h";
        }

        public string Aterrizar()
        {
            velocidad = 0;
            return "El avión está aterrizando.";
        }

        public string Accidente()
        {
            velocidad = 0;
            return "MayDay, MayDay, BOOM";
        }
    }
}
