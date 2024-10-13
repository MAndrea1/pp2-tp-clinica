using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmAdministrativoMenu : Form
    {
        public frmAdministrativoMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListadoPacientesAtendidos frmlistadopacientesatendidos = new frmListadoPacientesAtendidos();

            frmlistadopacientesatendidos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAcreditacionTurno frmacreditacionturno = new frmAcreditacionTurno();

            frmacreditacionturno.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReservaTurno frmReservaTurno = new frmReservaTurno();
            frmReservaTurno.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRegistroPcientes frmRegistroPcientes = new frmRegistroPcientes();
            frmRegistroPcientes.Show();
            this.Hide();
        }
    }
}
