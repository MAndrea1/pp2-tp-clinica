﻿using System;
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
    public partial class FrmLoginMedico : Form
    {
        public FrmLoginMedico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginMedico_Load(object sender, EventArgs e)
        {

        }
       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMedicoPaciente frmMedicoPaciente = new frmMedicoPaciente();  
            frmMedicoPaciente.ShowDialog();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
