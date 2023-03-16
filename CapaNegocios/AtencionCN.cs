using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class AtencionCN
    {
        public AtencionCE BuscarById(int idBuscar)
        {
            //Instanciar la CapaDatos
            AtencionCD atencionCD = new AtencionCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            AtencionCE atencionCE = atencionCD.buscarById(idBuscar);
            //Retornar el resultado
            return atencionCE;
        }

        public List<AtencionCE> BuscarByIdCita(string desBuscada)
        {
            //Instanciar la CapaDatos
            AtencionCD atencionCD = new AtencionCD();

            //Declarar la coleccion de ProductoCE
            List<AtencionCE> listaAtencionCE = new List<AtencionCE>();

            //Condicion
            if (desBuscada.Length >= 1)
            {
                //Ejecuta el metodo que corresponde
                //y recibir el valor que retorna
                listaAtencionCE = atencionCD.buscarByIdCita(desBuscada);
            }
            else
            {
                //asignar NULO
                listaAtencionCE = null;
            }


            //Retornar el resultado
            return listaAtencionCE;
        }

        public int Insertar(AtencionCE atencionCE)
        {
            //Instanciar la CapaDatos
            AtencionCD atencionCD = new AtencionCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nuevoId = atencionCD.insertar(atencionCE);
            //Retornar el resultado
            return nuevoId;
        }

        public int Actualizar(AtencionCE atencionCE)
        {
            //Instanciar la CapaDatos
            AtencionCD atencionCD = new AtencionCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = atencionCD.actualizar(atencionCE);
            //Retornar el resultado
            return nFilas;
        }

        public int Eliminar(int idEliminar)
        {
            //Instanciar la CapaDatos
            AtencionCD atencionCD = new AtencionCD();
            //Ejecuta el metodo que corresponde
            //y recibir el valor que retorna
            int nFilas = atencionCD.eliminar(idEliminar);
            //Retornar el resultado
            return nFilas;
        }
    }
}
