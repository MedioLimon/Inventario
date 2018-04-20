using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Liquidacion
    {
        public float porcentaje { get; set; }

        public Liquidacion() { }

        public Liquidacion(float porcentaje)
        {
            this.porcentaje = porcentaje;
        }
    }
}
