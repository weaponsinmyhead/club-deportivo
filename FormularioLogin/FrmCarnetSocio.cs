using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
	public partial class FrmCarnetSocio : Form
	{
		private Form FrmPago;
		private dynamic _socio;
		private string _numeroCarnet;

		
		public FrmCarnetSocio(dynamic socio, string numeroCarnet, Form frmPago)
		{
			InitializeComponent();
			_socio = socio;
			_numeroCarnet = numeroCarnet;
			ConfigurarCarnet();
			FrmPago = frmPago;
		}

		private void ConfigurarCarnet()
		{
			// Información principal del socio
			lblNombre.Text = $"{_socio.Nombre} {_socio.Apellido}";
			lblDNI.Text = _socio.Dni;
			lblNumeroSocio.Text = _numeroCarnet;
			lblFechaNacimiento.Text = _socio.FechaNac.ToString("dd/MM/yyyy");

			// Fechas importantes
			lblFechaEmision.Text = DateTime.Today.ToString("dd/MM/yyyy");
			lblFechaVencimiento.Text = DateTime.Today.AddYears(1).ToString("dd/MM/yyyy"); // Vence en 1 año
		}



		private void btnImprimir_Click(object sender, EventArgs e)
		{
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);

			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = pd;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				pd.Print();
			}
		}
		

		private void ImprimirCarnet(object sender, PrintPageEventArgs e)
		{
			Graphics g = e.Graphics;
			Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
			Font fontNormal = new Font("Arial", 10);

			// Dibujar el contenido del carnet
			g.DrawString("CARNET DE SOCIO", fontTitulo, Brushes.Black, 50, 50);
			g.DrawString($"Nombre: {_socio.Nombre} {_socio.Apellido}", fontNormal, Brushes.Black, 50, 100);
			g.DrawString($"DNI: {_socio.Dni}", fontNormal, Brushes.Black, 50, 120);
			g.DrawString($"N° Socio: {_numeroCarnet}", fontNormal, Brushes.Black, 50, 140);
			g.DrawString($"Fecha Emisión: {DateTime.Today:dd/MM/yyyy}", fontNormal, Brushes.Black, 50, 160);
		}

		

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			FrmPago.Show();
		}
	}
}
