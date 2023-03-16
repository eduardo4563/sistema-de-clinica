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
    public partial class CitasCP : Form
    {
        public static int id;

        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static CitasCP instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static CitasCP Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new CitasCP();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public CitasCP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            CitasCN citasCN = new CitasCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<CitasCE> listaCitasCE = citasCN.BuscarByFechaRegistro(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvCitas.DataSource = listaCitasCE;

            //Ajustar el ancho de las columnas del DGV
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            AnimalCP animalCP = new AnimalCP();
            animalCP.ShowDialog();

            txtIdAnimal.Text = Convert.ToString(AnimalCP.id);
        }

        private void btnBuscarRecepcionista_Click(object sender, EventArgs e)
        {
            RecepcionistaCP recepcionistaCP = new RecepcionistaCP();
            recepcionistaCP.ShowDialog();

            txtIdRecepcionista.Text = Convert.ToString(RecepcionistaCP.id);
        }

        private void btnBuscarDoctor_Click(object sender, EventArgs e)
        {
            DoctorCP doctorCP = new DoctorCP();
            doctorCP.ShowDialog();

            txtIdDoctor.Text = Convert.ToString(DoctorCP.id);
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count >= 1)
            { 
                //Asignar la primera fila seleccionada a una variable
                DataGridViewRow filaSeleccionada = dgvCitas.SelectedRows[0];
                //Leer los valores de la primera fila seleccionada [0]
                // y mostrar en los textbox
                txtIdCita.Text = filaSeleccionada.Cells["idCita"].Value.ToString();
                txtFechaRegistro.Text = filaSeleccionada.Cells["fechaRegistro"].Value.ToString();
                txtFechaCita.Text = filaSeleccionada.Cells["fechaCita"].Value.ToString();
                txtHoraCita.Text = filaSeleccionada.Cells["HoraCita"].Value.ToString();
                txtIdAnimal.Text = filaSeleccionada.Cells["idAnimal"].Value.ToString();
                txtIdRecepcionista.Text = filaSeleccionada.Cells["idRecepcionista"].Value.ToString();
                txtIdDoctor.Text = filaSeleccionada.Cells["idDoctor"].Value.ToString();
            }   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Resetear los controles
            txtIdCita.Text = "0";
            txtFechaRegistro.Text = "";
            txtFechaCita.Text = "";
            txtHoraCita.Text = "";
            txtIdAnimal.Text = "0";
            txtIdRecepcionista.Text = "0";
            txtIdDoctor.Text = "0";

            txtValorBuscado.Text = "";

            dgvCitas.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int idCita = Convert.ToInt32(txtIdCita.Text);
            string fechaRegistro = txtFechaRegistro.Text;
            string fechaCita = txtFechaCita.Text;
            string horaCita = txtHoraCita.Text;
            int idAnimal = Convert.ToInt32(txtIdAnimal.Text);
            int idRecepcionista = Convert.ToInt32(txtIdRecepcionista.Text);
            int idDoctor = Convert.ToInt32(txtIdDoctor.Text);

            //Instanciar un ProductoCE con sus valores
            CitasCE citasCE = new CitasCE(idCita, idAnimal, idRecepcionista, idDoctor, fechaRegistro, fechaCita, horaCita);

            //Instanciar un ProductoCN
            CitasCN citasCN = new CitasCN();

            //En funcion del ID
            if (idCita == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = citasCN.Insertar(citasCE);
                //Mostrar el nuevo ID
                txtIdCita.Text = nuevoId.ToString();
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
                int nFilas = citasCN.Actualizar(citasCE);
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
            int idEliminar = Convert.ToInt32(txtIdCita.Text);
            if (idEliminar > 0)
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    CitasCN citasCN = new CitasCN();
                    int nFilas = citasCN.Eliminar(idEliminar);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvCitas.SelectedCells[0].Value);
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
