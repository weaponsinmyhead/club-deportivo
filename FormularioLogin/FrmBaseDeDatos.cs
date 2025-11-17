using FormularioLogin.Configurations;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FrmBaseDeDatos : Form
    {
		private DatabaseHelper dbHelper;
		public FrmBaseDeDatos()
        {
            InitializeComponent();
			CargarConfiguracionActual();
			dbHelper = new DatabaseHelper();
		}
		private void FrmBaseDeDatos_Load(object sender, EventArgs e)
		{

			btnGuardar.Enabled = false;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (ValidarCampos())
			{
				GuardarConfiguracion();
				MessageBox.Show("Configuración guardada correctamente", "Configuración",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnProbarConexion_Click(object sender, EventArgs e)
		{
			if (ValidarCampos())
			{
				if (ProbarConexion())
				{
					MessageBox.Show("¡Conexión exitosa!", "Prueba de Conexión",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnGuardar.Enabled = true;
				}
				else
				{
					btnGuardar.Enabled = false;
				}
			}

		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private bool ValidarCampos()
		{
			if (string.IsNullOrWhiteSpace(txtServidor.Text))
			{
				MessageBox.Show("El servidor es requerido", "Validación",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtServidor.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtBaseDatos.Text))
			{
				MessageBox.Show("El nombre de la base de datos es requerido", "Validación",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBaseDatos.Focus();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtUsuario.Text))
			{
				MessageBox.Show("El usuario es requerido", "Validación",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUsuario.Focus();
				return false;
			}

			return true;
		}
		private bool ProbarConexion()
		{
			try
			{
				// Guardar temporalmente para probar
				var servidor = txtServidor.Text;
				var puerto = string.IsNullOrWhiteSpace(txtPuerto.Text) ? "3306" : txtPuerto.Text;
				var baseDatos = txtBaseDatos.Text;
				var usuario = txtUsuario.Text;
				var password = txtPassword.Text;

				// CORRECCIÓN: No incluir la base de datos en la cadena de conexión de prueba
				// Solo probamos conexión al servidor, no a una base de datos específica
				string connectionString =
					$"Server={servidor};Port={puerto};Uid={usuario};Pwd={password};SslMode=Preferred;ConnectionTimeout=5;";

				using (var connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					// Opcional: Verificar si la base de datos existe
					if (!string.IsNullOrEmpty(baseDatos))
					{
						string checkDbQuery = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{baseDatos}'";
						using (var command = new MySqlCommand(checkDbQuery, connection))
						{
							var result = command.ExecuteScalar();
							if (result == null)
							{
								if (MessageBox.Show($"La base de datos '{baseDatos}' no existe. ¿Desea crearla?",
									"Base de Datos No Encontrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
								{
									Task.Run(() =>
									{
										dbHelper.CreateDatabase();

									});
								}
								else
								{
									return false;
								}
							}
						}
					}

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}",
					"Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void GuardarConfiguracion()
		{
			ConfigurationManager.SetConfiguration("DB_SERVER", txtServidor.Text);
			ConfigurationManager.SetConfiguration("DB_PORT",
				string.IsNullOrWhiteSpace(txtPuerto.Text) ? "3306" : txtPuerto.Text);
			ConfigurationManager.SetConfiguration("DB_NAME", txtBaseDatos.Text);
			ConfigurationManager.SetConfiguration("DB_USER", txtUsuario.Text);
			ConfigurationManager.SetConfiguration("DB_PASSWORD", txtPassword.Text);
		}
		private void CargarConfiguracionActual()
		{
			txtServidor.Text = ConfigurationManager.GetConfiguration("DB_SERVER");
			txtPuerto.Text = ConfigurationManager.GetConfiguration("DB_PORT");
			txtBaseDatos.Text = ConfigurationManager.GetConfiguration("DB_NAME");
			txtUsuario.Text = ConfigurationManager.GetConfiguration("DB_USER");
			txtPassword.Text = ConfigurationManager.GetConfiguration("DB_PASSWORD");
		}
	}
}
