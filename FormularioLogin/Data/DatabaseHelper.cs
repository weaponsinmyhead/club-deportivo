using FormularioLogin.Configurations;
using FormularioLogin.Data;
using MySql.Data.MySqlClient;

using System;
using System.Data;
using System.Windows.Forms;

namespace FormularioLogin
{
	public  class DatabaseHelper
	{
		// Leer la cadena de conexión desde App.config
		private static string connectionString = ConfigurationManager.GetConnectionString();

		// Método para ejecutar consultas (INSERT, UPDATE, DELETE)
		public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();
					using (MySqlCommand command = new MySqlCommand(query, connection))
					{
						if (parameters != null)
							command.Parameters.AddRange(parameters);

						return command.ExecuteNonQuery();
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show($"Error de MySQL: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return -1;
			}
		}

		// Método para ejecutar consultas que devuelven datos (SELECT)
		public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
		{
			DataTable dt = new DataTable();
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();
					using (MySqlCommand command = new MySqlCommand(query, connection))
					{
						if (parameters != null)
							command.Parameters.AddRange(parameters);

						using (MySqlDataReader reader = command.ExecuteReader())
						{
							dt.Load(reader);
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show($"Error de MySQL: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return dt;
		}

		public bool CreateDatabase()
		{
			// Usar una sola conexión para todos los scripts
		
			using (MySqlConnection connection = 
				new MySqlConnection(connectionString = $"Server={ConfigurationManager.DatabaseServer};Port={ConfigurationManager.DatabasePort};Uid={ConfigurationManager.DatabaseUser};Pwd={ConfigurationManager.DatabasePassword};SslMode=Disabled;CharSet=utf8mb4;ConnectionTimeout=15;DefaultCommandTimeout=30;"))
			{
				connection.Open();

				string[] scripts = {
			DBScriptsCreate.CreateDatabase,
			DBScriptsCreate.CreateTables,
			DBScriptsCreate.InsertInitialData
		};

				foreach (string script in scripts)
				{
					if (!ExecuteEmbeddedScript(script, connection))
						return false;
				}
				return true;
			}
		}



		private bool ExecuteEmbeddedScript(string script, MySqlConnection connection)
		{
			try
			{
				string[] commands = script.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

				for (int i = 0; i < commands.Length; i++)
				{
					string cleanCommand = commands[i].Trim();

					if (string.IsNullOrWhiteSpace(cleanCommand))
						continue;

					// Manejar comando USE específicamente
					if (cleanCommand.ToUpper().StartsWith("USE "))
					{
						string dbName = cleanCommand.Substring(4).Trim().Replace("`", "");
						connection.ChangeDatabase(dbName);
						continue;
					}

					using (MySqlCommand command = new MySqlCommand(cleanCommand, connection))
					{
						command.CommandTimeout = 180;
						command.ExecuteNonQuery();
					}
				}
				return true;
			}
			catch (MySqlException sqlEx)
			{
				MessageBox.Show($"Error en script: {sqlEx.Message}\nComando: {script.Substring(0, Math.Min(100, script.Length))}...",
							  "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error general: {ex.Message}", "Error",
							  MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

	}

}