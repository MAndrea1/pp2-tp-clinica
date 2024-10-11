using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinica_SePrice;

namespace clinica_SePrice
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {

        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmAdministrativoMenu frmAdministrativoMenu = new frmAdministrativoMenu();
            frmAdministrativoMenu.ShowDialog();
            this.Close();
        }
    }
}
