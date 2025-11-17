using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioLogin.Configurations
{

	public static class ConfigurationManager
	{
		private static readonly Dictionary<string, string> _configurations = new Dictionary<string, string>();

		static ConfigurationManager()
		{
			// Valores por defecto 
			LoadDefaultValues();
		}

		public static void SetConfiguration(string key, string value)
		{
			if (_configurations.ContainsKey(key))
				_configurations[key] = value;
			else
				_configurations.Add(key, value);
		}

		public static string GetConfiguration(string key)
		{
			return _configurations.ContainsKey(key) ? _configurations[key] : string.Empty;
		}

		// Propiedades específicas para la base de datos
		public static string DatabaseServer => GetConfiguration("DB_SERVER");
		public static string DatabaseName => GetConfiguration("DB_NAME");
		public static string DatabaseUser => GetConfiguration("DB_USER");
		public static string DatabasePassword => GetConfiguration("DB_PASSWORD");
		public static string DatabasePort => GetConfiguration("DB_PORT");

		public static string GetConnectionString()
		{

			return $"Server={DatabaseServer};Port={DatabasePort};Database={DatabaseName};Uid={DatabaseUser};Pwd={DatabasePassword};SslMode=Disabled;CharSet=utf8mb4;ConnectionTimeout=15;DefaultCommandTimeout=30;";
		}

		public static bool IsDatabaseConfigured()
		{
			return !string.IsNullOrEmpty(DatabaseServer) &&
				   !string.IsNullOrEmpty(DatabaseName) &&
				   !string.IsNullOrEmpty(DatabaseUser) &&
				   !string.IsNullOrEmpty(DatabasePort) &&
				   !string.IsNullOrEmpty(DatabasePassword);
		}

		private static void LoadDefaultValues()
		{
			// Valores por defecto 
			SetConfiguration("DB_SERVER", "localhost");
			SetConfiguration("DB_PORT", "3306");
			SetConfiguration("DB_NAME", "Club");
			SetConfiguration("DB_USER", "root");
			SetConfiguration("DB_PASSWORD", ""); // Clave vacía
		}
		
	}
}
