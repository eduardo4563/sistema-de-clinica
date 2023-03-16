using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PropietarioCE
    {
        //Propiedad
        private int idPropietario;
        private string nombrePropietario;
        private string apellidoPropietario;
        private string dniPropietario;
        private string telefonoPropietario;
        private string direccionPropietario;

        //Encapsular
        public int IdPropietario
        {
            get { return idPropietario; }
            set { idPropietario = value; }
        }

        public string NombrePropietario
        {
            get { return nombrePropietario; }
            set { nombrePropietario = value; }
        }

        public string ApellidoPropietario
        {
            get { return apellidoPropietario; }
            set { apellidoPropietario = value; }
        }

        public string DniPropietario
        {
            get { return dniPropietario; }
            set { dniPropietario = value; }
        }

        public string TelefonoPropietario
        {
            get { return telefonoPropietario; }
            set { telefonoPropietario = value; }
        }

        public string DireccionPropietario
        {
            get { return direccionPropietario; }
            set { direccionPropietario = value; }
        }

        //Constructores
        public PropietarioCE() { }

        public PropietarioCE(int vIdPropietario, string vNombrePropietario, string vApellidoPropietario, string vDniPropietario, string vTelefonoPropietario, string vDireccionPropietario)
        {
            this.idPropietario = vIdPropietario;
            this.nombrePropietario = vNombrePropietario;
            this.apellidoPropietario = vApellidoPropietario;
            this.dniPropietario = vDniPropietario;
            this.telefonoPropietario = vTelefonoPropietario;
            this.direccionPropietario = vDireccionPropietario;
        }
    }
}
