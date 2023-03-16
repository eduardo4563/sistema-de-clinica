using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class CitasCN
    {
        //Metodos equivalentes a la CapaDatos
        public CitasCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            CitasCD citaCD = new CitasCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            CitasCE citaCE = citaCD.buscarById(idBuscar);
            //Retornar el resultado
            return citaCE;
        }

        public List<CitasCE> BuscarByFechaRegistro(string desBuscada)
        {
            //Instanciar la CapaDatos
            CitasCD citaCD = new CitasCD();

            //Declarar la coleccion de ProductoCE
            List<CitasCE> listaCitasCE = new List<CitasCE>();

            //Condicion
            if (desBuscada.Length >= 0)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaCitasCE = citaCD.buscarByFechaRegistro(desBuscada);
            }
            else
            {
                //asignar NULO
                listaCitasCE = null;
            }


            //Retornar el resultado
            return listaCitasCE;
        }

        public int Insertar(CitasCE citasCE)
        {
            //Instanciar la CapaDatos
            CitasCD citasCD = new CitasCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = citasCD.insertar(citasCE);
            //Retornar el resultado
            return nuevoId;
        }

        public int Actualizar(CitasCE citasCE)
        {
            //Instanciar la CapaDatos
            CitasCD citasCD = new CitasCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = citasCD.actualizar(citasCE);
            //Retornar el resultado
            return nFilas;
        }

        public int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            CitasCD citasCD = new CitasCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = citasCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
