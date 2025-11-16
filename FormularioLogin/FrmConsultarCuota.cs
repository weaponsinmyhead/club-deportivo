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

namespace FormularioLogin
{
    public partial class FrmConsultarCuota : Form
    {
        private Form formInicio;
        private int personaId = -1;
        private bool esSocio = false;

        public FrmConsultarCuota(Form frmInicio)
        {
            InitializeComponent();
            formInicio = frmInicio;
        }

        private void FrmConsultarCuota_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            LimpiarDatos();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewCuotas.AutoGenerateColumns = true;
            dataGridViewCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotas.MultiSelect = false;
            dataGridViewCuotas.AllowUserToResizeRows = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor ingrese un DNI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }

            BuscarPersonaPorDni(dni);
        }

        private void BuscarPersonaPorDni(string dni)
        {
            try
            {
                // Primero buscar en la tabla socio
                string querySocio = "SELECT id, nombre, apellido FROM socio WHERE dni = @dni";
                DataTable dtSocio = DatabaseHelper.ExecuteQuery(querySocio, new MySqlParameter("@dni", dni));

                if (dtSocio.Rows.Count > 0)
                {
                    // Encontrado en socio
                    DataRow row = dtSocio.Rows[0];
                    personaId = Convert.ToInt32(row["id"]);
                    esSocio = true;

                    lblNombreValor.Text = row["nombre"].ToString();
                    lblApellidoValor.Text = row["apellido"].ToString();
                    lblTipoMiembroValor.Text = "Socio";

                    CargarCuotasDeSocio(personaId);
                    return;
                }

                // Si no se encuentra en socio, buscar en noSocio
                string queryNoSocio = "SELECT id, nombre, apellido FROM noSocio WHERE dni = @dni";
                DataTable dtNoSocio = DatabaseHelper.ExecuteQuery(queryNoSocio, new MySqlParameter("@dni", dni));

                if (dtNoSocio.Rows.Count > 0)
                {
                    // Encontrado en noSocio
                    DataRow row = dtNoSocio.Rows[0];
                    personaId = Convert.ToInt32(row["id"]);
                    esSocio = false;

                    lblNombreValor.Text = row["nombre"].ToString();
                    lblApellidoValor.Text = row["apellido"].ToString();
                    lblTipoMiembroValor.Text = "No Socio";

                    CargarCuotasDeNoSocio(personaId);
                    return;
                }

                // No se encontró en ninguna tabla
                MessageBox.Show("No se encontró ninguna persona con ese DNI.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuotasDeSocio(int socioId)
        {
            try
            {
                string query = @"SELECT 
                    id AS 'ID',
                    monto AS 'Monto',
                    fecha_emision AS 'Fecha Emisión',
                    fecha_vencimiento AS 'Fecha Vencimiento',
                    CASE 
                        WHEN estado = 1 THEN 'Pagado'
                        ELSE 'Pendiente'
                    END AS 'Estado'
                FROM cuota 
                WHERE socio_id = @socioId AND es_socio = 1
                ORDER BY fecha_emision DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, new MySqlParameter("@socioId", socioId));
                
                if (dt.Rows.Count > 0)
                {
                    dataGridViewCuotas.DataSource = dt;
                    FormatearDataGridView();
                }
                else
                {
                    dataGridViewCuotas.DataSource = null;
                    MessageBox.Show("No se encontraron cuotas registradas para este socio.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuotas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuotasDeNoSocio(int noSocioId)
        {
            try
            {
                string query = @"SELECT 
                    id AS 'ID',
                    monto AS 'Monto',
                    fecha_emision AS 'Fecha Emisión',
                    fecha_vencimiento AS 'Fecha Vencimiento',
                    CASE 
                        WHEN estado = 1 THEN 'Pagado'
                        ELSE 'Pendiente'
                    END AS 'Estado'
                FROM cuota 
                WHERE no_socio_id = @noSocioId AND es_socio = 0
                ORDER BY fecha_emision DESC";

                DataTable dt = DatabaseHelper.ExecuteQuery(query, new MySqlParameter("@noSocioId", noSocioId));
                
                if (dt.Rows.Count > 0)
                {
                    dataGridViewCuotas.DataSource = dt;
                    FormatearDataGridView();
                }
                else
                {
                    dataGridViewCuotas.DataSource = null;
                    MessageBox.Show("No se encontraron cuotas registradas para este no socio.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuotas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearDataGridView()
        {
            if (dataGridViewCuotas.Columns.Count > 0)
            {
                // Formatear columnas de fecha
                if (dataGridViewCuotas.Columns.Contains("Fecha Emisión"))
                {
                    dataGridViewCuotas.Columns["Fecha Emisión"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                
                if (dataGridViewCuotas.Columns.Contains("Fecha Vencimiento"))
                {
                    dataGridViewCuotas.Columns["Fecha Vencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Formatear columna de monto
                if (dataGridViewCuotas.Columns.Contains("Monto"))
                {
                    dataGridViewCuotas.Columns["Monto"].DefaultCellStyle.Format = "C2";
                    dataGridViewCuotas.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Ajustar ancho de columna ID
                if (dataGridViewCuotas.Columns.Contains("ID"))
                {
                    dataGridViewCuotas.Columns["ID"].Width = 60;
                }
            }
        }

        private void LimpiarDatos()
        {
            lblNombreValor.Text = "-";
            lblApellidoValor.Text = "-";
            lblTipoMiembroValor.Text = "-";
            dataGridViewCuotas.DataSource = null;
            personaId = -1;
            esSocio = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
        }
    }
}
