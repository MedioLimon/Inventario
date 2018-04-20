using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario;

namespace Inventario.Modelos
{
    class M_Usuarios
    {
        public static Usuarios read(String Nombre)
        {
            
            Usuarios elUsurio = new Usuarios();
            if (Conexion.consulta("select * from usuarios where nombre like '%" + Nombre + "%' or apellidos like '%" + Nombre + "%'  or usuario like '%" + Nombre + "%'", true) != "Sin retorno.")
            //("select u.nombre, u.apellidos, tipo_usuario.descripcion as TipoCuenta, puesto.descripcion as Puesto, u.usuario, u.password, u.edad,u.sexo,u.telefono,u.e_mail,u.direccion,u.cp from usuarios as u join tipo_usuario on tipo_usuario.id = u.id_tipo_usuario join puesto on puesto.id = u.id_puesto " +
            //" where nombre like '%" + Nombre + "%' or apellidos like '%" + Nombre + "%'  or usuario like '%" + Nombre + "%'", true)!="Sin retorno.")
            {
                elUsurio.nombre = Conexion.datos.GetString(1);
                elUsurio.apellidos = Conexion.datos.GetString(2);
                elUsurio.id_puesto = Conexion.datos.GetInt32(3);
                elUsurio.id_tipo_usuario = Conexion.datos.GetInt32(4);
                elUsurio.usuario = Conexion.datos.GetString(5);
                elUsurio.password = Conexion.datos.GetString(6);
                elUsurio.edad = Conexion.datos.GetInt16(7);
                elUsurio.sexo = Conexion.datos.GetString(8);
                elUsurio.telefono = Conexion.datos.GetString(9);
                elUsurio.e_mail = Conexion.datos.GetString(10);
                elUsurio.direccion = Conexion.datos.GetString(11);
                elUsurio.cp = Conexion.datos.GetString(12);

            }
                
            Conexion.conectar.Close();
            return elUsurio;
        }

        public static Usuarios readName(String Nombre)
        {

            Usuarios elUsurio = new Usuarios();
            if (Conexion.consulta("select nombre, apellidos from usuarios where nombre like '%" + Nombre + "%' or apellidos like '%" + Nombre + "%'", true) != "Sin retorno.")
            {
                elUsurio.nombre = Conexion.datos.GetString(1);
                elUsurio.apellidos = Conexion.datos.GetString(2);
            }

            Conexion.conectar.Close();
            return elUsurio;
        }

        public static Usuarios delete(String Nombre)
        {

            Usuarios elUsurio = new Usuarios();
            if (Conexion.consulta("select nombre, apellidos from usuarios where nombre like '%" + Nombre + "%' or apellidos like '%" + Nombre + "%'", true) != "Sin retorno.")
            {
                elUsurio.nombre = Conexion.datos.GetString(1);
                elUsurio.apellidos = Conexion.datos.GetString(2);
            }

            Conexion.conectar.Close();
            return elUsurio;
        }
    }
}
