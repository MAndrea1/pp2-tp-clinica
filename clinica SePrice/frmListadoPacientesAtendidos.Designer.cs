namespace clinica_SePrice
{
    partial class frmListadoPacientesAtendidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPacientesAtendidos));
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(360, 129);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(200, 21);
            this.cmbMedicos.TabIndex = 0;
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(360, 192);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(200, 21);
            this.cmbEspecialidades.TabIndex = 1;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(360, 246);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(400, 150);
            this.dgvPacientes.TabIndex = 2;
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.Location = new System.Drawing.Point(397, 429);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(75, 23);
            this.btnListarPacientes.TabIndex = 3;
            this.btnListarPacientes.Text = "Listar Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = true;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(665, 429);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmListadoPacientesAtendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(852, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "frmListadoPacientesAtendidos";
            this.Text = "Listado de Pacientes Atendidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}