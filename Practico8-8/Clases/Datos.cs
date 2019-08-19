using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Practico8_8.Clases
{
    class Datos
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private string CadenaConexion = @"Provider=SQLNCLI11;Data Source=MAQUIS;User ID=avisuales1;Initial Catalog=BD_bugs;Password=avisuales1";

        private void Conectar()
        {
            Conexion.ConnectionString = CadenaConexion;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
        }

        private void Desconectar()
        {
            Conexion.Close();
        }

        public DataTable Consultar(string ConsultaSQL) //Tabla en memoria con filas y columnas
        {
            DataTable Tabla = new DataTable();
            this.Conectar();
            Comando.CommandText = ConsultaSQL;
            Tabla.Load(Comando.ExecuteReader());
            this.Desconectar();
            return Tabla;
        }
    }
}
