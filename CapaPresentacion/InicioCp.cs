using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioCp : Form
    {
        public InicioCp()
        {
            IsMdiContainer = true;
            InitializeComponent();
         



        }


           
        

        private void InicioCp_Load(object sender, EventArgs e)
        {
           

        }

        private void recepcionistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionistaCP recepcionista = new RecepcionistaCP();
            recepcionista.ShowDialog();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorCP doctor = new DoctorCP();
            doctor.ShowDialog();
        }

        private void iniciarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aunteticarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            
        }
    }
}
