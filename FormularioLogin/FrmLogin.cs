
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FrmLogin : Form
    {
	
		public FrmLogin()
        {
            InitializeComponent();
           
        }

       
        private void buttonIngresar_Click(object sender, EventArgs e)
        {

			string email = textBoxEmail.Text.Trim();
			string password = textBoxContrasenia.Text;

			if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Por favor completa todos los campos");
				return;
			}

			bool loginExitoso = VerificarLogin(email, password);

			if (loginExitoso)
			{
				MessageBox.Show($"Bienvenido {UsuarioActual.Nombre}");
				// Si el usuario y la contraseña son correctos, abrir el formulario de inicio
				FrmInicio frminicio = new FrmInicio(this);
				frminicio.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Email o contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBoxContrasenia.Clear();
				textBoxEmail.Clear();
				textBoxEmail.Focus();

			}
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            textBoxContrasenia.UseSystemPasswordChar = true;

        }
        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text == "")
            {
                textBoxContrasenia.UseSystemPasswordChar = false;
            }
        }

		public bool VerificarLogin(string email, string password)
		{
			try
			{
				string query = "SELECT id, nombre, email, rol_id FROM usuario WHERE email = @email AND contrasenia = @password AND activo = 1";

				MySqlParameter[] parameters = {
			new MySqlParameter("@email", email),
			new MySqlParameter("@password", password)
		};

				DataTable resultado = DatabaseHelper.ExecuteQuery(query, parameters);

				if (resultado.Rows.Count > 0)
				{
					DataRow usuario = resultado.Rows[0];

					UsuarioActual.Id = Convert.ToInt32(usuario["id"]);
					UsuarioActual.Nombre = usuario["nombre"].ToString();
					UsuarioActual.Email = usuario["email"].ToString();
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error en login: {ex.Message}");
				return false;
			}
		}


		// Clase para manejar sesión
		public static class UsuarioActual
		{
			public static int Id { get; set; }
			public static string Nombre { get; set; }
			public static string Email { get; set; }
			public static bool EstaLogueado => Id > 0;
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
	
}
