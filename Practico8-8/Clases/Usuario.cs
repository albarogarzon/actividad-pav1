using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Practico8_8.Clases
{
    class Usuario
    {
        int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        string n_usuario;

        public string N_usuario
        {
            get { return n_usuario; }
            set { n_usuario = value; }
        }


        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        int id_perfil;

        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }

        public int validarUsuario(string nombre,string clave)
        {
            DataTable Tabla = new DataTable();
            string ConsultaSQL = "SELECT * FROM USERS WHERE n_usuario = '"+ nombre +"' AND password='"+ clave +"'";
            Datos ObjBD = new Datos();
            Tabla = ObjBD.Consultar(ConsultaSQL);
            if (Tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(Tabla.Rows[0][0]);
            }
            else return 0;
        }
       
    }
}
