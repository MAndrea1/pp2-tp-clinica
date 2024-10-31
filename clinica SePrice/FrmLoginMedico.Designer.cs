namespace clinica_SePrice
{
    partial class FrmLoginMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginMedico));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuarioMedico = new System.Windows.Forms.TextBox();
            this.txtPasswordMedico = new System.Windows.Forms.TextBox();
            this.lblUsuarioMedico = new System.Windows.Forms.Label();
            this.lblPasswordMedico = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuarioMedico
            // 
            this.txtUsuarioMedico.Location = new System.Drawing.Point(270, 227);
            this.txtUsuarioMedico.Name = "txtUsuarioMedico";
            this.txtUsuarioMedico.Size = new System.Drawing.Size(165, 20);
            this.txtUsuarioMedico.TabIndex = 1;
            // 
            // txtPasswordMedico
            // 
            this.txtPasswordMedico.Location = new System.Drawing.Point(270, 307);
            this.txtPasswordMedico.Name = "txtPasswordMedico";
            this.txtPasswordMedico.Size = new System.Drawing.Size(165, 20);
            this.txtPasswordMedico.TabIndex = 2;
            // 
            // lblUsuarioMedico
            // 
            this.lblUsuarioMedico.AutoSize = true;
            this.lblUsuarioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioMedico.Location = new System.Drawing.Point(267, 196);
            this.lblUsuarioMedico.Name = "lblUsuarioMedico";
            this.lblUsuarioMedico.Size = new System.Drawing.Size(57, 17);
            this.lblUsuarioMedico.TabIndex = 3;
            this.lblUsuarioMedico.Text = "Usuario";
            // 
            // lblPasswordMedico
            // 
            this.lblPasswordMedico.AutoSize = true;
            this.lblPasswordMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMedico.Location = new System.Drawing.Point(267, 277);
            this.lblPasswordMedico.Name = "lblPasswordMedico";
            this.lblPasswordMedico.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordMedico.TabIndex = 4;
            this.lblPasswordMedico.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 336);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Teal;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(497, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 38);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "VOLVER";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(599, 357);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 38);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmLoginMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPasswordMedico);
            this.Controls.Add(this.lblUsuarioMedico);
            this.Controls.Add(this.txtPasswordMedico);
            this.Controls.Add(this.txtUsuarioMedico);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLoginMedico";
            this.Text = "FrmLoginMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuarioMedico;
        private System.Windows.Forms.TextBox txtPasswordMedico;
        private System.Windows.Forms.Label lblUsuarioMedico;
        private System.Windows.Forms.Label lblPasswordMedico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnIngresar;
    }
}