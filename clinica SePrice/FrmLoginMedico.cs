﻿using System;
using System.Windows.Forms;
using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;

namespace clinica_SePrice
{
    public partial class FrmLoginMedico : Form
    {
        public FrmLoginMedico()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Log_Usu(txtUsuarioMedico.Text, txtPasswordMedico.Text, 121);

            // Llamar al método Log_Usu que ejecuta el procedure de la DB
            Usuario usuario = usuarios.Log_Usu(txtUsuarioMedico.Text, txtPasswordMedico.Text, 121);

            // Obtener el usuario medico
            Medicos medicos = new Medicos();
            Medico medico = medicos.BuscarMedicoPorId(usuario.CodUsu);

            // Validar que devuelva algo
            if (medico != null)
            {
                // Crear y empezar un nuevo subproceso para abrir el menú del médico
                frmMedicoPaciente frmMedicoPaciente = new frmMedicoPaciente(medico);
                frmMedicoPaciente.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }
    }
}
