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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Carga_Grilla();
        }
        DataTable dt = new DataTable();
        private void mostrar()
        {
            string desBuscar = txtValorBuscado.Text;

            //Instancia la CapaNegocio
            PropietarioCN prodc = new PropietarioCN();
            //Ejecutar el metodo de busqueda y asignar el resultado
            List<PropietarioCE> listaPropietariosCE = prodc.BuscarByApellido(desBuscar);
            dgvPropietarios.DataSource = listaPropietariosCE;
        }
        private void Carga_Grilla()
        {
           
           // dgvPropietarios.DataSource = propi.listar();
            //dgvPropietarios.;

            try
            {
                PropietarioCN propietarioCN = new PropietarioCN();
                dt = propietarioCN.listar();
                if (dt.Rows.Count !=0)
                {
                    dgvPropietarios.DataSource = dt;
                    //dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                else
                {
                    dgvPropietarios.DataSource = null;
                }
                //PropietarioCN propietarioCN = new PropietarioCN();
                //dgvPropietarios.DataSource = propietarioCN.listar();
                //dt = propietarioCN.listar;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValorBuscado.Text))
            {
                MessageBox.Show("Porfavor ingresar el criterio de la busqueda");
            }
            else
            {
                //Leer el valor de busqueda
                string desBuscar = txtValorBuscado.Text;

                //Instancia la CapaNegocio
                PropietarioCN propietarioCN = new PropietarioCN();
                //Ejecutar el metodo de busqueda y asignar el resultado
                List<PropietarioCE> listaPropietariosCE = propietarioCN.BuscarByApellido(desBuscar);
                if (listaPropietariosCE.Count ==0)
                {
                    MessageBox.Show("registro no encontrado");
                    txtValorBuscado.Text = "";
                    Carga_Grilla();
                }
                else
                {
                    //Asinar la lista de ProductosCE al DGV
                    dgvPropietarios.DataSource = listaPropietariosCE;

                    //Ajustar el ancho de las columnas del DGV
                   // dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //txtValorBuscado.Clear();
                }

            

            }

        }

        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPropietarios.SelectedRows.Count >= 1)
            {
                txtIdPropietario.Text = dgvPropietarios.CurrentRow.Cells[0].Value.ToString();
                txtNombrePropietario.Text = dgvPropietarios.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPropietario.Text = dgvPropietarios.CurrentRow.Cells[2].Value.ToString();
                txtDniPropietario.Text = dgvPropietarios.CurrentRow.Cells[3].Value.ToString();
                txtTelefonoPropietario.Text = dgvPropietarios.CurrentRow.Cells[4].Value.ToString();
                txtDireccionPropietario.Text = dgvPropietarios.CurrentRow.Cells[5].Value.ToString();
            }
              

            /*if (dgvPropietarios.SelectedRows.Count >= 1)
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
            }*/
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ids = txtIdPropietario.Text;
            string nombres = txtNombrePropietario.Text;
            string apellidos = txtApellidoPropietario.Text;
            string dnis = txtDniPropietario.Text;
            string telefonos = txtTelefonoPropietario.Text;
            string direccion = txtDireccionPropietario.Text;

            //isnullorwitespace  indica si la cadena es nula
            if (string.IsNullOrWhiteSpace(ids) || string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(dnis) || string.IsNullOrWhiteSpace(telefonos) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Campos Incomplento ....");
                return;
                
            }
            else
            {
                //Leer los valores
                int idPropietario = Convert.ToInt32(txtIdPropietario.Text);
                string nombrePropietario = txtNombrePropietario.Text;
                string apellidoPropietario = txtApellidoPropietario.Text;
                string dniPropietario = txtDniPropietario.Text;
                string telefonoPropietario = txtTelefonoPropietario.Text;
                string direccionPropietario = txtDireccionPropietario.Text;

                //Instanciar un ProductoCE con sus valores
                PropietarioCE propietarioCE = new PropietarioCE(idPropietario, nombrePropietario, apellidoPropietario, dniPropietario, telefonoPropietario, direccionPropietario);

                //Instanciar un ProductoCN
                PropietarioCN propietarioCN = new PropietarioCN();
                //dgvPropietarios.DataSource = propietarioCE;
                //Ajustar el ancho de las columnas del DGV
                //dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


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

                        mostrar();


                        //Mensaje
                        MessageBox.Show("Se ha guardado el nuevo registro.");
                        Carga_Grilla();
                        //ejecutamos el metodo limpiar
                        btnNuevo_Click(null,null);
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
                        mostrar();
                        //Mensaje
                        MessageBox.Show("Se ha actualizado el registro.");
                        Carga_Grilla();
                        //ejecutamos el metodo limpiar
                        btnNuevo_Click(null, null);
                    }
                    else
                    {
                        //Mesaje
                        MessageBox.Show("Ocurrio un error! No se actualizo el registro.");
                    }
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
                        Carga_Grilla();
                        //ejecutamos el metodo limpiar
                        btnNuevo_Click(null, null);
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

        private void txtDniPropietario_TextChanged(object sender, EventArgs e)
        {   
           
           
        }

        private void txtDniPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }

         
        }

        private void txtTelefonoPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtValorBuscado_TextChanged(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtValorBuscado.Text))
            {
                Carga_Grilla();
            }*/
        }

        private void txtlimipiae_Click(object sender, EventArgs e)
        {
            txtValorBuscado.Text = "";
            Carga_Grilla();

        }
    }
}
