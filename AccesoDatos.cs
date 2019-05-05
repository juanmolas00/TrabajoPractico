using Voto_Electronico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Voto_Electronico
{
    class AccesoDatos
    {
        string cadena;
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataReader lector;
        DataTable tabla;


        public OleDbDataReader pLector
        {
            get { return lector; }
            set { lector = value; }
        }


        public string pCadena
        {
            get { return cadena; }
            set { cadena = value; }
        }

        public AccesoDatos()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
        }
        public AccesoDatos(string cad)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            tabla = new DataTable();
            cadena = cad;
        }

        private void conectar()
        {
            conexion.ConnectionString = cadena;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public void leerTabla(string nom)
        {
            conectar();
            comando.CommandText = "select * from " + nom;
            lector = comando.ExecuteReader();
        }

        public DataTable consultarTabla(string nom)
        {
            conectar();
            comando.CommandText = "select * from " + nom;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable consultarDB(string consulta)
        {
            conectar();
            comando.CommandText = consulta;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void actualizarDB(string query)
        {
            conectar();
            comando.CommandText = query;
            comando.ExecuteNonQuery();
            desconectar();
        }
        public void DeleteDB(string table, string query)
        {
            conectar();
            comando.CommandText = "DELETE FROM " + table + " WHERE "+ query;
            comando.ExecuteNonQuery();
            desconectar();
        }

        //cargar data grid mediante la toma de datos de un richtextbox
        public DataTable cargardatagrid(DataGridView dgv, RichTextBox rtxtb)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = rtxtb.Text;
            tabla.Load(comando.ExecuteReader());
            dgv.DataSource = tabla;
            desconectar();
            return tabla;
        }

        public DataTable consultaGral(string sql)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable cargardatagrid(DataGridView dgv, string sql)
        {
            tabla = new DataTable();
            conectar();
            comando.CommandText = sql;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            dgv.DataSource = tabla;
            return tabla;
        }

    }
}
