using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DoctorCE
    {
        private int id;
        private string nombre;
        private string apellido;
        private string contraseña;

        //Encapsular
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        //Constructores
        public DoctorCE() { }

        public DoctorCE(int vId, string vNombre, string vApellido, string vContraseña)
        {
            this.Id = vId;
            this.Nombre = vNombre;
            this.Apellido = vApellido;
            this.Contraseña = vContraseña;
        }
    }
}
