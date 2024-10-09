using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Transporte
    {
        protected string nombre;

        public Transporte(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract string Encender();
        public abstract string Apagar();

        public string Nombre()
        {
            return nombre;
        }
    }
}
