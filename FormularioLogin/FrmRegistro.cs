
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//formularioLogin -> Administrar paquetes NuGet -> Buscar MySql.Data y luego lo tienen que instalar, sino no funciona.

namespace FormularioLogin
{
	public partial class FrmRegistro : Form
	{
		private Form formularioInicio;
		public FrmRegistro(Form frmInicio)
		{
			InitializeComponent();
			formularioInicio = frmInicio;
		}


		private void btn_registrar(object sender, EventArgs e)
		{
			// Esto es para asegurarse que está todo completo.
			if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
				string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
				string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
				string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
				comboBoxTipo.SelectedItem == null)

			{
				MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Se asegura que el mail tenga @ y .
			if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
			{
				MessageBox.Show("El email parece inválido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Usar reflection para obtener las propiedades
			var item = comboBoxTipo.SelectedItem;
			var tipo = item.GetType();


			string valor = tipo.GetProperty("Value")?.GetValue(item)?.ToString();
			if (valor == "1")//selecciona socio
			{
				// Acá obtenemos los datos que se pone en el formulario
				string nombre = textBoxNombre.Text.Trim();
				string apellido = textBoxApellido.Text.Trim();
				string dni = textBoxDNI.Text.Trim();
				DateTime fechaNac = dateTimeNac.Value.Date; // .Date para que solo sea la fecha sin la hora.
				string email = textBoxEmail.Text.Trim();
				DateTime fechaEmision = dateTimeEmision.Value.Date;


				string query = "INSERT INTO socio (nombre, apellido, dni, fecha_nac, email, fecha_emision) " +
				   "VALUES (@nombre, @apellido, @dni, @fechaNac, @correo, @fechaEmision)";

				int result = DatabaseHelper.ExecuteNonQuery(
					query,
					new MySqlParameter("@nombre", nombre),
					new MySqlParameter("@apellido", apellido),
					new MySqlParameter("@dni", dni),
					new MySqlParameter("@fechaNac", fechaNac),
					new MySqlParameter("@correo", email),
					new MySqlParameter("@fechaEmision", fechaEmision)

				);
				if (result > 0)
				{
					MessageBox.Show("Socio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimpiarCampos();
				}
			}
			else
			{
				string nombre = textBoxNombre.Text.Trim();
				string apellido = textBoxApellido.Text.Trim();
				string dni = textBoxDNI.Text.Trim();
				DateTime fechaNac = dateTimeNac.Value.Date; // .Date para que solo sea la fecha sin la hora.
				string email = textBoxEmail.Text.Trim();

				string query = "INSERT INTO noSocio (nombre, apellido, dni,fecha_nac, email) " +
				   "VALUES (@nombre, @apellido, @dni, @fechaNac, @correo)";

				int result = DatabaseHelper.ExecuteNonQuery(
					query,
					new MySqlParameter("@nombre", nombre),
					new MySqlParameter("@apellido", apellido),
					new MySqlParameter("@dni", dni),
					new MySqlParameter("@fechaNac", fechaNac),
					new MySqlParameter("@correo", email)


				);
				if (result > 0)
				{
					MessageBox.Show("No Socio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimpiarCampos();
				}
			}
		}

		private void CargarComboBox()
		{
			comboBoxTipo.Items.Clear();

			// Agregar items con texto y valor
			comboBoxTipo.Items.Add(new { Text = "Socio", Value = "1" });
			comboBoxTipo.Items.Add(new { Text = "No Socio", Value = "2" });

			// Configurar qué propiedad mostrar
			comboBoxTipo.DisplayMember = "Text";
		}


		// este es el metodo para que se limpien los campos, no es necesario pero queda mas lindo. 
		private void LimpiarCampos()
		{
			textBoxNombre.Clear();
			textBoxApellido.Clear();
			textBoxDNI.Clear();
			textBoxEmail.Clear();
			dateTimeNac.Value = DateTime.Today; // Esto hace que se restablezca a la fecha actual. 
			dateTimeEmision.Value = DateTime.Today;
		}



		private void FrmRegistro_Load(object sender, EventArgs e)
		{
			CargarComboBox();

		}

		private void textBoxApellido_TextChanged(object sender, EventArgs e) { }
		private void dateTimeNac_ValueChanged(object sender, EventArgs e) { }
		private void btn_volverInicio(object sender, EventArgs e)
		{
			formularioInicio.Show();
			this.Close();
		}


		private void comboBoxTipo_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}
	}
}