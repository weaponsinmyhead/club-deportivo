using System.Windows.Forms;

namespace FormularioLogin
{
    partial class FrmRegistro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellido = new System.Windows.Forms.TextBox();
			this.textBoxDNI = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.dateTimeNac = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimeEmision = new System.Windows.Forms.DateTimePicker();
			this.btnVolver = new System.Windows.Forms.Button();
			this.comboBoxTipo = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(288, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(398, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "REGISTRO DE SOCIOS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(291, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(291, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "DNI:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(291, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(291, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 22);
			this.label5.TabIndex = 5;
			this.label5.Text = "Fecha de nacimiento:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(291, 191);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 22);
			this.label6.TabIndex = 6;
			this.label6.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(505, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 22);
			this.label8.TabIndex = 8;
			this.label8.Text = "Tipo:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(380, 64);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(323, 20);
			this.textBoxNombre.TabIndex = 9;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
			// 
			// textBoxApellido
			// 
			this.textBoxApellido.Location = new System.Drawing.Point(381, 95);
			this.textBoxApellido.Name = "textBoxApellido";
			this.textBoxApellido.Size = new System.Drawing.Size(322, 20);
			this.textBoxApellido.TabIndex = 10;
			this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
			// 
			// textBoxDNI
			// 
			this.textBoxDNI.Location = new System.Drawing.Point(380, 126);
			this.textBoxDNI.Name = "textBoxDNI";
			this.textBoxDNI.Size = new System.Drawing.Size(115, 20);
			this.textBoxDNI.TabIndex = 11;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(359, 191);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(344, 20);
			this.textBoxEmail.TabIndex = 12;
			// 
			// dateTimeNac
			// 
			this.dateTimeNac.Location = new System.Drawing.Point(488, 162);
			this.dateTimeNac.Name = "dateTimeNac";
			this.dateTimeNac.Size = new System.Drawing.Size(215, 20);
			this.dateTimeNac.TabIndex = 13;
			this.dateTimeNac.ValueChanged += new System.EventHandler(this.dateTimeNac_ValueChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(295, 270);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 40);
			this.button1.TabIndex = 16;
			this.button1.Text = "REGISTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_registrar);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Underline);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(291, 223);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(139, 22);
			this.label7.TabIndex = 17;
			this.label7.Text = "Fecha emisión:";
			// 
			// dateTimeEmision
			// 
			this.dateTimeEmision.Location = new System.Drawing.Point(436, 225);
			this.dateTimeEmision.Name = "dateTimeEmision";
			this.dateTimeEmision.Size = new System.Drawing.Size(267, 20);
			this.dateTimeEmision.TabIndex = 18;
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(521, 270);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(182, 39);
			this.btnVolver.TabIndex = 19;
			this.btnVolver.Text = "VOLVER";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btn_volverInicio);
			// 
			// comboBoxTipo
			// 
			this.comboBoxTipo.DropDownHeight = 150;
			this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTipo.FormattingEnabled = true;
			this.comboBoxTipo.IntegralHeight = false;
			this.comboBoxTipo.Location = new System.Drawing.Point(582, 126);
			this.comboBoxTipo.MaxDropDownItems = 2;
			this.comboBoxTipo.Name = "comboBoxTipo";
			this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTipo.TabIndex = 20;
			this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MintCream;
			this.panel1.Controls.Add(this.picLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 330);
			this.panel1.TabIndex = 36;
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
			// FrmRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(780, 330);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBoxTipo);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.dateTimeEmision);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimeNac);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxDNI);
			this.Controls.Add(this.textBoxApellido);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmRegistro";
			this.Text = "Registrar Socio/No socio";
			this.Load += new System.EventHandler(this.FrmRegistro_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimeNac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeEmision;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.ComboBox comboBoxTipo;
        private Panel panel1;
        private PictureBox picLogo;
    }
}