using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class PropietarioCN
    {
        public PropietarioCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            PropietarioCD propietarioCD = new PropietarioCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            PropietarioCE propietarioCE = propietarioCD.buscarById(idBuscar);
            //Retornar el resultado
            return propietarioCE;
        }

        public List<PropietarioCE> BuscarByApellido(string desBuscada)
        {
            //Instanciar la CapaDatos
            PropietarioCD propietarioCD = new PropietarioCD();

            //Declarar la coleccion de ProductoCE
            List<PropietarioCE> listaPropietariosCE = new List<PropietarioCE>();

            //Condicion
            if (desBuscada.Length >= 2)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaPropietariosCE = propietarioCD.buscarByApellido(desBuscada);
            }
            else
            {
                //asignar NULO
                listaPropietariosCE = null;
            }


            //Retornar el resultado
            return listaPropietariosCE;
        }

        public int Insertar(PropietarioCE propietarioCE)
        {
            //Instanciar la CapaDatos
            PropietarioCD propietarioCD = new PropietarioCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = propietarioCD.insertar(propietarioCE);
            //Retornar el resultado
            return nuevoId;
        }

        public int Actualizar(PropietarioCE propietarioCE)
        {
            //Instanciar la CapaDatos
            PropietarioCD propietarioCD = new PropietarioCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = propietarioCD.actualizar(propietarioCE);
            //Retornar el resultado
            return nFilas;
        }

        public int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            PropietarioCD propietarioCD = new PropietarioCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = propietarioCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
