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
    public class AtencionCD
    {
        public AtencionCE buscarById(int idBuscar)
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
            cmd.CommandText = "select * from atencion where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drAtencion = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int id;
            int idCita;
            string sintomas;
            string diagnostico;
            string tratamiento;

            //Mover el PUNTERO
            if (drAtencion.Read())
            {
                //Si existe la fila => leer el producto
                id = Convert.ToInt32(drAtencion["id"]);
                idCita = Convert.ToInt32(drAtencion["idCita"]);
                sintomas = drAtencion["sintomas"].ToString();
                diagnostico = drAtencion["diagnostico"].ToString();
                tratamiento = (drAtencion["tratamiento"].ToString());

            }
            else
            {
                //Si NO existe la fila => creare un producto vacio
                id = 0;
                idCita = 0;
                sintomas = "";
                diagnostico = "";
                tratamiento = "";
                
            }

            //Cerrar la conexion
            cnx.Close();

            //Utilizar la CapaEntidad
            //Asignar todos los valores en un ProductoCE
            //Instanciar la clase ProductoCE
            AtencionCE atencionCE = new AtencionCE();
            //Asignar los valores a las propiedades
            atencionCE.Id = id;
            atencionCE.IdCita = idCita;
            atencionCE.Sintomas = sintomas;
            atencionCE.Diagnostico = diagnostico;
            atencionCE.Tratamiento = tratamiento;

            //Retornar
            return atencionCE;

        }

        public List<AtencionCE> buscarByIdCita(string desBuscar)
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
            cmd.CommandText = "select * from atencion where idCita like '%' + @idCita + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@idCita", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drAtencion = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de ProductosCE
            List<AtencionCE> listaAtencionCE = new List<AtencionCE>();

            //Mover el puntero de registro
            while (drAtencion.Read())
            {
                //Leer los valores de la fila
                int id = Convert.ToInt32(drAtencion["id"]);
                int idCita = Convert.ToInt32(drAtencion["idCita"]);
                string sintomas = drAtencion["sintomas"].ToString();
                string diagnostico = drAtencion["diagnostico"].ToString();
                string tratamiento = drAtencion["tratamiento"].ToString();


                //Instanciar el ProductoCE
                AtencionCE atencionCE = new AtencionCE();

                //Asignar los valores al ProductoCE
                atencionCE.Id = id;
                atencionCE.IdCita = idCita;
                atencionCE.Sintomas = sintomas;
                atencionCE.Diagnostico = diagnostico;
                atencionCE.Tratamiento = tratamiento;

                //Guardar el producto en la coleccion
                listaAtencionCE.Add(atencionCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de ProductosCE
            return listaAtencionCE;
        }

        public int insertar(AtencionCE atencionCE)
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
            cmd.CommandText = "insert into atencion (idCita, sintomas, diagnostico, tratamiento) values (@idCita, @sintomas, @diagnostico, @tratamiento)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@idCita", atencionCE.IdCita);
            cmd.Parameters.AddWithValue("@sintomas", atencionCE.Sintomas);
            cmd.Parameters.AddWithValue("@diagnostico", atencionCE.Diagnostico);
            cmd.Parameters.AddWithValue("@tratamiento", atencionCE.Tratamiento);
            
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from atencion where sintomas=@sintomas;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@sintomas"].Value = atencionCE.Sintomas;

                //ejecutar el comando
                SqlDataReader drAtencion = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drAtencion.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drAtencion["newId"]);
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

        public int actualizar(AtencionCE atencionCE)
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
            cmd.CommandText = "update atencion set idCita=@idCita, sintomas=@sintomas, diagnostico=@diagnostico, tratamiento=@tratamiento where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", atencionCE.Id);
            cmd.Parameters.AddWithValue("@idCita", atencionCE.IdCita);
            cmd.Parameters.AddWithValue("@sintomas", atencionCE.Sintomas);
            cmd.Parameters.AddWithValue("@diagnostico", atencionCE.Diagnostico);
            cmd.Parameters.AddWithValue("@diagnostico", atencionCE.Tratamiento);
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
            cmd.CommandText = "delete from atencion where id=@id";
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
