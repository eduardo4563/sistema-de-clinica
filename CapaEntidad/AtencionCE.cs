using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AtencionCE
    {
        //Propiedad
        private int id;
        private int idCita;
        private string sintomas;
        private string diagnostico;
        private string tratamiento;
        
        //Encapsular
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdCita
        {
            get { return idCita; }
            set { idCita = value; }
        }

        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }

        //Constructores
        public AtencionCE() { }

        public AtencionCE(int vId, int vIdCita, string vSintomas, string vDiagnostico, string vTratamiento)
        {
            this.id = vId;
            this.idCita = vIdCita;
            this.diagnostico = vDiagnostico;
            this.sintomas = vSintomas;
            this.tratamiento = vTratamiento;
        }
    }
}
