using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Puesto
    {
        public string descripcion { get; set; }

        public Puesto() { }

        public Puesto(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
