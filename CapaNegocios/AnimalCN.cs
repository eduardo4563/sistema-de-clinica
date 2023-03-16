using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class AnimalCN
    {
        public AnimalCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            AnimalCD animalCD = new AnimalCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            AnimalCE animalCE = animalCD.buscarById(idBuscar);
            //Retornar el resultado
            return animalCE;
        }

        public List<AnimalCE> BuscarByEspecie(string desBuscada)
        {
            //Instanciar la CapaDatos
            AnimalCD animalCD = new AnimalCD();

            //Declarar la coleccion de ProductoCE
            List<AnimalCE> listaAnimalCE = new List<AnimalCE>();

            //Condicion
            if (desBuscada.Length >= 1)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaAnimalCE = animalCD.buscarByEspecie(desBuscada);
            }
            else
            {
                //asignar NULO
                listaAnimalCE = null;
            }


            //Retornar el resultado
            return listaAnimalCE;
        }

        public int Insertar(AnimalCE animalCE)
        {
            //Instanciar la CapaDatos
            AnimalCD animalCD = new AnimalCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = animalCD.insertar(animalCE);
            //Retornar el resultado
            return nuevoId;
        }

        public int Actualizar(AnimalCE animalCE)
        {
            //Instanciar la CapaDatos
            AnimalCD animalCD = new AnimalCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = animalCD.actualizar(animalCE);
            //Retornar el resultado
            return nFilas;
        }

        public int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            AnimalCD animalCD = new AnimalCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = animalCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
