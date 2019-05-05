//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.Sql;
//using System.Data.SqlClient;
//using System.Windows.Forms;



//namespace Voto_Electronico
//{
//    class AccesoDatosSQL
//    {
//        SqlConnection sqlconect;
//        SqlCommand sqlcmd;
//        SqlDataReader sqdr;
//        DataTable tabla;

//        public SqlDataReader Sqdr { get => sqdr; set => sqdr = value; }

//        public AccesoDatosSQL()
//        {
//            try 
//            {
//                sqlconect = new SqlConnection("Data Source=ISMASPC\\SQLEXPRESS;Initial Catalog=VotoElectronicov1;Integrated Security=True");
//                sqlconect.Open();
//                MessageBox.Show("Se conecto satisfactoriamente");


//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("No se Conecto" + ex.ToString());
//            }
   
//        }
//        public AccesoDatosSQL(string c)
//        {
//            sqlconect = new SqlConnection();
//            sqlcmd = new SqlCommand();
//            tabla = new DataTable();
//        }


//        public string insertar(int dni, string nombre, string apellidos, string direccion, int id_barrio, int id_depto, bool sexo)
//        {
//            string salida = "Se se inserto";
//            try
//            {
//                sqlcmd = new SqlCommand("insert into Ciudadanos (dni,apellido,nombre,direccion,id_barrio,id_dpto,sexo) values(" + a.DNI1 + ", '" + a.Apellido1 + "', '" + a.Nombre1 + "', '" + a.Direccion + "', " + a.Barrio + ", " + a.Depto + ", " + a.Sexo + ") ", sqlconect);
//                sqlcmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                salida = "No se conecto: " + ex.ToString();
//            }
//            return salida;
//        }



//        public int personaRegistrada(int id)
//        {
//            int contador = 0;
//            try
//            {
//                sqlcmd = new SqlCommand("Select * from Persona where DNI=" + id + "", sqlconect);
//                Sqdr = sqlcmd.ExecuteReader();
//                while (Sqdr.Read())
//                {
//                    contador++;
//                }
//                Sqdr.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
//            }
//            return contador;
//        }
//    }
//}
