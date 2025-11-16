using System;

namespace FormularioLogin
{
	partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.pcuota = new System.Windows.Forms.Button();
            this.vcuotas = new System.Windows.Forms.Button();
            this.cuotasven = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA CLUB DEPORTIVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(285, 197);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(200, 50);
            this.Registro.TabIndex = 1;
            this.Registro.Text = "REGISTRO";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcuota
            // 
            this.pcuota.Location = new System.Drawing.Point(285, 117);
            this.pcuota.Name = "pcuota";
            this.pcuota.Size = new System.Drawing.Size(200, 50);
            this.pcuota.TabIndex = 2;
            this.pcuota.Text = "PAGO CUOTA";
            this.pcuota.UseVisualStyleBackColor = true;
            this.pcuota.Click += new System.EventHandler(this.pcuota_Click);
            // 
            // vcuotas
            // 
            this.vcuotas.Location = new System.Drawing.Point(527, 197);
            this.vcuotas.Name = "vcuotas";
            this.vcuotas.Size = new System.Drawing.Size(200, 50);
            this.vcuotas.TabIndex = 5;
            this.vcuotas.Text = "ESTADOS";
            this.vcuotas.UseVisualStyleBackColor = true;
            this.vcuotas.Click += new System.EventHandler(this.vcuotas_Click);
            // 
            // cuotasven
            // 
            this.cuotasven.Location = new System.Drawing.Point(527, 117);
            this.cuotasven.Name = "cuotasven";
            this.cuotasven.Size = new System.Drawing.Size(200, 50);
            this.cuotasven.TabIndex = 6;
            this.cuotasven.Text = "VENCIMIENTOS";
            this.cuotasven.UseVisualStyleBackColor = true;
            this.cuotasven.Click += new System.EventHandler(this.cuotasven_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 325);
            this.panel1.TabIndex = 34;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cuotasven);
            this.Controls.Add(this.vcuotas);
            this.Controls.Add(this.pcuota);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Registro;
		private System.Windows.Forms.Button pcuota;
		private System.Windows.Forms.Button vcuotas;
		private System.Windows.Forms.Button cuotasven;
		private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel1;
    }
}