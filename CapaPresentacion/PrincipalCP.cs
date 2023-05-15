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
    public partial class PrincipalCP : Form
    {
        public PrincipalCP()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitasCP.Instancia.MdiParent = this;
            CitasCP.Instancia.WindowState = FormWindowState.Maximized;
            CitasCP.Instancia.Show();
        }

        private void mnuPropietarios_Click(object sender, EventArgs e)
        {
            PropietarioCP.Instancia.MdiParent = this;
            PropietarioCP.Instancia.WindowState = FormWindowState.Maximized;
            PropietarioCP.Instancia.Show();
        }

        private void mnuAnimal_Click_1(object sender, EventArgs e)
        {
            AnimalCP.Instancia.MdiParent = this;
            AnimalCP.Instancia.WindowState = FormWindowState.Maximized;
            AnimalCP.Instancia.Show();
        }

        private void recepcionistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionistaCP.Instancia.MdiParent = this;
            RecepcionistaCP.Instancia.WindowState = FormWindowState.Maximized;
            RecepcionistaCP.Instancia.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorCP.Instancia.MdiParent = this;
            DoctorCP.Instancia.WindowState = FormWindowState.Maximized;
            DoctorCP.Instancia.Show();
        }

        private void atencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtencionCP.Instancia.MdiParent = this;
            AtencionCP.Instancia.WindowState = FormWindowState.Maximized;
            AtencionCP.Instancia.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta Seguro de Cerrar seccion?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta==DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void PrincipalCP_Load(object sender, EventArgs e)
        {
            /*seguridad();
            permiso();*/

            datauser();
            seguridad();
            permiso();
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
        private void permiso()
        {
            if (Usercache.Position==Posiciones.Accounting)
            {
                btnadmin.Enabled = false;
                btnrecepcionista.Enabled = false;
            }
            if (Usercache.Position==Posiciones.Receptionist)
            {
                btnadmin.Enabled = false;
                btndoctor.Enabled = false;  
            }
            if (Usercache.Position==Posiciones.Administrator)
            {
                btndoctor.Enabled=false;
                btnrecepcionista.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
