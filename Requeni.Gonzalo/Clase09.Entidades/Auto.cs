using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public string MostrarAuto()
        {
            return base.Mostrar() + " - Cantidad asientos: " + this.cantidadAsientos;
        }

        public Auto(int cantAsientos, string patente, Byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantAsientos;
        }
    }
}
