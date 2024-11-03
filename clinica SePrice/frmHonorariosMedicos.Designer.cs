namespace clinica_SePrice
{
    partial class frmHonorariosMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHonorariosMedicos));
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.btnCalcularHonorarios = new System.Windows.Forms.Button();
            this.lblHonorarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(402, 56);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(211, 21);
            this.cmbMedicos.TabIndex = 0;
            // 
            // btnCalcularHonorarios
            // 
            this.btnCalcularHonorarios.Location = new System.Drawing.Point(402, 168);
            this.btnCalcularHonorarios.Name = "btnCalcularHonorarios";
            this.btnCalcularHonorarios.Size = new System.Drawing.Size(211, 41);
            this.btnCalcularHonorarios.TabIndex = 1;
            this.btnCalcularHonorarios.Text = "Calcular Honorarios";
            this.btnCalcularHonorarios.UseVisualStyleBackColor = true;
            this.btnCalcularHonorarios.Click += new System.EventHandler(this.btnCalcularHonorarios_Click);
            // 
            // lblHonorarios
            // 
            this.lblHonorarios.AutoSize = true;
            this.lblHonorarios.Location = new System.Drawing.Point(12, 75);
            this.lblHonorarios.Name = "lblHonorarios";
            this.lblHonorarios.Size = new System.Drawing.Size(0, 13);
            this.lblHonorarios.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(402, 238);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(211, 20);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "MEDICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MES";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(402, 114);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(211, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL";
            // 
            // btnGenerarPdf
            // 
            this.btnGenerarPdf.Location = new System.Drawing.Point(402, 304);
            this.btnGenerarPdf.Name = "btnGenerarPdf";
            this.btnGenerarPdf.Size = new System.Drawing.Size(211, 23);
            this.btnGenerarPdf.TabIndex = 9;
            this.btnGenerarPdf.Text = "GENERAR PDF";
            this.btnGenerarPdf.UseVisualStyleBackColor = true;
            this.btnGenerarPdf.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHonorariosMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 495);
            this.Controls.Add(this.btnGenerarPdf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHonorarios);
            this.Controls.Add(this.btnCalcularHonorarios);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "frmHonorariosMedicos";
            this.Text = "Honorarios Médicos";
            this.Load += new System.EventHandler(this.frmHonorariosMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.Button btnCalcularHonorarios;
        private System.Windows.Forms.Label lblHonorarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerarPdf;
    }
}