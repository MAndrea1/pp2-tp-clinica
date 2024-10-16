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
using clinica_SePrice.Datos;
using MySql.Data.MySqlClient;

namespace clinica_SePrice
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            FrmLoginMedico frmLoginMedico = new FrmLoginMedico();
            frmLoginMedico.ShowDialog();    
            this.Hide();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAdministrativo_Click_1(object sender, EventArgs e)
        {
            frmLoginAdmin frmadministrativo = new frmLoginAdmin();

            frmadministrativo.Show();
            this.Hide();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar());
        }
    }
    
}
