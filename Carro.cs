using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    namespace Interfaces
    {
        internal class Carro : Transporte, IVehiculoTerrestre
        {
            private int velocidad=80;

            public Carro(string nombre) : base(nombre) 
            {

            }

            public override string Encender()
            {
                velocidad = 80;
                return "El carro está encendido.\nVas a una velocidad de " + velocidad+"k/h";
            }

            public override string Apagar()
            {
                velocidad = 0;
                return "El carro se ha apagado.";
            }

            public  string Acelerar()
            {
                velocidad += 5;
                return "El carro está acelerando. Ahora llevas una velocidad de "+ velocidad+"k/h";
            }

            public  string Frenar()
            {
                velocidad -= 5;
                return "El carro está frenando. Ahora llevas una velocidad de " + velocidad+ "k/h";
            }

            public string ObtenerVelocidad()
            {
                return "Tu velocidad es de " + velocidad + "k/h";
            }

            public string CambiarMarcha()
            {
                return "El carro ha cambiado de marcha.";
            }

            public string Chocar()
            {
                velocidad = 0;
                return "CRASH, ya chocaste bro";
            }
        }
    }

}
