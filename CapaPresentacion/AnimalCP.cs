using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class AnimalCP : Form
    {
        public static int id;

        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static AnimalCP instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static AnimalCP Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new AnimalCP();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public AnimalCP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            AnimalCN animalCN = new AnimalCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<AnimalCE> listaAnimalCE = animalCN.BuscarByEspecie(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvAnimales.DataSource = listaAnimalCE;

            //Ajustar el ancho de las columnas del DGV
            dgvAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void dgvAnimales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAnimales.SelectedRows.Count >= 1)
            {
                //Asignar la primera fila seleccionada a una variable
                DataGridViewRow filaSeleccionada = dgvAnimales.SelectedRows[0];
                //Leer los valores de la primera fila seleccionada [0]
                // y mostrar en los textbox
                txtIdAnimal.Text = filaSeleccionada.Cells["idAnimal"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombreAnimal"].Value.ToString();
                txtEspecieAnimal.Text = filaSeleccionada.Cells["especieAnimal"].Value.ToString();
                txtIdPropietario2.Text = filaSeleccionada.Cells["idPropietario"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Resetear los controles
            txtIdAnimal.Text = "0";
            txtNombre.Text = "";
            txtEspecieAnimal.Text = "";
            txtIdPropietario2.Text = "0";

            txtValorBuscado.Text = "";

            dgvAnimales.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int idAnimal = Convert.ToInt32(txtIdAnimal.Text);
            string nombreAnimal = txtNombre.Text;
            string especieAnimal = txtEspecieAnimal.Text;
            int idPropietario = Convert.ToInt32(txtIdPropietario2.Text);

            //Instanciar un ProductoCE con sus valores
            AnimalCE animalCE = new AnimalCE(idAnimal, nombreAnimal, especieAnimal, idPropietario);

            //Instanciar un ProductoCN
            AnimalCN animalCN = new AnimalCN();

            //En funcion del ID
            if (idAnimal == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = animalCN.Insertar(animalCE);
                //Mostrar el nuevo ID
                txtIdAnimal.Text = nuevoId.ToString();
                //Mensaje
                if (nuevoId > 0)
                {
                    //Ejecutar el metodo de busqueda
                    btnBuscar_Click(null, null);
                    //Mensaje
                    MessageBox.Show("Se ha guardado el nuevo registro.");
                }
                else
                {
                    //Mensaje
                    MessageBox.Show("Ocurrio un error! No se guardo el registro.");
                }

            }
            else
            {
                //FUNCION 2: ACTUALIZAR (EDICION)
                int nFilas = animalCN.Actualizar(animalCE);
                //Mensaje
                if (nFilas > 0)
                {
                    //Ejecutar el metodo de busqueda
                    btnBuscar_Click(null, null);
                    //Mensaje
                    MessageBox.Show("Se ha actualizado el registro.");
                }
                else
                {
                    //Mesaje
                    MessageBox.Show("Ocurrio un error! No se actualizo el registro.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Leer el id a eliminar
            int idEliminar = Convert.ToInt32(txtIdAnimal.Text);
            if (idEliminar > 0) 
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    AnimalCN animalCN = new AnimalCN();
                    int nFilas = animalCN.Eliminar(idEliminar);
                    if (nFilas > 0)
                    {
                        btnNuevo_Click(null, null);
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }

            }
            else
            {
                MessageBox.Show("No se puede eliminar el registro actual");
            }
        }

        private void arPropietario_Click(object sender, EventArgs e)
        {
            PropietarioCP propietarioCP = new PropietarioCP();
            propietarioCP.ShowDialog();

            txtIdPropietario2.Text = Convert.ToString(PropietarioCP.id);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvAnimales.SelectedCells[0].Value);
            this.Close();
        }
    }
}
