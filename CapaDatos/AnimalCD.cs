using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using CapaEntidad;
using System.Data.Common;

namespace CapaDatos
{
    public class AnimalCD
    {
        public AnimalCE buscarById(int idBuscar)
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
            cmd.CommandText = "select * from animal where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drAnimal = cmd.ExecuteReader(); //SELECT

            //Declarar variables
            int idAnimal;
            string nombreAnimal;
            string especieAnimal;
            int idPropietario;

            //Mover el PUNTERO
            if (drAnimal.Read())
            {
                //Si existe la fila => leer el producto
                idAnimal = Convert.ToInt32(drAnimal["id"]);
                nombreAnimal = drAnimal["nombre"].ToString();
                especieAnimal = drAnimal["especio"].ToString();
                idPropietario = Convert.ToInt32(drAnimal["idPropietario"]);

            }
            else
            {
                //Si NO existe la fila => creare un producto vacio
                idAnimal = 0;
                nombreAnimal = "";
                especieAnimal = "";
                idPropietario = 0;
            }

            //Cerrar la conexion
            cnx.Close();

            //Utilizar la CapaEntidad
            //Asignar todos los valores en un ProductoCE
            //Instanciar la clase ProductoCE
            AnimalCE animalCE = new AnimalCE();
            //Asignar los valores a las propiedades
            animalCE.IdAnimal = idAnimal;
            animalCE.NombreAnimal = nombreAnimal;
            animalCE.EspecieAnimal = especieAnimal;
            animalCE.IdPropietario = idPropietario;

            //Retornar
            return animalCE;

        }

        public List<AnimalCE> buscarByEspecie(string desBuscar)
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
            cmd.CommandText = "select * from animal where especio like '%' + @especio + '%';";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@especio", desBuscar);
            //Ejecutar el comando y guardar el resultado
            SqlDataReader drAnimal = cmd.ExecuteReader(); //SELECT

            //Declarar la coleccion List de ProductosCE
            List<AnimalCE> listaAnimalCE = new List<AnimalCE>();

            //Mover el puntero de registro
            while (drAnimal.Read())
            {
                //Leer los valores de la fila
                int idAnimal = Convert.ToInt32(drAnimal["id"]);
                string nombreAnimal = drAnimal["nombre"].ToString();
                string especieAnimal = drAnimal["especio"].ToString();
                int idPropietario = Convert.ToInt32(drAnimal["idPropietario"]);

                //Instanciar el ProductoCE
                AnimalCE animalCE = new AnimalCE();

                //Asignar los valores al ProductoCE
                animalCE.IdAnimal = idAnimal;
                animalCE.NombreAnimal = nombreAnimal;
                animalCE.EspecieAnimal = especieAnimal;
                animalCE.IdPropietario = idPropietario;


                //Guardar el producto en la coleccion
                listaAnimalCE.Add(animalCE);
            }
            //Cerrar la conexion
            cnx.Close();

            //Retornar la coleccion de ProductosCE
            return listaAnimalCE;
        }

        public int insertar(AnimalCE animalCE)
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
            cmd.CommandText = "insert into animal (nombre, especio, idPropietario) values (@nombre, @especio, @idPropietario)";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@nombre", animalCE.NombreAnimal);
            cmd.Parameters.AddWithValue("@especio", animalCE.EspecieAnimal);
            cmd.Parameters.AddWithValue("@idPropietario", animalCE.IdPropietario);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE

            // -- RECUPERAR EL NUEVO ID GENERADO --
            //Declarar la variable para el nuevo Id
            int nuevoId;

            if (nFilas > 0)
            {
                //Asignar un SQL al comando
                cmd.CommandText = "select max(id) as newId from animal where nombre=@nombre;";

                //Asignar el valor al parametro que ya existe
                cmd.Parameters["@nombre"].Value = animalCE.NombreAnimal;

                //ejecutar el comando
                SqlDataReader drAnimal = cmd.ExecuteReader(); // SELECT

                //Mover el puntero
                if (drAnimal.Read())
                {
                    //Leer el nuevo id
                    nuevoId = Convert.ToInt32(drAnimal["newId"]);
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

        public int actualizar(AnimalCE animalCE)
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
            cmd.CommandText = "update animal set nombre=@nombre, especio=@especio, idPropietario=@idPropietario where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", animalCE.IdAnimal);
            cmd.Parameters.AddWithValue("@nombre", animalCE.NombreAnimal);
            cmd.Parameters.AddWithValue("@especio", animalCE.EspecieAnimal);
            cmd.Parameters.AddWithValue("@idPropietario", animalCE.IdPropietario);
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
            cmd.CommandText = "delete from animal where id=@id";
            //Asignar un valor al parametro
            cmd.Parameters.AddWithValue("@id", idEliminar);
            //Ejecutar el comando
            int nFilas = cmd.ExecuteNonQuery(); // INSERT - UPDATE -DELETE
            //Cerrar la conexion
            cnx.Close();
            //Retornar la cantidad de filas afectadas
            return nFilas;
        }
        //listar tabla
        
    }
}
