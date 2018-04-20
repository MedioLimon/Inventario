using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Bodega
    {

        public string descripcion { get; set; }

        public Bodega() { }

        public Bodega(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
