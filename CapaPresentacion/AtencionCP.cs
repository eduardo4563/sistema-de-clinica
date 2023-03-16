using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class AtencionCP : Form
    {
        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static AtencionCP instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static AtencionCP Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new AtencionCP();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public AtencionCP()
        {
            InitializeComponent();
        }

        private void AtencionCP_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            CitasCP citasCP = new CitasCP();
            citasCP.ShowDialog();

            txtIdCita.Text = Convert.ToString(CitasCP.id);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            AtencionCN atencionCN = new AtencionCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<AtencionCE> listaAtencionCE = atencionCN.BuscarByIdCita(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvAtencion.DataSource = listaAtencionCE;

            //Ajustar el ancho de las columnas del DGV
            dgvAtencion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvAtencion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAtencion.SelectedRows.Count >= 1)
            {
                //Asignar la primera fila seleccionada a una variable
                DataGridViewRow filaSeleccionada = dgvAtencion.SelectedRows[0];
                //Leer los valores de la primera fila seleccionada [0]
                // y mostrar en los textbox
                txtIdAtencion.Text = filaSeleccionada.Cells["id"].Value.ToString();
                txtIdCita.Text = filaSeleccionada.Cells["idCita"].Value.ToString();
                txtSintomas.Text = filaSeleccionada.Cells["sintomas"].Value.ToString();
                txtDiagnostico.Text = filaSeleccionada.Cells["diagnostico"].Value.ToString();
                txtTratamiento.Text = filaSeleccionada.Cells["tratamiento"].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Resetear los controles
            txtIdAtencion.Text = "0";
            txtIdCita.Text = "0";
            txtSintomas.Text = "";
            txtDiagnostico.Text = "";
            txtTratamiento.Text = "";
            
            txtValorBuscado.Text = "";

            dgvAtencion.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int id = Convert.ToInt32(txtIdAtencion.Text);
            int idCita = Convert.ToInt32(txtIdCita.Text);
            string sintomas = txtSintomas.Text;
            string diagnostico = txtDiagnostico.Text;
            string tratamiento = txtTratamiento.Text;

            //Instanciar un ProductoCE con sus valores
            AtencionCE atencionCE = new AtencionCE(id, idCita, sintomas, diagnostico, tratamiento);

            //Instanciar un ProductoCN
            AtencionCN atencionCN = new AtencionCN();

            //En funcion del ID
            if (id == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = atencionCN.Insertar(atencionCE);
                //Mostrar el nuevo ID
                txtIdAtencion.Text = nuevoId.ToString();
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
                int nFilas = atencionCN.Actualizar(atencionCE);
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
            int idEliminar = Convert.ToInt32(txtIdAtencion.Text);
            if (idEliminar > 0)
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    AtencionCN atencionCN = new AtencionCN();
                    int nFilas = atencionCN.Eliminar(idEliminar);
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
            this.Close();
        }

        
    }
}
