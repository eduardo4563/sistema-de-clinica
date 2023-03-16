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
    public partial class PropietarioCP : Form
    {

        public static int id;

        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static PropietarioCP instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static PropietarioCP Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new PropietarioCP();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public PropietarioCP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            PropietarioCN propietarioCN = new PropietarioCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<PropietarioCE> listaPropietariosCE = propietarioCN.BuscarByApellido(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvPropietarios.DataSource = listaPropietariosCE;

            //Ajustar el ancho de las columnas del DGV
            dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPropietarios.SelectedRows.Count >= 1)
            {
                //Asignar la primera fila seleccionada a una variable
                DataGridViewRow filaSeleccionada = dgvPropietarios.SelectedRows[0];
                //Leer los valores de la primera fila seleccionada [0]
                // y mostrar en los textbox
                txtIdPropietario.Text = filaSeleccionada.Cells["idPropietario"].Value.ToString();
                txtNombrePropietario.Text = filaSeleccionada.Cells["nombrePropietario"].Value.ToString();
                txtApellidoPropietario.Text = filaSeleccionada.Cells["apellidoPropietario"].Value.ToString();
                txtDniPropietario.Text = filaSeleccionada.Cells["dniPropietario"].Value.ToString();
                txtTelefonoPropietario.Text = filaSeleccionada.Cells["telefonoPropietario"].Value.ToString();
                txtDireccionPropietario.Text = filaSeleccionada.Cells["direccionPropietario"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Resetear los controles
            txtIdPropietario.Text = "0";
            txtNombrePropietario.Text = "";
            txtApellidoPropietario.Text = "";
            txtDniPropietario.Text = "";
            txtTelefonoPropietario.Text = "";
            txtDireccionPropietario.Text = "";

            txtValorBuscado.Text = "";

            dgvPropietarios.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int idPropietario = Convert.ToInt32(txtIdPropietario.Text);
            string nombrePropietario = txtNombrePropietario.Text;
            string apellidoPropietario = txtApellidoPropietario.Text;
            string dniPropietario = txtDniPropietario.Text;
            string telefonoPropietario = txtTelefonoPropietario.Text;
            string direccionPropietario = txtDireccionPropietario.Text;

            //Instanciar un ProductoCE con sus valores
            PropietarioCE propietarioCE = new PropietarioCE(idPropietario, nombrePropietario, apellidoPropietario, dniPropietario, telefonoPropietario,direccionPropietario);

            //Instanciar un ProductoCN
            PropietarioCN propietarioCN = new PropietarioCN();

            //En funcion del ID
            if (idPropietario == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = propietarioCN.Insertar(propietarioCE);
                //Mostrar el nuevo ID
                txtIdPropietario.Text = nuevoId.ToString();
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
                int nFilas = propietarioCN.Actualizar(propietarioCE);
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
            int idEliminar = Convert.ToInt32(txtIdPropietario.Text);
            if (idEliminar > 0)
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    PropietarioCN propietarioCN = new PropietarioCN ();
                    int nFilas = propietarioCN.Eliminar(idEliminar);
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
            id = Convert.ToInt32(dgvPropietarios.SelectedCells[0].Value);
            this.Close();
        }
    }
}
