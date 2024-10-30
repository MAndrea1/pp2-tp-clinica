namespace clinica_SePrice
{
    partial class frmHistoriaClinica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoriaClinica));
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtActualizarDiagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPrepaga = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelProfesional = new System.Windows.Forms.Label();
            this.labelProfesionalValor = new System.Windows.Forms.Label();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.labelEspecialidadValor = new System.Windows.Forms.Label();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.labelDiagnosticoValor = new System.Windows.Forms.Label();
            this.labelTurnoFechaValor = new System.Windows.Forms.Label();
            this.grpTurnoData = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriaClinica)).BeginInit();
            this.grpTurnoData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(516, 390);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtActualizarDiagnostico
            // 
            this.txtActualizarDiagnostico.Location = new System.Drawing.Point(93, 325);
            this.txtActualizarDiagnostico.Multiline = true;
            this.txtActualizarDiagnostico.Name = "txtActualizarDiagnostico";
            this.txtActualizarDiagnostico.Size = new System.Drawing.Size(575, 34);
            this.txtActualizarDiagnostico.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "HISTORIA CLINICA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(102, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 15);
            this.lblNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(210, 99);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 15);
            this.lblApellido.TabIndex = 7;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(315, 99);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(0, 13);
            this.lblDNI.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(396, 99);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 13);
            this.lblGenero.TabIndex = 9;
            // 
            // lblPrepaga
            // 
            this.lblPrepaga.AutoSize = true;
            this.lblPrepaga.ForeColor = System.Drawing.Color.White;
            this.lblPrepaga.Location = new System.Drawing.Point(496, 99);
            this.lblPrepaga.Name = "lblPrepaga";
            this.lblPrepaga.Size = new System.Drawing.Size(0, 13);
            this.lblPrepaga.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(496, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prepaga";
            // 
            // dataGridViewHistoriaClinica
            // 
            this.dataGridViewHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoriaClinica.Location = new System.Drawing.Point(93, 163);
            this.dataGridViewHistoriaClinica.Name = "dataGridViewHistoriaClinica";
            this.dataGridViewHistoriaClinica.Size = new System.Drawing.Size(323, 144);
            this.dataGridViewHistoriaClinica.TabIndex = 12;
            this.dataGridViewHistoriaClinica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistoriaClinica_CellClick);
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(16, 36);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(46, 13);
            this.labelTurno.TabIndex = 13;
            this.labelTurno.Text = "TURNO";
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(16, 66);
            this.labelProfesional.Name = "labelProfesional";
            this.labelProfesional.Size = new System.Drawing.Size(85, 13);
            this.labelProfesional.TabIndex = 14;
            this.labelProfesional.Text = "PROFESIONAL:";
            // 
            // labelProfesionalValor
            // 
            this.labelProfesionalValor.AutoSize = true;
            this.labelProfesionalValor.Location = new System.Drawing.Point(110, 66);
            this.labelProfesionalValor.Name = "labelProfesionalValor";
            this.labelProfesionalValor.Size = new System.Drawing.Size(33, 13);
            this.labelProfesionalValor.TabIndex = 15;
            this.labelProfesionalValor.Text = "Maria";
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(16, 96);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(87, 13);
            this.labelEspecialidad.TabIndex = 16;
            this.labelEspecialidad.Text = "ESPECIALIDAD:";
            // 
            // labelEspecialidadValor
            // 
            this.labelEspecialidadValor.AutoSize = true;
            this.labelEspecialidadValor.Location = new System.Drawing.Point(110, 96);
            this.labelEspecialidadValor.Name = "labelEspecialidadValor";
            this.labelEspecialidadValor.Size = new System.Drawing.Size(35, 13);
            this.labelEspecialidadValor.TabIndex = 17;
            this.labelEspecialidadValor.Text = "label4";
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.Location = new System.Drawing.Point(15, 125);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(84, 13);
            this.labelDiagnostico.TabIndex = 18;
            this.labelDiagnostico.Text = "DIAGNOSTICO:";
            // 
            // labelDiagnosticoValor
            // 
            this.labelDiagnosticoValor.AutoSize = true;
            this.labelDiagnosticoValor.Location = new System.Drawing.Point(110, 125);
            this.labelDiagnosticoValor.Name = "labelDiagnosticoValor";
            this.labelDiagnosticoValor.Size = new System.Drawing.Size(35, 13);
            this.labelDiagnosticoValor.TabIndex = 19;
            this.labelDiagnosticoValor.Text = "label6";
            // 
            // labelTurnoFechaValor
            // 
            this.labelTurnoFechaValor.AutoSize = true;
            this.labelTurnoFechaValor.Location = new System.Drawing.Point(110, 36);
            this.labelTurnoFechaValor.Name = "labelTurnoFechaValor";
            this.labelTurnoFechaValor.Size = new System.Drawing.Size(35, 13);
            this.labelTurnoFechaValor.TabIndex = 20;
            this.labelTurnoFechaValor.Text = "label3";
            // 
            // grpTurnoData
            // 
            this.grpTurnoData.Controls.Add(this.labelTurno);
            this.grpTurnoData.Controls.Add(this.labelTurnoFechaValor);
            this.grpTurnoData.Controls.Add(this.labelProfesional);
            this.grpTurnoData.Controls.Add(this.labelDiagnosticoValor);
            this.grpTurnoData.Controls.Add(this.labelProfesionalValor);
            this.grpTurnoData.Controls.Add(this.labelDiagnostico);
            this.grpTurnoData.Controls.Add(this.labelEspecialidad);
            this.grpTurnoData.Controls.Add(this.labelEspecialidadValor);
            this.grpTurnoData.Location = new System.Drawing.Point(467, 152);
            this.grpTurnoData.Name = "grpTurnoData";
            this.grpTurnoData.Size = new System.Drawing.Size(296, 155);
            this.grpTurnoData.TabIndex = 21;
            this.grpTurnoData.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(93, 390);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(152, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTurnoData);
            this.Controls.Add(this.dataGridViewHistoriaClinica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrepaga);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActualizarDiagnostico);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmHistoriaClinica";
            this.Text = "frmHistoriaClinica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoriaClinica)).EndInit();
            this.grpTurnoData.ResumeLayout(false);
            this.grpTurnoData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtActualizarDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPrepaga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHistoriaClinica;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.Label labelProfesionalValor;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Label labelEspecialidadValor;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.Label labelDiagnosticoValor;
        private System.Windows.Forms.Label labelTurnoFechaValor;
        private System.Windows.Forms.GroupBox grpTurnoData;
        private System.Windows.Forms.Button btnActualizar;
    }
}