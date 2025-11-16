using System.Windows.Forms;

namespace FormularioLogin
{
	partial class FrmPagoCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagoCuota));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDniId = new System.Windows.Forms.Label();
            this.txtDniId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblMiembro = new System.Windows.Forms.Label();
            this.lblMiembroValor = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.labelActividad = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.lblMontoValor = new System.Windows.Forms.Label();
            this.cBActividades = new System.Windows.Forms.ComboBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(334, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pago de cuota";
            // 
            // lblDniId
            // 
            this.lblDniId.AutoSize = true;
            this.lblDniId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDniId.Location = new System.Drawing.Point(335, 101);
            this.lblDniId.Name = "lblDniId";
            this.lblDniId.Size = new System.Drawing.Size(47, 13);
            this.lblDniId.TabIndex = 1;
            this.lblDniId.Text = "Dni/Id:";
            // 
            // txtDniId
            // 
            this.txtDniId.Location = new System.Drawing.Point(442, 98);
            this.txtDniId.Name = "txtDniId";
            this.txtDniId.Size = new System.Drawing.Size(185, 20);
            this.txtDniId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(655, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(335, 131);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombreValor.Location = new System.Drawing.Point(442, 130);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(10, 13);
            this.lblNombreValor.TabIndex = 5;
            this.lblNombreValor.Text = "-";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellido.Location = new System.Drawing.Point(335, 151);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoValor.Location = new System.Drawing.Point(442, 150);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(10, 13);
            this.lblApellidoValor.TabIndex = 7;
            this.lblApellidoValor.Text = "-";
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMiembro.Location = new System.Drawing.Point(335, 171);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(98, 13);
            this.lblMiembro.TabIndex = 8;
            this.lblMiembro.Text = "Miembro Desde:";
            // 
            // lblMiembroValor
            // 
            this.lblMiembroValor.AutoSize = true;
            this.lblMiembroValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMiembroValor.Location = new System.Drawing.Point(442, 171);
            this.lblMiembroValor.Name = "lblMiembroValor";
            this.lblMiembroValor.Size = new System.Drawing.Size(10, 13);
            this.lblMiembroValor.TabIndex = 9;
            this.lblMiembroValor.Text = "-";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMonto.Location = new System.Drawing.Point(337, 222);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(46, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmision.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEmision.Location = new System.Drawing.Point(337, 252);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(54, 13);
            this.lblEmision.TabIndex = 14;
            this.lblEmision.Text = "Emision:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblVencimiento.Location = new System.Drawing.Point(338, 279);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(80, 13);
            this.lblVencimiento.TabIndex = 16;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(560, 278);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrarPago.TabIndex = 18;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(682, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTipo.Location = new System.Drawing.Point(335, 74);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo";
            // 
            // labelActividad
            // 
            this.labelActividad.AutoSize = true;
            this.labelActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelActividad.Location = new System.Drawing.Point(338, 190);
            this.labelActividad.Name = "labelActividad";
            this.labelActividad.Size = new System.Drawing.Size(64, 13);
            this.labelActividad.TabIndex = 25;
            this.labelActividad.Text = "Actividad:";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTipo.Location = new System.Drawing.Point(442, 73);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(10, 13);
            this.labelTipo.TabIndex = 27;
            this.labelTipo.Text = "-";
            // 
            // lblMontoValor
            // 
            this.lblMontoValor.AutoSize = true;
            this.lblMontoValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMontoValor.Location = new System.Drawing.Point(442, 222);
            this.lblMontoValor.Name = "lblMontoValor";
            this.lblMontoValor.Size = new System.Drawing.Size(10, 13);
            this.lblMontoValor.TabIndex = 28;
            this.lblMontoValor.Text = "-";
            // 
            // cBActividades
            // 
            this.cBActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBActividades.FormattingEnabled = true;
            this.cBActividades.Location = new System.Drawing.Point(445, 187);
            this.cBActividades.Name = "cBActividades";
            this.cBActividades.Size = new System.Drawing.Size(165, 21);
            this.cBActividades.TabIndex = 29;
            this.cBActividades.SelectedIndexChanged += new System.EventHandler(this.cBActividades_SelectedIndexChanged);
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFechaEmision.Location = new System.Drawing.Point(442, 252);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(10, 13);
            this.lblFechaEmision.TabIndex = 30;
            this.lblFechaEmision.Text = "-";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(442, 279);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(10, 13);
            this.lblFechaVencimiento.TabIndex = 31;
            this.lblFechaVencimiento.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 35;
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
            // FrmPagoCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.cBActividades);
            this.Controls.Add(this.lblMontoValor);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelActividad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMiembroValor);
            this.Controls.Add(this.lblMiembro);
            this.Controls.Add(this.lblApellidoValor);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDniId);
            this.Controls.Add(this.lblDniId);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagoCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Cuota";
            this.Load += new System.EventHandler(this.FrmPagoCuota_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblDniId;
		private System.Windows.Forms.TextBox txtDniId;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblNombreValor;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblApellidoValor;
		private System.Windows.Forms.Label lblMiembro;
		private System.Windows.Forms.Label lblMiembroValor;
		private System.Windows.Forms.Label lblMonto;
		private System.Windows.Forms.Label lblEmision;
		private System.Windows.Forms.Label lblVencimiento;
		private System.Windows.Forms.Button btnRegistrarPago;
		private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label labelActividad;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.Label lblMontoValor;
		private System.Windows.Forms.ComboBox cBActividades;
		private System.Windows.Forms.Label lblFechaEmision;
		private System.Windows.Forms.Label lblFechaVencimiento;
        private Panel panel1;
        private PictureBox picLogo;
    }
}