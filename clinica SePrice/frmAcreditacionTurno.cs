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
    public partial class frmAcreditacionTurno : Form
    {
        public frmAcreditacionTurno()
        {
            InitializeComponent();
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmAdministrativoMenu frmAdministrativoMenu = new frmAdministrativoMenu();
            frmAdministrativoMenu.ShowDialog();
           
            this.Close();
                
        }
    }
}
