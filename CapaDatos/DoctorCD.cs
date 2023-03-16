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
    public class DoctorCD
    {
        public DoctorCE buscarById(int idBuscar)
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
            cmd.CommandText = "select * from doctor where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drDoctor = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int id;
            string nombre;
            string apellido;
            string contraseña;

            //Mover el PUNTERO
            if (drDoctor.Read())
            {
                //Si existe la fila => leer el producto
                id = Convert.ToInt32(drDoctor["id"]);
                nombre = drDoctor["nombre"].ToString();
                apellido = drDoctor["apellido"].ToString();
                contraseña = drDoctor["pass"].ToString();

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
            //Asignar todos los valores en un DoctorCE
            //Instanciar la clase DocotrCE
            DoctorCE doctorCE = new DoctorCE();
            //Asignar los valores a las propiedades
            doctorCE.Id = id;
            doctorCE.Nombre = nombre;
            doctorCE.Apellido = apellido;
            doctorCE.Contraseña = contraseña;

            //Retornar
            return doctorCE;

        }

        public List<DoctorCE> buscarByApellido(string desBuscar)
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
            cmd.CommandText = "select * from doctor where apellido like '%' + @apellido + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@apellido", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drDoctor = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de ProductosCE
            List<DoctorCE> listaDoctorCE = new List<DoctorCE>();

            //Mover el puntero de registro
            while (drDoctor.Read())
            {
                //Leer los valores de la fila
                int id = Convert.ToInt32(drDoctor["id"]);
                string nombre = drDoctor["nombre"].ToString();
                string apellido = drDoctor["apellido"].ToString();
                string contraseña = drDoctor["pass"].ToString();

                //Instanciar el ProductoCE
                DoctorCE doctorCE = new DoctorCE();

                //Asignar los valores al ProductoCE
                doctorCE.Id = id;
                doctorCE.Nombre = nombre;
                doctorCE.Apellido = apellido;
                doctorCE.Contraseña = contraseña;


                //Guardar el producto en la coleccion
                listaDoctorCE.Add(doctorCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de ProductosCE
            return listaDoctorCE;
        }

        public int insertar(DoctorCE doctorCE)
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
            cmd.CommandText = "insert into doctor (nombre, apellido,pass) values (@nombre, @apellido, @pass)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@nombre", doctorCE.Nombre);
            cmd.Parameters.AddWithValue("@apellido", doctorCE.Apellido);
            cmd.Parameters.AddWithValue("@pass", doctorCE.Contraseña);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from doctor where nombre=@nombre;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@nombre"].Value = doctorCE.Nombre;

                //ejecutar el comando
                SqlDataReader drDoctor = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drDoctor.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drDoctor["newId"]);
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

        public int actualizar(DoctorCE doctorCE)
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
            cmd.CommandText = "update doctor set nombre=@nombre, apellido=@apellido,pass=@pass where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", doctorCE.Id);
            cmd.Parameters.AddWithValue("@nombre", doctorCE.Nombre);
            cmd.Parameters.AddWithValue("@apellido", doctorCE.Apellido);
            cmd.Parameters.AddWithValue("@pass", doctorCE.Contraseña);
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
            cmd.CommandText = "delete from doctor where id=@id";
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
