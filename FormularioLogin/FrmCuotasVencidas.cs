using MySqlConnector;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FrmCuotasVencidas : Form
    {
        private Form formInicio;
        private DataTable datosActuales;

        public FrmCuotasVencidas(Form frmInicio)
        {
            InitializeComponent();
            formInicio = frmInicio;
        }

        private void FrmCuotasVencidas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            // Cargar sin filtros por defecto para ver todos los registros
            chkSoloActivos.Checked = false;
            chkMostrarInactivos.Checked = false;
            CargarCuotasVencidas();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewCuotasVencidas.AutoGenerateColumns = true;
            dataGridViewCuotasVencidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCuotasVencidas.MultiSelect = false;
            dataGridViewCuotasVencidas.AllowUserToResizeRows = false;
            dataGridViewCuotasVencidas.RowHeadersVisible = false;
            dataGridViewCuotasVencidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCuotasVencidas.ScrollBars = ScrollBars.Both;
        }

        private void CargarCuotasVencidas()
        {
            try
            {
                // Determinar el filtro de estado
                string filtroEstado = "";
                if (chkSoloActivos.Checked && !chkMostrarInactivos.Checked)
                {
                    filtroEstado = " AND COALESCE(s.estado, 1) = 1";
                }
                else if (!chkSoloActivos.Checked && chkMostrarInactivos.Checked)
                {
                    filtroEstado = " AND COALESCE(s.estado, 1) = 0";
                }
                // Si ambos están marcados o ninguno, no aplicamos filtro de estado

                string query = $@"
                    SELECT 
                        c.id AS 'ID Cuota',
                        s.id AS 'ID Socio',
                        s.dni AS 'DNI',
                        s.nombre AS 'Nombre',
                        s.apellido AS 'Apellido',
                        s.email AS 'Email',
                        CASE 
                            WHEN COALESCE(s.estado, 1) = 1 THEN 'Activo'
                            ELSE 'Inactivo'
                        END AS 'Estado',
                        CASE 
                            WHEN COALESCE(s.carnet, 0) = 1 THEN 'Posee carnet'
                            ELSE 'No posee carnet'
                        END AS 'Carnet',
                        c.monto AS 'Monto',
                        DATE_FORMAT(c.fecha_emision, '%d/%m/%Y') AS 'Fecha Emisión Cuota',
                        DATE_FORMAT(c.fecha_vencimiento, '%d/%m/%Y') AS 'Fecha Vencimiento',
                        DATEDIFF(CURDATE(), c.fecha_vencimiento) AS 'Días Vencidos',
                        CASE 
                            WHEN COALESCE(c.estado, 0) = 1 THEN 'Pagado'
                            ELSE 'Pendiente'
                        END AS 'Estado Cuota'
                    FROM cuota c
                    INNER JOIN socio s ON c.socio_id = s.id
                    WHERE c.es_socio = 1 
                        AND c.fecha_vencimiento != '0000-00-00'
                        AND c.fecha_vencimiento < CURDATE()
                        AND COALESCE(c.estado, 0) != 1
                        {filtroEstado}
                    ORDER BY c.fecha_vencimiento ASC, s.apellido ASC, s.nombre ASC";

                datosActuales = DatabaseHelper.ExecuteQuery(query);

                if (datosActuales.Rows.Count > 0)
                {
                    dataGridViewCuotasVencidas.DataSource = datosActuales;
                    FormatearDataGridView();
                    ActualizarResumen();
                }
                else
                {
                    dataGridViewCuotasVencidas.DataSource = null;
                    LimpiarResumen();
                    MessageBox.Show("No se encontraron cuotas vencidas con los filtros aplicados.", 
                        "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuotas vencidas: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearDataGridView()
        {
            if (dataGridViewCuotasVencidas.Columns.Count > 0)
            {
                // Ajustar ancho de columnas específicas
                if (dataGridViewCuotasVencidas.Columns.Contains("ID Cuota"))
                    dataGridViewCuotasVencidas.Columns["ID Cuota"].Width = 70;

                if (dataGridViewCuotasVencidas.Columns.Contains("ID Socio"))
                    dataGridViewCuotasVencidas.Columns["ID Socio"].Width = 70;

                if (dataGridViewCuotasVencidas.Columns.Contains("DNI"))
                    dataGridViewCuotasVencidas.Columns["DNI"].Width = 100;

                if (dataGridViewCuotasVencidas.Columns.Contains("Nombre"))
                    dataGridViewCuotasVencidas.Columns["Nombre"].Width = 120;

                if (dataGridViewCuotasVencidas.Columns.Contains("Apellido"))
                    dataGridViewCuotasVencidas.Columns["Apellido"].Width = 120;

                if (dataGridViewCuotasVencidas.Columns.Contains("Estado"))
                    dataGridViewCuotasVencidas.Columns["Estado"].Width = 80;

                if (dataGridViewCuotasVencidas.Columns.Contains("Carnet"))
                    dataGridViewCuotasVencidas.Columns["Carnet"].Width = 120;

                if (dataGridViewCuotasVencidas.Columns.Contains("Días Vencidos"))
                {
                    dataGridViewCuotasVencidas.Columns["Días Vencidos"].Width = 100;
                    dataGridViewCuotasVencidas.Columns["Días Vencidos"].DefaultCellStyle.Alignment = 
                        DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewCuotasVencidas.Columns["Días Vencidos"].DefaultCellStyle.BackColor = 
                        System.Drawing.Color.LightCoral;
                }

                // Formatear columna de monto
                if (dataGridViewCuotasVencidas.Columns.Contains("Monto"))
                {
                    dataGridViewCuotasVencidas.Columns["Monto"].DefaultCellStyle.Format = "C2";
                    dataGridViewCuotasVencidas.Columns["Monto"].DefaultCellStyle.Alignment = 
                        DataGridViewContentAlignment.MiddleRight;
                    dataGridViewCuotasVencidas.Columns["Monto"].Width = 100;
                }

                // Aplicar formato especial a estado
                if (dataGridViewCuotasVencidas.Columns.Contains("Estado"))
                {
                    foreach (DataGridViewRow row in dataGridViewCuotasVencidas.Rows)
                    {
                        if (row.Cells["Estado"].Value?.ToString() == "Inactivo")
                        {
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                        }
                    }
                }

                // Colorear filas según días vencidos
                foreach (DataGridViewRow row in dataGridViewCuotasVencidas.Rows)
                {
                    if (row.Cells["Días Vencidos"].Value != null)
                    {
                        int diasVencidos = Convert.ToInt32(row.Cells["Días Vencidos"].Value);
                        
                        if (diasVencidos > 90)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
                        }
                        else if (diasVencidos > 30)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        }
                    }
                }
            }
        }

        private void ActualizarResumen()
        {
            if (datosActuales != null && datosActuales.Rows.Count > 0)
            {
                int totalCuotas = datosActuales.Rows.Count;
                decimal montoTotal = 0;

                foreach (DataRow row in datosActuales.Rows)
                {
                    if (row["Monto"] != DBNull.Value)
                    {
                        montoTotal += Convert.ToDecimal(row["Monto"]);
                    }
                }

                lblTotalCuotas.Text = $"Total de cuotas vencidas: {totalCuotas}";
                lblTotalMonto.Text = $"Monto total adeudado: {montoTotal:C2}";
            }
            else
            {
                LimpiarResumen();
            }
        }

        private void LimpiarResumen()
        {
            lblTotalCuotas.Text = "Total de cuotas vencidas: 0";
            lblTotalMonto.Text = "Monto total adeudado: $0.00";
        }

        private void chkSoloActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoloActivos.Checked)
            {
                chkMostrarInactivos.Checked = false;
            }
        }

        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarInactivos.Checked)
            {
                chkSoloActivos.Checked = false;
            }
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            CargarCuotasVencidas();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            chkSoloActivos.Checked = false;
            chkMostrarInactivos.Checked = false;
            CargarCuotasVencidas();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (datosActuales == null || datosActuales.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivo CSV (*.csv)|*.csv",
                    FileName = $"CuotasVencidas_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                    Title = "Exportar a CSV"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportarACSV(saveFileDialog.FileName);
                    MessageBox.Show($"Datos exportados exitosamente a:\n{saveFileDialog.FileName}", 
                        "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarACSV(string rutaArchivo)
        {
            StringBuilder csv = new StringBuilder();

            // Escribir encabezados
            string[] columnas = new string[datosActuales.Columns.Count];
            for (int i = 0; i < datosActuales.Columns.Count; i++)
            {
                columnas[i] = datosActuales.Columns[i].ColumnName;
            }
            csv.AppendLine(string.Join(",", columnas));

            // Escribir datos
            foreach (DataRow row in datosActuales.Rows)
            {
                string[] campos = new string[datosActuales.Columns.Count];
                for (int i = 0; i < datosActuales.Columns.Count; i++)
                {
                    string valor = row[i].ToString();
                    // Escapar comillas y encerrar en comillas si contiene coma
                    if (valor.Contains(",") || valor.Contains("\""))
                    {
                        valor = $"\"{valor.Replace("\"", "\"\"")}\"";
                    }
                    campos[i] = valor;
                }
                csv.AppendLine(string.Join(",", campos));
            }

            // Escribir al archivo con codificación UTF-8
            File.WriteAllText(rutaArchivo, csv.ToString(), Encoding.UTF8);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
        }
    }
}