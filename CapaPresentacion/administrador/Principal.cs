using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //from
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            datauser();
            //seguridad();
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

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnper_Click(object sender, EventArgs e)
        {

        }

        

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta Seguro de Cerrar seccion?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                Login lod = new Login();
                lod.Show();

            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
