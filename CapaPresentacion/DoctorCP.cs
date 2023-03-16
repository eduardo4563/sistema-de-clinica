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
    public partial class DoctorCP : Form
    {

        public static int id;

        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static DoctorCP instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static DoctorCP Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new DoctorCP();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public DoctorCP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            DoctorCN doctorCN = new DoctorCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<DoctorCE> listaDoctorCE = doctorCN.BuscarByApellido(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvDoctores.DataSource = listaDoctorCE;

            //Ajustar el ancho de las columnas del DGV
            dgvDoctores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvDoctores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count >= 1)
            {
                //Asignar la primera fila seleccionada a una variable
                DataGridViewRow filaSeleccionada = dgvDoctores.SelectedRows[0];
                //Leer los valores de la primera fila seleccionada [0]
                // y mostrar en los textbox
                txtIdDoctor.Text = filaSeleccionada.Cells["id"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["apellido"].Value.ToString();
                txtContraseña.Text = filaSeleccionada.Cells["contraseña"].Value.ToString();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdDoctor.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContraseña.Text = "";

            txtValorBuscado.Text = "";

            dgvDoctores.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int id = Convert.ToInt32(txtIdDoctor.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contraseña = txtContraseña.Text;

            //Instanciar un ProductoCE con sus valores
            DoctorCE doctorCE = new DoctorCE(id, nombre, apellido, contraseña);

            //Instanciar un ProductoCN
            DoctorCN doctorCN = new DoctorCN();

            //En funcion del ID
            if (id == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = doctorCN.Insertar(doctorCE);
                //Mostrar el nuevo ID
                txtIdDoctor.Text = nuevoId.ToString();
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
                int nFilas = doctorCN.Actualizar(doctorCE);
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
            int idEliminar = Convert.ToInt32(txtIdDoctor.Text);
            if (idEliminar > 0)
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    DoctorCN doctorCN = new DoctorCN();
                    int nFilas = doctorCN.Eliminar(idEliminar);
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
            id = Convert.ToInt32(dgvDoctores.SelectedCells[0].Value);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorCP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
