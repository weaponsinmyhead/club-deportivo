namespace FormularioLogin
{
    partial class FrmBaseDeDatos
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtServidor = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtBaseDatos = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnProbarConexion = new System.Windows.Forms.Button();
			this.txtPuerto = new System.Windows.Forms.TextBox();
			this.txtpuerto1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MintCream;
			this.panel1.Controls.Add(this.picLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 442);
			this.panel1.TabIndex = 37;
			// 
			// picLogo
			// 
			this.picLogo.BackColor = System.Drawing.Color.Transparent;
			this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLogo.Image = global::FormularioLogin.Properties.Resources.ClubDepPic;
			this.picLogo.Location = new System.Drawing.Point(12, 25);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(227, 246);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 33;
			this.picLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(317, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(395, 36);
			this.label1.TabIndex = 35;
			this.label1.Text = "Conexion Base de Datos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Location = new System.Drawing.Point(539, 333);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(200, 50);
			this.btnGuardar.TabIndex = 36;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtServidor
			// 
			this.txtServidor.Location = new System.Drawing.Point(439, 91);
			this.txtServidor.Name = "txtServidor";
			this.txtServidor.Size = new System.Drawing.Size(150, 20);
			this.txtServidor.TabIndex = 39;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox1.ForeColor = System.Drawing.Color.DimGray;
			this.textBox1.Location = new System.Drawing.Point(307, 92);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(413, 19);
			this.textBox1.TabIndex = 38;
			this.textBox1.Text = "SERVER";
			// 
			// txtBaseDatos
			// 
			this.txtBaseDatos.Location = new System.Drawing.Point(439, 153);
			this.txtBaseDatos.Name = "txtBaseDatos";
			this.txtBaseDatos.Size = new System.Drawing.Size(150, 20);
			this.txtBaseDatos.TabIndex = 41;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox3.ForeColor = System.Drawing.Color.DimGray;
			this.textBox3.Location = new System.Drawing.Point(307, 154);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(413, 19);
			this.textBox3.TabIndex = 40;
			this.textBox3.Text = "NOMBRE DB";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(439, 183);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(150, 20);
			this.txtUsuario.TabIndex = 43;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox5.ForeColor = System.Drawing.Color.DimGray;
			this.textBox5.Location = new System.Drawing.Point(307, 184);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(413, 19);
			this.textBox5.TabIndex = 42;
			this.textBox5.Text = "USUARIO";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(439, 214);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(150, 20);
			this.txtPassword.TabIndex = 45;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox7.ForeColor = System.Drawing.Color.DimGray;
			this.textBox7.Location = new System.Drawing.Point(307, 215);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(413, 19);
			this.textBox7.TabIndex = 44;
			this.textBox7.Text = "CONTRASEÑA";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(291, 333);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(200, 50);
			this.btnCancelar.TabIndex = 46;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnProbarConexion
			// 
			this.btnProbarConexion.Location = new System.Drawing.Point(419, 260);
			this.btnProbarConexion.Name = "btnProbarConexion";
			this.btnProbarConexion.Size = new System.Drawing.Size(200, 54);
			this.btnProbarConexion.TabIndex = 47;
			this.btnProbarConexion.Text = "Probar Conexión";
			this.btnProbarConexion.UseVisualStyleBackColor = true;
			this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
			// 
			// txtPuerto
			// 
			this.txtPuerto.Location = new System.Drawing.Point(439, 119);
			this.txtPuerto.Name = "txtPuerto";
			this.txtPuerto.Size = new System.Drawing.Size(150, 20);
			this.txtPuerto.TabIndex = 49;
			// 
			// txtpuerto1
			// 
			this.txtpuerto1.BackColor = System.Drawing.SystemColors.InfoText;
			this.txtpuerto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtpuerto1.Font = new System.Drawing.Font("Arial", 12F);
			this.txtpuerto1.ForeColor = System.Drawing.Color.DimGray;
			this.txtpuerto1.Location = new System.Drawing.Point(307, 120);
			this.txtpuerto1.Name = "txtpuerto1";
			this.txtpuerto1.Size = new System.Drawing.Size(413, 19);
			this.txtpuerto1.TabIndex = 48;
			this.txtpuerto1.Text = "PUERTO";
			// 
			// FrmBaseDeDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(780, 442);
			this.Controls.Add(this.txtPuerto);
			this.Controls.Add(this.txtpuerto1);
			this.Controls.Add(this.btnProbarConexion);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.txtBaseDatos);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.txtServidor);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label1);
			this.Name = "FrmBaseDeDatos";
			this.Text = "FrmBaseDeDatos";
			this.Load += new System.EventHandler(this.FrmBaseDeDatos_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnProbarConexion;
		private System.Windows.Forms.TextBox txtPuerto;
		private System.Windows.Forms.TextBox txtpuerto1;
	}
}