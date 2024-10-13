namespace clinica_SePrice
{
    partial class frmRegistroPcientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPcientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtDNIP = new System.Windows.Forms.TextBox();
            this.rbtnPrepaga = new System.Windows.Forms.RadioButton();
            this.rbtnParticular = new System.Windows.Forms.RadioButton();
            this.txtNacionalidadP = new System.Windows.Forms.TextBox();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGeneroP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(366, 97);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(137, 20);
            this.txtNombreP.TabIndex = 1;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(366, 145);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(137, 20);
            this.txtApellidoP.TabIndex = 2;
            // 
            // txtDNIP
            // 
            this.txtDNIP.Location = new System.Drawing.Point(366, 195);
            this.txtDNIP.Name = "txtDNIP";
            this.txtDNIP.Size = new System.Drawing.Size(137, 20);
            this.txtDNIP.TabIndex = 3;
            // 
            // rbtnPrepaga
            // 
            this.rbtnPrepaga.AutoSize = true;
            this.rbtnPrepaga.Location = new System.Drawing.Point(613, 98);
            this.rbtnPrepaga.Name = "rbtnPrepaga";
            this.rbtnPrepaga.Size = new System.Drawing.Size(76, 17);
            this.rbtnPrepaga.TabIndex = 4;
            this.rbtnPrepaga.TabStop = true;
            this.rbtnPrepaga.Text = "PREPAGA";
            this.rbtnPrepaga.UseVisualStyleBackColor = true;
            // 
            // rbtnParticular
            // 
            this.rbtnParticular.AutoSize = true;
            this.rbtnParticular.Location = new System.Drawing.Point(613, 144);
            this.rbtnParticular.Name = "rbtnParticular";
            this.rbtnParticular.Size = new System.Drawing.Size(93, 17);
            this.rbtnParticular.TabIndex = 5;
            this.rbtnParticular.TabStop = true;
            this.rbtnParticular.Text = "PARTICULAR";
            this.rbtnParticular.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidadP
            // 
            this.txtNacionalidadP.Location = new System.Drawing.Point(366, 249);
            this.txtNacionalidadP.Name = "txtNacionalidadP";
            this.txtNacionalidadP.Size = new System.Drawing.Size(137, 20);
            this.txtNacionalidadP.TabIndex = 6;
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(556, 322);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(170, 23);
            this.btnRegistrarPaciente.TabIndex = 7;
            this.btnRegistrarPaciente.Text = "REGISTRAR PACIENTE";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "APELIIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "NACIONALIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "GÉNERO";
            // 
            // cbGeneroP
            // 
            this.cbGeneroP.FormattingEnabled = true;
            this.cbGeneroP.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cbGeneroP.Location = new System.Drawing.Point(366, 300);
            this.cbGeneroP.Name = "cbGeneroP";
            this.cbGeneroP.Size = new System.Drawing.Size(121, 21);
            this.cbGeneroP.TabIndex = 13;
            this.cbGeneroP.Text = "Seleccionar";
            // 
            // frmRegistroPcientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbGeneroP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarPaciente);
            this.Controls.Add(this.txtNacionalidadP);
            this.Controls.Add(this.rbtnParticular);
            this.Controls.Add(this.rbtnPrepaga);
            this.Controls.Add(this.txtDNIP);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRegistroPcientes";
            this.Text = "frmRegistroPcientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtDNIP;
        private System.Windows.Forms.RadioButton rbtnPrepaga;
        private System.Windows.Forms.RadioButton rbtnParticular;
        private System.Windows.Forms.TextBox txtNacionalidadP;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGeneroP;
    }
}