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
    public class RecepcionistaCD
    {
        public RecepcionistaCE buscarById(int idBuscar)
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
            cmd.CommandText = "select * from recepcionista where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drRecepcionista = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int id;
            string nombre;
            string apellido;
            string contraseña;

            //Mover el PUNTERO
            if (drRecepcionista.Read())
            {
                //Si existe la fila => leer el producto
                id = Convert.ToInt32(drRecepcionista["id"]);
                nombre = drRecepcionista["nombre"].ToString();
                apellido = drRecepcionista["apellido"].ToString();
                contraseña = drRecepcionista["pass"].ToString();

            }
            else
            {
                //Si NO existe la fila => creare un producto vacio
                id = 0;
                nombre = "";
                apellido = "";
                contraseña = "";
            }

            //Cerrar la conexion
            cnx.Close();

            //Utilizar la CapaEntidad
            //Asignar todos los valores en un RecepcionistaCE
            //Instanciar la clase RecepcionistaCE
            RecepcionistaCE RecepCE = new RecepcionistaCE();
            //Asignar los valores a las propiedades
            RecepCE.Id = id;
            RecepCE.Nombre = nombre;
            RecepCE.Apellido = apellido;
            RecepCE.Contraseña = contraseña;

            //Retornar
            return RecepCE;

        }

        public List<RecepcionistaCE> buscarByApellido(string desBuscar)
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
            cmd.CommandText = "select * from recepcionista where apellido like '%' + @apellido + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@apellido", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drRecepcionista = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de RecepcionistaCE
            List<RecepcionistaCE> listaRecepcionistaCE = new List<RecepcionistaCE>();

            //Mover el puntero de registro
            while (drRecepcionista.Read())
            {
                //Leer los valores de la fila
                int id = Convert.ToInt32(drRecepcionista["id"]);
                string nombre = drRecepcionista["nombre"].ToString();
                string apellido = drRecepcionista["apellido"].ToString();
                string turno = drRecepcionista["turno"].ToString();
                string contraseña = drRecepcionista["pass"].ToString();

                //Instanciar el RecepcionistaCE
                RecepcionistaCE recepcionistaCE = new RecepcionistaCE();

                //Asignar los valores al RecepcionistaCE
                recepcionistaCE.Id = id;
                recepcionistaCE.Nombre = nombre;
                recepcionistaCE.Apellido = apellido;
                recepcionistaCE.Turno = turno;
                recepcionistaCE.Contraseña = contraseña;


                //Guardar el producto en la coleccion
                listaRecepcionistaCE.Add(recepcionistaCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de RecepcionistaCE
            return listaRecepcionistaCE;
        }

        public int insertar(RecepcionistaCE recepcionistaCE)
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
            cmd.CommandText = "insert into recepcionista (nombre, apellido,turno, pass) values (@nombre, @apellido,@turno, @pass)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@nombre", recepcionistaCE.Nombre);
            cmd.Parameters.AddWithValue("@apellido", recepcionistaCE.Apellido);
            cmd.Parameters.AddWithValue("@turno", recepcionistaCE.Turno);
            cmd.Parameters.AddWithValue("@pass", recepcionistaCE.Contraseña);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from recepcionista where apellido=@apellido;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@apellido"].Value = recepcionistaCE.Apellido;

                //ejecutar el comando
                SqlDataReader drRecepcionista = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drRecepcionista.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drRecepcionista["newId"]);
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

        public static int actualizar(RecepcionistaCE recepcionistaCE)
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
            cmd.CommandText = "update recepcionista set nombre=@nombre, apellido=@apellido,turno=@turno,pass=@pass where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", recepcionistaCE.Id);
            cmd.Parameters.AddWithValue("@nombre", recepcionistaCE.Nombre);
            cmd.Parameters.AddWithValue("@apellido", recepcionistaCE.Apellido);
            cmd.Parameters.AddWithValue("@turno", recepcionistaCE.Turno);
            cmd.Parameters.AddWithValue("@pass", recepcionistaCE.Contraseña);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE
            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nFilas;
        }

        public static int eliminar(int idEliminar)
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
            cmd.CommandText = "delete from recepcionista where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idEliminar);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE
            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nFilas;
        }
    }
}
