using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Usuarios
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int id_tipo_usuario { get; set; }
        public int id_puesto { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string e_mail { get; set; }
        public string direccion { get; set; }
        public string cp { get; set; }
        public Usuarios() { }
        public Usuarios(string nombre, string apellidos, int id_tipo_usuario, int id_puesto,
            string usuario, string password, int edad, string sexo, string telefono, string e_mail, string direccion,string cp)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.id_tipo_usuario = id_tipo_usuario;
            this.id_puesto = id_puesto;
            this.usuario = usuario;
            this.password = password;
            this.edad = edad;
            this.sexo = sexo;
            this.telefono = telefono;
            this.e_mail = e_mail;
            this.direccion = direccion;
            this.cp = cp;
        }
    }
}
