using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RecepcionistaCE
    {
        private int id;
        private string nombre;
        private string apellido;
        private string turno;
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

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }


        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        //Constructores
        public RecepcionistaCE() { }

        public RecepcionistaCE(int vId, string vNombre, string vApellido, string vTurno, string vContraseña)
        {
            this.Id = vId;
            this.Nombre = vNombre;
            this.Apellido = vApellido;
            this.Turno = vTurno;
            this.Contraseña = vContraseña;
        }
    }
}
