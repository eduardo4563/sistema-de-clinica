using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class DoctorCN
    {
        public DoctorCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            DoctorCD doctorCD = new DoctorCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            DoctorCE animalCE = doctorCD.buscarById(idBuscar);
            //Retornar el resultado
            return animalCE;
        }

        public List<DoctorCE> BuscarByApellido(string desBuscada)
        {
            //Instanciar la CapaDatos
            DoctorCD doctorCD = new DoctorCD();

            //Declarar la coleccion de ProductoCE
            List<DoctorCE> listaDoctorCE = new List<DoctorCE>();

            //Condicion
            if (desBuscada.Length >= 2)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaDoctorCE = doctorCD.buscarByApellido(desBuscada);
            }
            else
            {
                //asignar NULO
                listaDoctorCE = null;
            }


            //Retornar el resultado
            return listaDoctorCE;
        }

        public int Insertar(DoctorCE doctorCE)
        {
            //Instanciar la CapaDatos
            DoctorCD doctorCD = new DoctorCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = doctorCD.insertar(doctorCE);
            //Retornar el resultado
            return nuevoId;
        }

        public int Actualizar(DoctorCE doctorCE)
        {
            //Instanciar la CapaDatos
            DoctorCD doctorCD = new DoctorCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = doctorCD.actualizar(doctorCE);
            //Retornar el resultado
            return nFilas;
        }

        public int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            DoctorCD doctorCD = new DoctorCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = doctorCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
