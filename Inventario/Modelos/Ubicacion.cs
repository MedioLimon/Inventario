using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Ubicacion
    {
        public int id_usuario { get; set; }
        public int id_bodega { get; set; }
        public int id_anaquel { get; set; }

        public Ubicacion() { }

        public Ubicacion(int id_usuario, int id_bodega, int id_anaquel)
        {
            this.id_usuario = id_usuario;
            this.id_bodega = id_bodega;
            this.id_anaquel = id_anaquel;
        }
    }
}
