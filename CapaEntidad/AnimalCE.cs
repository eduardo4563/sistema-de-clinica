using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AnimalCE
    {
        //Propiedad
        private int idAnimal;
        private string nombreAnimal;
        private string especieAnimal;
        private int idPropietario;

        //Encapsular
        public int IdAnimal
        {
            get { return idAnimal; }
            set { idAnimal = value; }
        }

        public string NombreAnimal
        {
            get { return nombreAnimal; }
            set { nombreAnimal = value; }
        }

        public string EspecieAnimal
        {
            get { return especieAnimal; }
            set { especieAnimal = value; }
        }

        public int IdPropietario
        {
            get { return idPropietario; }
            set { idPropietario = value; }
        }

        //Constructores
        public AnimalCE() { }

        public AnimalCE(int vIdAnimal, string vNombreAnimal, string vEspecieAnimal, int vIdPropietario)
        {
            this.idAnimal = vIdAnimal;
            this.nombreAnimal = vNombreAnimal;
            this.especieAnimal = vEspecieAnimal;
            this.idPropietario = vIdPropietario;
        }
    }
}
