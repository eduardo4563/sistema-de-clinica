using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using CapaEntidad;

namespace CapaDatos
{
    public class PropietarioCD
    {
        public PropietarioCE buscarById(int idBuscar)
        {
            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = cnx.CreateCommand();
            //Definir el Tipo de comando
            cmd.CommandType = CommandType.Text;
            //Asignar al comando el SQL
            cmd.CommandText = "select * from propietario where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drPropietario = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int idPropietario;
            string nombrePropietario;
            string apellidoPropietario;
            string dniPropietario;
            string telefonoPropietario;
            string direccionPropietario;

            //Mover el PUNTERO
            if (drPropietario.Read())
            {
                //Si existe la fila => leer el producto
                idPropietario = Convert.ToInt32(drPropietario["id"]);
                nombrePropietario = drPropietario["nombre"].ToString();
                apellidoPropietario = drPropietario["apellido"].ToString();
                dniPropietario = drPropietario["dni"].ToString();
                telefonoPropietario = drPropietario["telefono"].ToString();
                direccionPropietario = drPropietario["direccion"].ToString();

            }
            else
            {
                //Si NO existe la fila => creare un producto vacio
                idPropietario = 0;
                nombrePropietario = "";
                apellidoPropietario = "";
                dniPropietario = "";
                telefonoPropietario = "";
                direccionPropietario = "";
            }

            //Cerrar la conexion
            cnx.Close();

            //Utilizar la CapaEntidad
            //Asignar todos los valores en un ProductoCE
            //Instanciar la clase ProductoCE
            PropietarioCE propietarioCE = new PropietarioCE();
            //Asignar los valores a las propiedades
            propietarioCE.IdPropietario = idPropietario;
            propietarioCE.NombrePropietario = nombrePropietario;
            propietarioCE.ApellidoPropietario = apellidoPropietario;
            propietarioCE.DniPropietario = dniPropietario;
            propietarioCE.TelefonoPropietario = telefonoPropietario;
            propietarioCE.DireccionPropietario = direccionPropietario;

            //Retornar
            return propietarioCE;

        }

        public List<PropietarioCE> buscarByApellido(string desBuscar)
        {
            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = cnx.CreateCommand();
            //Definir el Tipo de comando
            cmd.CommandType = CommandType.Text;
            //Asignar al comando el SQL
            cmd.CommandText = "select * from propietario where apellido like '%' + @apellido + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@apellido", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drPropietario = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de ProductosCE
            List<PropietarioCE> listaPropietariosCE = new List<PropietarioCE>();

            //Mover el puntero de registro
            while (drPropietario.Read())
            {
                //Leer los valores de la fila
                int idPropietario = Convert.ToInt32(drPropietario["id"]);
                string nombrePropietario = drPropietario["nombre"].ToString();
                string apellidoPropietario = drPropietario["apellido"].ToString();
                string dniPropietario = drPropietario["dni"].ToString();
                string telefonoPropietario = drPropietario["telefono"].ToString();
                string direccionPropietario = drPropietario["direccion"].ToString();

                //Instanciar el ProductoCE
                PropietarioCE propietarioCE = new PropietarioCE();

                //Asignar los valores al ProductoCE
                propietarioCE.IdPropietario = idPropietario;
                propietarioCE.NombrePropietario = nombrePropietario;
                propietarioCE.ApellidoPropietario = apellidoPropietario;
                propietarioCE.DniPropietario = dniPropietario;
                propietarioCE.TelefonoPropietario = telefonoPropietario;
                propietarioCE.DireccionPropietario = direccionPropietario;


                //Guardar el producto en la coleccion
                listaPropietariosCE.Add(propietarioCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de ProductosCE
            return listaPropietariosCE;
        }

        public int insertar(PropietarioCE propietariosCE)
        {
            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = cnx.CreateCommand();
            //Definir el Tipo de comando
            cmd.CommandType = CommandType.Text;
            //Asignar al comando el SQLJHREJSURNJSHRIOS
            cmd.CommandText = "insert into propietario (nombre, apellido, dni, telefono, direccion) values (@nombre, @apellido, @dni, @telefono, @direccion)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@nombre", propietariosCE.NombrePropietario);
            cmd.Parameters.AddWithValue("@apellido", propietariosCE.ApellidoPropietario);
            cmd.Parameters.AddWithValue("@dni", propietariosCE.DniPropietario);
            cmd.Parameters.AddWithValue("@telefono", propietariosCE.TelefonoPropietario);
            cmd.Parameters.AddWithValue("@direccion", propietariosCE.DireccionPropietario);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from propietario where apellido=@apellido;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@apellido"].Value = propietariosCE.ApellidoPropietario;

                //ejecutar el comando
                SqlDataReader drPropietario = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drPropietario.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drPropietario["newId"]);
                }
                else
                {
                    //Si no hay nueva fila
                    nuevoId = 0;
                }

            }
            else
            {
                //Si no hay filas afectadas
                nuevoId = 0;
            }

            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nuevoId;

        }

        public int actualizar(PropietarioCE propietariosCE)
        {
            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = cnx.CreateCommand();
            //Definir el Tipo de comando
            cmd.CommandType = CommandType.Text;
            //Asignar al comando el SQL
            cmd.CommandText = "update propietario set nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, direccion=@direccion where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", propietariosCE.IdPropietario);
            cmd.Parameters.AddWithValue("@nombre", propietariosCE.NombrePropietario);
            cmd.Parameters.AddWithValue("@apellido", propietariosCE.ApellidoPropietario);
            cmd.Parameters.AddWithValue("@dni", propietariosCE.DniPropietario);
            cmd.Parameters.AddWithValue("@telefono", propietariosCE.TelefonoPropietario);
            cmd.Parameters.AddWithValue("@direccion", propietariosCE.DireccionPropietario);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE
            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nFilas;

        }

        public int eliminar(int idEliminar)
        {
            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = cnx.CreateCommand();
            //Definir el Tipo de comando
            cmd.CommandType = CommandType.Text;
            //Asignar al comando el SQL
            cmd.CommandText = "delete from propietario where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idEliminar);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE
            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nFilas;

        }
        //listar
        public DataTable listar()
        {


            //Crear la conexion
            SqlConnection cnx = ConexionCD.conectarToSqlServer();
            //Abrir la conexion
            cnx.Open();



            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("listar_propietario", cnx);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);

            cnx.Close();
            cnx.Dispose();
            return dt;



        }
    }
}
