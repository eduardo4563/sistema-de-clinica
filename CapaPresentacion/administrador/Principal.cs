using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.administrador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta Seguro de Cerrar seccion?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                Login lod = new Login();
                lod.Show();
                
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            datauser();
            seguridad();
           // permiso();
        }

        private void datauser()
        {
            lblnombre.Text = UserLogin_.firstname;
            lblposiciton.Text = UserLogin_.possition;
            lblcorreo.Text = UserLogin_.email;

        }
        //seguridad para que no haiga ataques
        private void seguridad()
        {
            var userModel = new Logincn();
            if (userModel.securidadlogin() == false)
            {
                MessageBox.Show("ERROR FATAL , SE DETECTO QUE ESTA INTENDO ACCEDER AL SISTEMA SIN CREDENCIALES,POE FAVOR INICIE SESIÓN E IDENTIFIQUESE");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
