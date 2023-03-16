using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CitasCE
    {
        //Propiedad
        private int idCita;
        private int idAnimal;
        private int idRecepcionista;
        private int idDoctor;
        private string fechaRegistro;
        private string fechaCita;
        private string horaCita;

        //Encapsular
        public int IdCita
        {
            get { return idCita; }
            set {  idCita = value; }
        }

        public int IdAnimal
        {
            get { return idAnimal; }
            set { idAnimal = value; }
        }

        public int IdRecepcionista
        {
            get { return idRecepcionista; }
            set { idRecepcionista = value; }
        }

        public int IdDoctor
        {
            get { return idDoctor; }
            set { idDoctor = value; }
        }

        public string FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public string FechaCita
        {
            get { return fechaCita; }
            set { fechaCita = value; }
        }

        public string HoraCita
        {
            get { return horaCita; }
            set { horaCita = value; }
        }

        //Constructores
        public CitasCE() { }

        public CitasCE(int vIdCita, int vIdAnimal, int vIdRecepcionista, int vIdDoctor, string vFechaRegistro, string vFechaCita, string vHoraCita)
        {
            this.idCita = vIdCita;
            this.idAnimal = vIdAnimal;
            this.idRecepcionista = vIdRecepcionista;
            this.idDoctor = vIdDoctor;
            this.fechaRegistro = vFechaRegistro;
            this.fechaCita = vFechaCita;
            this.horaCita = vHoraCita;
        }
    }
}
