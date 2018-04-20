using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Categoria
    {
        public string descripcion { get; set; }
        public int id_producto { get; set; }

        public Categoria() { }

        public Categoria(string descripcion, int id_producto)
        {
            this.descripcion = descripcion;
            this.id_producto = id_producto;
        }
    }
}
