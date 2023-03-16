using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class RecepcionistaCN
    {
        public static RecepcionistaCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            RecepcionistaCD recepcionistaCD = new RecepcionistaCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            RecepcionistaCE recepcionistaCE = recepcionistaCD.buscarById(idBuscar);
            //Retornar el resultado
            return recepcionistaCE;
        }

        public static List<RecepcionistaCE> BuscarByApellido(string desBuscada)
        {
            //Instanciar la CapaDatos
            RecepcionistaCD recepcionistaCD = new RecepcionistaCD();

            //Declarar la coleccion de ProductoCE
            List<RecepcionistaCE> listaRecepcionistaCE = new List<RecepcionistaCE>();

            //Condicion
            if (desBuscada.Length >= 2)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaRecepcionistaCE = recepcionistaCD.buscarByApellido(desBuscada);
            }
            else
            {
                //asignar NULO
                listaRecepcionistaCE = null;
            }


            //Retornar el resultado
            return listaRecepcionistaCE;
        }

        public static int Insertar(RecepcionistaCE recepcionistaCE)
        {
            //Instanciar la CapaDatos
            RecepcionistaCD recepcionistaCD = new RecepcionistaCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = recepcionistaCD.insertar(recepcionistaCE);
            //Retornar el resultado
            return nuevoId;
        }

        public static int Actualizar(RecepcionistaCE recepcionistaCE)
        {
            //Instanciar la CapaDatos
            RecepcionistaCD recepcionistaCD = new RecepcionistaCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = RecepcionistaCD.actualizar(recepcionistaCE);
            //Retornar el resultado
            return nFilas;
        }

        public static int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            RecepcionistaCD recepcionistaCD = new RecepcionistaCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = RecepcionistaCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
