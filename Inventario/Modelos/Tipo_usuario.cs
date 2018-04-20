using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Tipo_usuario
    {
        public string descripcion { get; set; }

        public Tipo_usuario() { }

        public Tipo_usuario(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
