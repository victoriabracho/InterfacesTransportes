using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Interfaces.Interfaces;

namespace Interfaces
{
    internal class Barco : Transporte, IVehiculoMaritimo
    {
        private int velocidad = 40;

        public Barco(string nombre) : base(nombre) 
        { 
        
        }

        public override string Encender()
        {
            velocidad = 40;
            return "El barco está encendido.\n Vas a una velocidad de " + velocidad + "k/h";
        }

        public override string Apagar()
        {
            velocidad = 0;
            return "El barco se ha apagado.";
        }

        public string Acelerar()
        {
            velocidad += 20;
            return "El barco está acelerando. Ahora llevas una velocidad de "+ velocidad +"k/h";
        }

        public string Frenar()
        {
            velocidad -= 20;
            return"El barco está frenando. Ahora llevas una velocidad de " + velocidad + "k/h";
        }

        public string ObtenerVelocidad()
        {
            return "Tu velocidad es de "+ velocidad + "k/h";
        }

        public string Anclarse()
        {
            velocidad = 0;
            return "El barco está anclado.";
        }

        public string Hundirse()
        {
            velocidad = 0;
            return "GLU GLU, el barco se ha hundido";
        }
    }
}

