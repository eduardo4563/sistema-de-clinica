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
    public partial class docot2 : Form
    {
        public docot2()
        {
            InitializeComponent();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
