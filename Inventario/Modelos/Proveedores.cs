using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Proveedores
    {
        public string empresa { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string e_mail { get; set; }
        public string nombre_contacto { get; set; }

        public Proveedores(string empresa, string telefono, string direccion, string e_mail,  string nombre_contacto)
        {
            this.empresa = empresa;
            this.telefono = telefono;
            this.direccion = direccion;
            this.e_mail = e_mail;
            this.nombre_contacto = nombre_contacto;
        }
    }
}
