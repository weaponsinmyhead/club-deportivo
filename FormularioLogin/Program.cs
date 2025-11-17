using FormularioLogin.Configurations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


			// Verificar si la base de datos está configurada
			if (!ConfigurationManager.IsDatabaseConfigured())
			{
				// Mostrar formulario de configuración primero
				var configForm = new FrmBaseDeDatos();
				if (configForm.ShowDialog() != DialogResult.OK)
				{
					MessageBox.Show("La aplicación no puede continuar sin la configuración de la base de datos.",
						"Configuración Requerida", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			// Probar conexión antes de iniciar la aplicación principal
			try
			{
				using (var connection = new MySqlConnection(ConfigurationManager.GetConnectionString()))
				{
					connection.Open();
				}

				// Iniciar aplicación principal
				Application.Run(new FrmLogin());
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}\n\nPor favor, verifique la configuración.",
					"Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

				// Volver a mostrar configuración
				var configForm = new FrmBaseDeDatos();
				configForm.ShowDialog();
			}


			
        }
    }
}
