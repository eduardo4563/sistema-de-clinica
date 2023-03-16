using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionCD
    {
        public static SqlConnection conectarToSqlServer()
        {
            //Generar una cadena de Conexion
            SqlConnectionStringBuilder generadorCadena = new SqlConnectionStringBuilder();
            generadorCadena.DataSource = "DESKTOP-0EQ7USE\\SQLEXPRESS"; //SERVIDOR
            generadorCadena.InitialCatalog = "dbVeterinaria"; //BASE DE DATOS
            generadorCadena.IntegratedSecurity = true; //autenticacion integrada
            

            //Cadena de Conexion
            string cadenaConexion = generadorCadena.ConnectionString; //Devulve la cadena de conexion generada

            //Instanciar una Conexion a SQL SERVER
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //Devolver la conexion
            return conexion;
        }
    }
}
