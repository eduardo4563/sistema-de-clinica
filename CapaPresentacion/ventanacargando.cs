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
using CapaPresentacion.Doctor;

namespace CapaPresentacion
{
    public partial class ventanacargando : Form
    {
        public ventanacargando()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            {
                progressBar1.Value += 1;
                if (progressBar1.Value == 100)
                {
                    timer1.Stop();
                    timer2.Start();
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity ==0)
            {
                timer2.Stop();
                this.Close();
                if (UserLogin_.possition == Posiciones.Administrator)
                {
                    administrador.Principal principal = new administrador.Principal();
                    principal.Show();
                    

                }
                if (UserLogin_.possition == Posiciones.doctor)
                {
                    Doctor.principal dcor = new Doctor.principal();
                    dcor.Show();
                   
                }
                if (UserLogin_.possition == Posiciones.Receptionist)
                {
                    Recepcionista.Principal rece = new Recepcionista.Principal();
                    rece.Show();

                }

            }
        }

        private void ventanacargando_Load(object sender, EventArgs e)
        {
            lblusuario.Text = UserLogin_.firstname + " " + UserLogin_.lastname;
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
