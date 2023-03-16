using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class resep2 : Form
    {
        public resep2()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Leer el valor de busqueda
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            RecepcionistaCN recepcionistaCN = new RecepcionistaCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<RecepcionistaCE> listaRecepcionistaCE = RecepcionistaCN.BuscarByApellido(desBuscar);

            //Asinar la lista de ProductosCE al DGV
            dgvRecepcionistas.DataSource = listaRecepcionistaCE;

            //Ajustar el ancho de las columnas del DGV
            dgvRecepcionistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Leer los valores
            int id = Convert.ToInt32(txtIdRecepcionista.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string turno = txtTurno.Text;
            string contraseña = txtContraseña.Text;


            //Instanciar un ProductoCE con sus valores
            RecepcionistaCE recepcionistaCE = new RecepcionistaCE(id, nombre, apellido, turno, contraseña);

            //Instanciar un ProductoCN
            RecepcionistaCN recepcionistaCN = new RecepcionistaCN();

            //En funcion del ID
            if (id == 0)
            {
                //FUNCION 1: INSERTAR (NUEVO)
                int nuevoId = RecepcionistaCN.Insertar(recepcionistaCE);
                //Mostrar el nuevo ID
                txtIdRecepcionista.Text = nuevoId.ToString();
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
                int nFilas = RecepcionistaCN.Actualizar(recepcionistaCE);
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
            int idEliminar = Convert.ToInt32(txtIdRecepcionista.Text);
            if (idEliminar > 0)
            {
                //Hacer la pregunta
                DialogResult rpta = MessageBox.Show("¿Esta seguro que desea eliminar el registro actual?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpta == DialogResult.Yes)
                {
                    RecepcionistaCN recepcionistaCN = new RecepcionistaCN();
                    int nFilas = RecepcionistaCN.Eliminar(idEliminar);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdRecepcionista.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTurno.Text = "";
            txtContraseña.Text = "";

            txtValorBuscado.Text = "";

            dgvRecepcionistas.DataSource = null;
        }
    }
}
