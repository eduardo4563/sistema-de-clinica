using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


using CapaDatos;
using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        //**** PATRON DE DISEÑO: SINGLETON **********************
        // PASO #1: Declarar la propiedad de control
        private static Login instancia = null;

        // PASO #2: Encapsular la propiedad de control (acceso de solo lectura)
        public static Login Instancia
        {
            get
            {
                //Controlar si NO existe una instancia o ha sido ELIMINADA
                if ((instancia == null) || (instancia.IsDisposed))
                {
                    //Instanciar la clase
                    instancia = new Login();
                }

                //Retornando la instancia
                return instancia;
            }

            //set { }
        }

        public Login()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            string usuario = txtApellido.Text;
            string password = txtPassword.Text;

            if (usuario != "" && txtApellido.TextLength > 2)
            {
                if (password != "")
                {
                    Logincn usser = new Logincn();
                     var validologin=usser.LoginUSER(usuario, password);
                    if (validologin == true)
                    {
                        if (UserLogin_.possition == Posiciones.Administrator)
                        {
                            this.Hide();
                            
                            ventanacargando ve = new ventanacargando();
                            ve.Show();
                            
                            administrador.Principal principal = new administrador.Principal();
                           
                            //sobrecargamos el formulario 
                            principal.FormClosed += cerrarseccion;

                        }
                        if (UserLogin_.possition == Posiciones.doctor)
                        {
                            this.Hide();
                            ventanacargando ve = new ventanacargando();
                            ve.Show();
                            Doctor.principal dcor = new Doctor.principal();
                            
                            dcor.FormClosed += cerrarseccion;
                        
                        }
                        if (UserLogin_.possition == Posiciones.Receptionist)
                        {
                            this.Hide();
                            ventanacargando ve = new ventanacargando();
                            ve.Show();
                            Recepcionista.Principal dcor = new Recepcionista.Principal();

                            dcor.FormClosed += cerrarseccion;

                        }
                    }
                    else
                    {
                        error("Credenciales Incorrectas");
                        txtPassword.UseSystemPasswordChar = false;
                        txtPassword.Clear();
                        txtPassword.Focus();
                    
                    }
                }
                else
                {
                    error("Introduzca su contraseña");
                }
            }
            else
            {
                error("Introduzca su nombre de usuario");
            }
        }
        private void error(string msq)
        {
            lblerror.Text = "" + msq;
            lblerror.Visible = true;
        }
        private void cerrarseccion(object sender,FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtApellido.Clear();
            lblerror.Visible = false;
            this.Show();
            txtApellido.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        
        
        private bool mouseDown;
        private Point lastLocation;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
