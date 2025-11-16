using System.Drawing;
using System.Windows.Forms;

namespace FormularioLogin
{
	partial class FrmCarnetSocio
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
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarnetSocio));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblClub = new System.Windows.Forms.Label();
            this.linea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNITitulo = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNumeroSocioTitulo = new System.Windows.Forms.Label();
            this.lblNumeroSocio = new System.Windows.Forms.Label();
            this.lblFechaNacTitulo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVovler = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.picLogo);
            this.panelPrincipal.Controls.Add(this.lblClub);
            this.panelPrincipal.Controls.Add(this.linea);
            this.panelPrincipal.Controls.Add(this.picFoto);
            this.panelPrincipal.Controls.Add(this.lblNombre);
            this.panelPrincipal.Controls.Add(this.lblDNITitulo);
            this.panelPrincipal.Controls.Add(this.lblDNI);
            this.panelPrincipal.Controls.Add(this.lblNumeroSocioTitulo);
            this.panelPrincipal.Controls.Add(this.lblNumeroSocio);
            this.panelPrincipal.Controls.Add(this.lblFechaNacTitulo);
            this.panelPrincipal.Controls.Add(this.lblFechaNacimiento);
            this.panelPrincipal.Controls.Add(this.lblEmision);
            this.panelPrincipal.Controls.Add(this.lblFechaEmision);
            this.panelPrincipal.Controls.Add(this.lblVencimiento);
            this.panelPrincipal.Controls.Add(this.lblFechaVencimiento);
            this.panelPrincipal.Controls.Add(this.lblCodigoBarras);
            this.panelPrincipal.Location = new System.Drawing.Point(10, 10);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(380, 220);
            this.panelPrincipal.TabIndex = 0;
            // 
            // lblClub
            // 
            this.lblClub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblClub.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblClub.Location = new System.Drawing.Point(80, 15);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(200, 20);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "CLUB DEPORTIVO";
            // 
            // linea
            // 
            this.linea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linea.Location = new System.Drawing.Point(10, 80);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(350, 2);
            this.linea.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(15, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(250, 20);
            this.lblNombre.TabIndex = 4;
            // 
            // lblDNITitulo
            // 
            this.lblDNITitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDNITitulo.Location = new System.Drawing.Point(15, 120);
            this.lblDNITitulo.Name = "lblDNITitulo";
            this.lblDNITitulo.Size = new System.Drawing.Size(40, 15);
            this.lblDNITitulo.TabIndex = 5;
            this.lblDNITitulo.Text = "DNI:";
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDNI.Location = new System.Drawing.Point(55, 120);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(100, 15);
            this.lblDNI.TabIndex = 6;
            // 
            // lblNumeroSocioTitulo
            // 
            this.lblNumeroSocioTitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroSocioTitulo.Location = new System.Drawing.Point(15, 140);
            this.lblNumeroSocioTitulo.Name = "lblNumeroSocioTitulo";
            this.lblNumeroSocioTitulo.Size = new System.Drawing.Size(70, 15);
            this.lblNumeroSocioTitulo.TabIndex = 7;
            this.lblNumeroSocioTitulo.Text = "N° SOCIO:";
            // 
            // lblNumeroSocio
            // 
            this.lblNumeroSocio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroSocio.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroSocio.Location = new System.Drawing.Point(90, 140);
            this.lblNumeroSocio.Name = "lblNumeroSocio";
            this.lblNumeroSocio.Size = new System.Drawing.Size(80, 15);
            this.lblNumeroSocio.TabIndex = 8;
            // 
            // lblFechaNacTitulo
            // 
            this.lblFechaNacTitulo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacTitulo.Location = new System.Drawing.Point(15, 160);
            this.lblFechaNacTitulo.Name = "lblFechaNacTitulo";
            this.lblFechaNacTitulo.Size = new System.Drawing.Size(100, 15);
            this.lblFechaNacTitulo.TabIndex = 9;
            this.lblFechaNacTitulo.Text = "F. NACIMIENTO:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 8F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(120, 160);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(80, 15);
            this.lblFechaNacimiento.TabIndex = 10;
            // 
            // lblEmision
            // 
            this.lblEmision.Font = new System.Drawing.Font("Arial", 7F);
            this.lblEmision.Location = new System.Drawing.Point(15, 185);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(50, 12);
            this.lblEmision.TabIndex = 11;
            this.lblEmision.Text = "Emisión:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.lblFechaEmision.Location = new System.Drawing.Point(65, 185);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(60, 12);
            this.lblFechaEmision.TabIndex = 12;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.Font = new System.Drawing.Font("Arial", 7F);
            this.lblVencimiento.Location = new System.Drawing.Point(130, 185);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(40, 12);
            this.lblVencimiento.TabIndex = 13;
            this.lblVencimiento.Text = "Vence:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.lblFechaVencimiento.Location = new System.Drawing.Point(170, 185);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(60, 12);
            this.lblFechaVencimiento.TabIndex = 14;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblCodigoBarras.Location = new System.Drawing.Point(15, 200);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(200, 15);
            this.lblCodigoBarras.TabIndex = 15;
            this.lblCodigoBarras.Text = "|||| |||| |||| ||||";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(291, 240);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir Carnet";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVovler
            // 
            this.btnVovler.Location = new System.Drawing.Point(10, 240);
            this.btnVovler.Name = "btnVovler";
            this.btnVovler.Size = new System.Drawing.Size(100, 30);
            this.btnVovler.TabIndex = 3;
            this.btnVovler.Text = "Vovler";
            this.btnVovler.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.LightBlue;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::FormularioLogin.Properties.Resources.ClubDepPic;
            this.picLogo.Location = new System.Drawing.Point(10, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(64, 67);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.LightGray;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::FormularioLogin.Properties.Resources.UserPic;
            this.picFoto.Location = new System.Drawing.Point(280, 90);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(80, 100);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 3;
            this.picFoto.TabStop = false;
            // 
            // FrmCarnetSocio
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 309);
            this.Controls.Add(this.btnVovler);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnImprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarnetSocio";
            this.Text = "Carnet de Socio";
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		private Panel panelPrincipal;
		private PictureBox picLogo;
		private Label lblClub;
		private Label linea;
		private PictureBox picFoto;
		private Label lblNombre;
		private Label lblDNITitulo;
		private Label lblDNI;
		private Label lblNumeroSocioTitulo;
		private Label lblNumeroSocio;
		private Label lblFechaNacTitulo;
		private Label lblFechaNacimiento;
		private Label lblEmision;
		private Label lblFechaEmision;
		private Label lblVencimiento;
		private Label lblFechaVencimiento;
		private Label lblCodigoBarras;
		private Button btnImprimir;
		private Button btnVovler;
	}
}