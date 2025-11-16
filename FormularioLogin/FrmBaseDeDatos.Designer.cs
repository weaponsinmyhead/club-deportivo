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
            this.btnConectarse = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(250, 330);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConectarse
            // 
            this.btnConectarse.Location = new System.Drawing.Point(512, 258);
            this.btnConectarse.Name = "btnConectarse";
            this.btnConectarse.Size = new System.Drawing.Size(200, 50);
            this.btnConectarse.TabIndex = 36;
            this.btnConectarse.Text = "Conectarse";
            this.btnConectarse.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(439, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmail.TabIndex = 39;
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
            this.textBox1.Text = "EMAIL";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(439, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox3.ForeColor = System.Drawing.Color.DimGray;
            this.textBox3.Location = new System.Drawing.Point(307, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(413, 19);
            this.textBox3.TabIndex = 40;
            this.textBox3.Text = "EMAIL";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(439, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 43;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox5.ForeColor = System.Drawing.Color.DimGray;
            this.textBox5.Location = new System.Drawing.Point(307, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 19);
            this.textBox5.TabIndex = 42;
            this.textBox5.Text = "EMAIL";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(439, 188);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 45;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox7.ForeColor = System.Drawing.Color.DimGray;
            this.textBox7.Location = new System.Drawing.Point(307, 189);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(413, 19);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "EMAIL";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(292, 258);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(200, 50);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConectarse);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaseDeDatos";
            this.Text = "FrmBaseDeDatos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectarse;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnVolver;
    }
}