﻿using System;
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
            //Leer los valores
            string usuario = txtApellido.Text;
            string password = txtPassword.Text;
           

            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Rellenar campos");
            }
            else
            {
                

                SqlConnection cnx = ConexionCD.conectarToSqlServer();

                //Abrir la conexion
                cnx.Open();

                //Crear el comando vinculado a la conexion
                SqlCommand cmd = cnx.CreateCommand();
                //Definir el Tipo de comando
                cmd.CommandType = CommandType.Text;

                //Verificar (esto puede hacerse con una consulta a la BD)
                string autenticado = (("select * from recepcionista where apellido='" + txtApellido.Text + "'and pass='" + txtPassword.Text + "'"));
                SqlCommand comando = new SqlCommand(autenticado, cnx);
                SqlDataReader lector;
                lector = comando.ExecuteReader();



                if (lector.HasRows == true)
                {
                    PrincipalCP frmPrincipal = new PrincipalCP();
                    this.Hide();
                    frmPrincipal.Show();
                    cnx.Close();
                }
                else
                {
                    SqlConnection cnx1 = ConexionCD.conectarToSqlServer();

                    //Abrir la conexion
                    cnx1.Open();

                    //Crear el comando vinculado a la conexion
                    SqlCommand cmd1 = cnx1.CreateCommand();
                    //Definir el Tipo de comando
                    cmd.CommandType = CommandType.Text;

                    string autenticado2 = (("select * from doctor where apellido='" + txtApellido.Text + "'and pass='" + txtPassword.Text + "'"));
                    SqlCommand comando2 = new SqlCommand(autenticado2, cnx1);
                    SqlDataReader lector2;
                    lector2 = comando2.ExecuteReader();

                    if (lector2.HasRows == true)
                    {
                        PrincipalCP frmPrincipal = new PrincipalCP();
                        this.Hide();
                        frmPrincipal.Show();
                        cnx1.Close();
                    }
                    else
                    {
                        MessageBox.Show("ACCESO DENEGADO, INTENTE OTRA VEZ");
                     
                        txtApellido.Text = "";
                        txtApellido.Focus();
                        //pas
                        txtPassword.Text = "";
                
                    }

                }
            }
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
