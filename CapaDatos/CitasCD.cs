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
    public class CitasCD
    {
        public CitasCE buscarById(int idBuscar)
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
            cmd.CommandText = "select * from cita where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drCitas = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int idCita;
            string fechaRegistro;
            string fechaCita;
            string horaCita;
            int idAnimal;
            int idRecepcionista;
            int idDoctor;

            //Mover el PUNTERO
            if (drCitas.Read())
            {
                //Si existe la fila => leer el producto
                idCita = Convert.ToInt32(drCitas["id"]);
                fechaRegistro = drCitas["fechaRegistro"].ToString();
                fechaCita = drCitas["fechaCita"].ToString();
                horaCita = drCitas["horaCita"].ToString();
                idAnimal = Convert.ToInt32(drCitas["idAnimal"]);
                idRecepcionista = Convert.ToInt32(drCitas["idRecepcionista"]);
                idDoctor = Convert.ToInt32(drCitas["idDoctor"]);

            }
            else
            {
                //Si NO existe la fila => creare un producto vacio
                idCita = 0;
                fechaRegistro = "";
                fechaCita = "";
                horaCita = "";
                idAnimal = 0;
                idRecepcionista = 0;
                idDoctor = 0;
            }

            //Cerrar la conexion
            cnx.Close();

            //Utilizar la CapaEntidad
            //Asignar todos los valores en un ProductoCE
            //Instanciar la clase ProductoCE
            CitasCE citaCE = new CitasCE();
            //Asignar los valores a las propiedades
            citaCE.IdCita = idCita;
            citaCE.FechaRegistro = fechaRegistro;
            citaCE.FechaCita = fechaCita;
            citaCE.HoraCita = horaCita;
            citaCE.IdAnimal = idAnimal;
            citaCE.IdRecepcionista = idRecepcionista;
            citaCE.IdDoctor = idDoctor;

            //Retornar
            return citaCE;

        }

        public List<CitasCE> buscarByFechaRegistro(string desBuscar)
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
            cmd.CommandText = "select * from cita where fechaRegistro like '%' + @fechaRegistro + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@fechaRegistro", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drCitas = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de ProductosCE
            List<CitasCE> listaCitasCE = new List<CitasCE>();

            //Mover el puntero de registro
            while (drCitas.Read())
            {
                //Leer los valores de la dr
                int idCita = Convert.ToInt32(drCitas["id"]);
                string fechaRegistro = drCitas["fechaRegistro"].ToString();
                string fechaCita = drCitas["fechaCita"].ToString();
                string horaCita = drCitas["horaCita"].ToString();
                int idAnimal = Convert.ToInt32(drCitas["idAnimal"]);
                int idRecepcionista = Convert.ToInt32(drCitas["idRecepcionista"]);
                int idDoctor = Convert.ToInt32(drCitas["idDoctor"]); ;

                //Instanciar el ProductoCE
                CitasCE citaCE = new CitasCE();

                //Asignar los valores al ProductoCE
                citaCE.IdCita = idCita;
                citaCE.FechaRegistro = fechaRegistro;
                citaCE.FechaCita = fechaCita;
                citaCE.HoraCita = horaCita;
                citaCE.IdAnimal = idAnimal;
                citaCE.IdRecepcionista = idRecepcionista;
                citaCE.IdDoctor = idDoctor;


                //Guardar el producto en la coleccion
                listaCitasCE.Add(citaCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de ProductosCE
            return listaCitasCE;
        }

        public int insertar(CitasCE citaCE)
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
            cmd.CommandText = "insert into cita (fechaRegistro, fechaCita, horaCita, idAnimal, idRecepcionista, idDoctor) values (@fechaRegistro, @fechaCita, @horaCita, @idAnimal, @idRecepcionista, @idDoctor)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@fechaRegistro", citaCE.FechaRegistro);
            cmd.Parameters.AddWithValue("@fechaCita", citaCE.FechaCita);
            cmd.Parameters.AddWithValue("@horaCita", citaCE.HoraCita);
            cmd.Parameters.AddWithValue("@idAnimal", citaCE.IdAnimal);
            cmd.Parameters.AddWithValue("@idRecepcionista", citaCE.IdRecepcionista);
            cmd.Parameters.AddWithValue("@idDoctor", citaCE.IdDoctor);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from cita where fechaRegistro=@fechaRegistro;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@fechaRegistro"].Value = citaCE.FechaRegistro;

                //ejecutar el comando
                SqlDataReader drCitas = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drCitas.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drCitas["newId"]);
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

        public int actualizar(CitasCE citaCE)
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
            cmd.CommandText = "update cita set fechaRegistro=@fechaRegistro, fechaCita=@fechaCita, horaCita=@horaCita, idAnimal=@idAnimal, idRecepcionista=@idRecepcionista, idDoctor=@idDoctor where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", citaCE.IdCita);
            cmd.Parameters.AddWithValue("@fechaRegistro", citaCE.FechaRegistro);
            cmd.Parameters.AddWithValue("@fechaCita", citaCE.FechaCita);
            cmd.Parameters.AddWithValue("@horaCita", citaCE.HoraCita);
            cmd.Parameters.AddWithValue("@idAnimal", citaCE.IdAnimal);
            cmd.Parameters.AddWithValue("@idRecepcionista", citaCE.IdRecepcionista);
            cmd.Parameters.AddWithValue("@idDoctor", citaCE.IdDoctor);
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
            cmd.CommandText = "delete from cita where id=@id";
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
