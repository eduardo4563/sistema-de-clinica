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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void recepcionistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionistaCP recepcionistaCP = new RecepcionistaCP();
            recepcionistaCP.ShowDialog();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorCP doctorCP = new DoctorCP();
            doctorCP.ShowDialog();
        }

        private void iniciarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login iNICIO = new Login();
            iNICIO.ShowDialog();
        }
    }
}
