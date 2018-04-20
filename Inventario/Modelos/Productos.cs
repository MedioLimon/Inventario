using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Productos
    {
        public string color { get; set; }
        public string genero { get; set; }
        public int id_liquidacion { get; set; }
        public int id_ubicacion { get; set; }
        public string temporada { get; set; }
        public int id_proveedor { get; set; }
        public string img { get; set; }

        public Productos() { }

        public Productos(string color, string genero, int id_liquidacion, int id_ubicacion, string temporada, int id_proveedor, string img)
        {
            this.color = color;
            this.genero = genero;
            this.id_liquidacion = id_liquidacion;
            this.id_ubicacion = id_ubicacion;
            this.temporada = temporada;
            this.id_proveedor = id_proveedor;
            this.img = img;
        }
    }
}
