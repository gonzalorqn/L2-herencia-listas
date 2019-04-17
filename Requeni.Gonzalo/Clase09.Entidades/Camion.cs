using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public string MostrarCamion()
        {
            return base.Mostrar() + " - Tara: " + this.tara;
        }

        public Camion(float tara, string patente, Byte cantRuedas, EMarca marca):base(patente,cantRuedas,marca)
        {
            this.tara = tara;
        }
    }
}
