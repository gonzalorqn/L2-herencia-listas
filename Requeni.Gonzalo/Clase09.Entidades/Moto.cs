using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public string MostrarMoto()
        {
            return base.Mostrar() + " - Cilindrada: " + this.cilindrada;
        }

        public Moto(float cilindrada, string patente, Byte cantRuedas, EMarca marca) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
    }
}
