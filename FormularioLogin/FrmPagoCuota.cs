using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FormularioLogin
{
	public partial class FrmPagoCuota : Form
	{
		private Form FormInicio;
		private DateTime _fechaEmision;
		private DateTime _fechaVencimiento;
		private List<ActividadPrecios> _actividades = new List<ActividadPrecios>();
		private bool _esSocio = false;
		private ActividadPrecios _actividadSeleccionada;
		private dynamic _persona;

		public FrmPagoCuota(Form formInicio)
		{
			InitializeComponent();
			FormInicio = formInicio;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			FormInicio.Show();
			this.Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

			btnRegistrarPago.Enabled = false;
			_persona = BuscarPersonaPorDni(txtDniId.Text);
			if (!_persona.Encontrado)
			{
				MessageBox.Show($"Persona no encontrada, reintente ingresando un DNI válido");
				return;
			}

			if (_persona.Encontrado)
			{
				labelTipo.Text = _persona.Tipo;
				lblNombreValor.Text = _persona.Nombre;
				lblApellidoValor.Text = _persona.Apellido;
				lblMiembroValor.Text = _persona.CreateTime.ToString("dd/MM/yyyy");
				cBActividades.Enabled = true;

				ObtenerActividadesConPrecios();
				CargarActividadesEnComboBox(cBActividades);
				cBActividades.SelectedIndex = -1;
				cBActividades.Text = "Seleccione una actividad";

				lblFechaEmision.Text = _fechaEmision.ToString("dd/MM/yyyy");


				if (_persona.Tipo == "socio")
				{
					_esSocio = true;

					lblFechaVencimiento.Text = _fechaVencimiento.ToString("dd/MM/yyyy");


				}
				else if (_persona.Tipo == "noSocio")
				{
					_esSocio = false;
					lblFechaVencimiento.Text = "-";

				}
			}

		}

		private void FrmPagoCuota_Load(object sender, EventArgs e)
		{

			cBActividades.Enabled = false;
			btnRegistrarPago.Enabled = false;
			ObtenerFechas();

		}

		private void cBActividades_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnRegistrarPago.Enabled = true;
			MostrarPrecioActividad();
		}

		private void btnRegistrarPago_Click(object sender, EventArgs e)
		{
			if (_persona == null || _actividadSeleccionada == null)
			{
				MessageBox.Show("Por favor, seleccione una actividad y verifique los datos del usuario.");
				return;
			}
			// Verificar si es primera cuota

			var infoCarnet = VerificarPrimeraCuotaYGenerarCarnet(_persona.Id);




			DialogResult resultado = MessageBox.Show(
				$"¿Confirmar pago de {lblMontoValor.Text} para {lblNombreValor.Text} {lblApellidoValor.Text}?",
				"Confirmar Pago",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (resultado == DialogResult.Yes)
			{
				if (ProcesarPago())
				{
					MessageBox.Show("Pago registrado exitosamente!", "Éxito",
								  MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (infoCarnet.EsPrimeraCuota)
					{
						FrmCarnetSocio frmCarnetSocio = new FrmCarnetSocio(_persona, infoCarnet.NumeroCarnet ,this);
						this.Hide();
						frmCarnetSocio.Show();
						
					}
					else
					{
						FormInicio.Show();
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("Error al registrar el pago.", "Error",
								  MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		//METODOS
		public static dynamic BuscarPersonaPorDni(string dni)
		{
			try
			{
				string query = @"
            SELECT 'socio' as tipo, id, nombre, apellido, dni, fecha_nac, email, 
                   fecha_emision, estado, create_time, carnet, null as es_socio
            FROM socio 
            WHERE dni = @dni AND estado = 1
            UNION ALL
            SELECT 'noSocio' as tipo, id, nombre, apellido, dni, fecha_nac, email,
                   null as fecha_emision, 1 as estado, create_time, 0 as carnet, null as es_socio
            FROM noSocio 
            WHERE dni = @dni";

				MySqlParameter[] parameters = {
			new MySqlParameter("@dni", dni)
		};

				DataTable resultado = DatabaseHelper.ExecuteQuery(query, parameters);

				if (resultado.Rows.Count > 0)
				{
					DataRow persona = resultado.Rows[0];
					string tipo = persona["tipo"].ToString();

					return new
					{
						Encontrado = true,
						Tipo = tipo,
						Id = Convert.ToInt32(persona["id"]),
						Nombre = persona["nombre"].ToString(),
						Apellido = persona["apellido"].ToString(),
						Dni = persona["dni"].ToString(),
						CreateTime = Convert.ToDateTime(persona["create_time"]),
						FechaNac = Convert.ToDateTime(persona["fecha_nac"]),
						Email= persona["email"].ToString(),

					};
				}

				return new { Encontrado = false, Tipo = "" };
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al buscar persona por DNI: {ex.Message}");
				return new { Encontrado = false, Tipo = "", Error = ex.Message };
			}
		}



		private List<ActividadPrecios> ObtenerActividadesConPrecios()
		{
			var actividades = new List<ActividadPrecios>();

			try
			{
				string query = @"
            SELECT 
                id,
                nombre_actividad,
                precio_diario,
                precio_mensual
            FROM actividad 
            ORDER BY nombre_actividad";

				DataTable resultado = DatabaseHelper.ExecuteQuery(query);

				foreach (DataRow row in resultado.Rows)
				{
					actividades.Add(new ActividadPrecios
					{
						Id = Convert.ToInt32(row["id"]),
						NombreActividad = row["nombre_actividad"].ToString(),
						PrecioDiario = row["precio_diario"] != DBNull.Value ? Convert.ToDecimal(row["precio_diario"]) : 0,
						PrecioMensual = row["precio_mensual"] != DBNull.Value ? Convert.ToDecimal(row["precio_mensual"]) : 0
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al obtener actividades: {ex.Message}");
			}

			return actividades;
		}

		public void CargarActividadesEnComboBox(ComboBox comboBox)
		{
			try
			{
				_actividades = ObtenerActividadesConPrecios();

				comboBox.DisplayMember = "NombreActividad";
				comboBox.ValueMember = "Id";
				comboBox.DataSource = _actividades;

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar actividades: {ex.Message}");
			}
		}
		private void MostrarPrecioActividad()
		{
			if (cBActividades.SelectedItem is ActividadPrecios actividad)
			{
				_actividadSeleccionada = actividad;
				decimal precio = _esSocio ? actividad.PrecioMensual : actividad.PrecioDiario;
				string tipoPrecio = _esSocio ? "Mensual" : "Diario";

				lblMontoValor.Text = $"${precio:N2} ({tipoPrecio})";
			}
			else
			{
				lblMontoValor.Text = "$0.00";
			}
		}

		private void ObtenerFechas()
		{
			_fechaEmision = DateTime.Today;
			_fechaVencimiento = DateTime.Today.AddDays(30);

		}

		private bool ProcesarPago()
		{
			try
			{
				decimal monto = _esSocio ? _actividadSeleccionada.PrecioMensual : _actividadSeleccionada.PrecioDiario;

				var resultadoCarnet = VerificarPrimeraCuotaYGenerarCarnet(_persona.Id);
				string numeroCarnet = resultadoCarnet.NumeroCarnet;

				string query = @"
            INSERT INTO cuota (
                socio_id, no_socio_id, monto, fecha_emision, 
                fecha_vencimiento, nombre, apellido, estado, 
                actividad_id, es_socio
            ) VALUES (
                @socio_id, @no_socio_id, @monto, @fecha_emision,
                @fecha_vencimiento, @nombre, @apellido, @estado,
                @actividad_id, @es_socio
            )";

				MySqlParameter[] parameters = {
			new MySqlParameter("@socio_id", _esSocio ? (object)_persona.Id : DBNull.Value),
			new MySqlParameter("@no_socio_id", !_esSocio ? (object)_persona.Id : DBNull.Value),
			new MySqlParameter("@monto", monto),
			new MySqlParameter("@fecha_emision", _fechaEmision),
			new MySqlParameter("@fecha_vencimiento", _esSocio ? (object)_fechaVencimiento : DBNull.Value),
			new MySqlParameter("@nombre", _persona.Nombre),
			new MySqlParameter("@apellido", _persona.Apellido),
			new MySqlParameter("@estado", 1), // 0 = pendiente, 1 = pagado
            new MySqlParameter("@actividad_id", _actividadSeleccionada.Id),
			new MySqlParameter("@es_socio", _esSocio ? 1 : 0)
		};


				int resultado = DatabaseHelper.ExecuteNonQuery(query, parameters);


				// Si es primera cuota y es socio, actualizar el campo carnet en la tabla socio
				if (resultado > 0 && resultadoCarnet.EsPrimeraCuota && _esSocio)
				{
					ActualizarCarnetSocio(_persona.Id, numeroCarnet);
				}

				return resultado > 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al procesar el pago: {ex.Message}");
				return false;
			}
		}
		public ResultadoCarnet VerificarPrimeraCuotaYGenerarCarnet(int personaId)
		{

			try
			{
				// Verificar si es la primera cuota
				string queryVerificar = @"
            SELECT COUNT(*) as total_cuotas 
            FROM cuota 
            WHERE estado = 1 AND ((es_socio = 1 AND socio_id = @personaId))";

				MySqlParameter[] parametersVerificar = {
			new MySqlParameter("@personaId", personaId)
		};

				DataTable resultado = DatabaseHelper.ExecuteQuery(queryVerificar, parametersVerificar);

				if (resultado.Rows.Count > 0)
				{
					int totalCuotasPagadas = Convert.ToInt32(resultado.Rows[0]["total_cuotas"]);

					if (totalCuotasPagadas == 0)
					{
						// Es la primera cuota - generar número de carnet

						string numeroCarnet = GenerarNumeroCarnet(personaId);
						return new ResultadoCarnet { EsPrimeraCuota = true, NumeroCarnet = numeroCarnet };

					}
				}
				return new ResultadoCarnet { EsPrimeraCuota = false, NumeroCarnet = string.Empty };

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al verificar primera cuota: {ex.Message}");

				return new ResultadoCarnet { EsPrimeraCuota = false, NumeroCarnet = string.Empty };
			}
		}

		private string GenerarNumeroCarnet(int socioId)
		{
			// Número de carnet = socio_id + 1000
			return (socioId + 1000).ToString();
		}

		private void ActualizarCarnetSocio(int socioId, string numeroCarnet)
		{
			try
			{
				string queryActualizar = @"
            UPDATE socio 
            SET carnet = 1 
            WHERE id = @socioId";

				MySqlParameter[] parametersActualizar = {
			new MySqlParameter("@socioId", socioId)
		};

				DatabaseHelper.ExecuteNonQuery(queryActualizar, parametersActualizar);

				// Mostrar mensaje del carnet generado
				MessageBox.Show($"¡Primera cuota pagada! Número de carnet asignado: {numeroCarnet}",
							  "Carnet Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al actualizar carnet: {ex.Message}");
			}
		}



		//CLASES AUXILIARES


		public class ActividadPrecios
		{
			public int Id { get; set; }
			public string NombreActividad { get; set; } = string.Empty;
			public decimal PrecioDiario { get; set; }
			public decimal PrecioMensual { get; set; }
		}

		public class ResultadoCarnet
		{
			public bool EsPrimeraCuota { get; set; }
			public string NumeroCarnet { get; set; } = string.Empty;
		}

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
