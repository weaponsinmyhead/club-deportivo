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
			this.label1 = new System.Windows.Forms.Label();
			this.Registro = new System.Windows.Forms.Button();
			this.pcuota = new System.Windows.Forms.Button();
			this.activ = new System.Windows.Forms.Button();
			this.asistencias = new System.Windows.Forms.Button();
			this.vcuotas = new System.Windows.Forms.Button();
			this.cuotasven = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(674, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "SISTEMA CLUB DEPORTIVO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Registro
			// 
			this.Registro.Location = new System.Drawing.Point(121, 124);
			this.Registro.Name = "Registro";
			this.Registro.Size = new System.Drawing.Size(200, 50);
			this.Registro.TabIndex = 1;
			this.Registro.Text = "REGISTRO";
			this.Registro.UseVisualStyleBackColor = true;
			this.Registro.Click += new System.EventHandler(this.button1_Click);
			// 
			// pcuota
			// 
			this.pcuota.Location = new System.Drawing.Point(456, 124);
			this.pcuota.Name = "pcuota";
			this.pcuota.Size = new System.Drawing.Size(200, 50);
			this.pcuota.TabIndex = 2;
			this.pcuota.Text = "PAGO CUOTA";
			this.pcuota.UseVisualStyleBackColor = true;
			this.pcuota.Click += new System.EventHandler(this.pcuota_Click);
			// 
			// activ
			// 
			this.activ.Location = new System.Drawing.Point(121, 200);
			this.activ.Name = "activ";
			this.activ.Size = new System.Drawing.Size(200, 50);
			this.activ.TabIndex = 3;
			this.activ.Text = "INSCRIPCIÓN ACTIVIDAD";
			this.activ.UseVisualStyleBackColor = true;
			this.activ.Click += new System.EventHandler(this.activ_Click);
			// 
			// asistencias
			// 
			this.asistencias.Location = new System.Drawing.Point(121, 276);
			this.asistencias.Name = "asistencias";
			this.asistencias.Size = new System.Drawing.Size(200, 50);
			this.asistencias.TabIndex = 4;
			this.asistencias.Text = "ASISTENCIAS";
			this.asistencias.UseVisualStyleBackColor = true;
			this.asistencias.Click += new System.EventHandler(this.asistencias_Click);
			// 
			// vcuotas
			// 
			this.vcuotas.Location = new System.Drawing.Point(456, 200);
			this.vcuotas.Name = "vcuotas";
			this.vcuotas.Size = new System.Drawing.Size(200, 50);
			this.vcuotas.TabIndex = 5;
			this.vcuotas.Text = "VERIFICACIÓN CUOTAS";
			this.vcuotas.UseVisualStyleBackColor = true;
			this.vcuotas.Click += new System.EventHandler(this.vcuotas_Click);
			// 
			// cuotasven
			// 
			this.cuotasven.Location = new System.Drawing.Point(456, 276);
			this.cuotasven.Name = "cuotasven";
			this.cuotasven.Size = new System.Drawing.Size(200, 50);
			this.cuotasven.TabIndex = 6;
			this.cuotasven.Text = "LISTADO CUOTAS VENCIDAS";
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
			// FrmInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.cuotasven);
			this.Controls.Add(this.vcuotas);
			this.Controls.Add(this.asistencias);
			this.Controls.Add(this.activ);
			this.Controls.Add(this.pcuota);
			this.Controls.Add(this.Registro);
			this.Controls.Add(this.label1);
			this.Name = "FrmInicio";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmInicio_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Registro;
		private System.Windows.Forms.Button pcuota;
		private System.Windows.Forms.Button activ;
		private System.Windows.Forms.Button asistencias;
		private System.Windows.Forms.Button vcuotas;
		private System.Windows.Forms.Button cuotasven;
		private System.Windows.Forms.Button btnSalir;
	}
}