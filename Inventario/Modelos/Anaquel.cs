using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Anaquel
    {
        public string descripcion { get; set; }

        public Anaquel() { }

        public Anaquel(string descripcion)
        {
            this.descripcion = descripcion;
        }
        
    }
}
