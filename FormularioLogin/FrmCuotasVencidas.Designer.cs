namespace FormularioLogin
{
    partial class FrmCuotasVencidas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
            this.chkSoloActivos = new System.Windows.Forms.CheckBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.dataGridViewCuotasVencidas = new System.Windows.Forms.DataGridView();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblTotalCuotas = new System.Windows.Forms.Label();
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasVencidas)).BeginInit();
            this.panelResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(233, 13);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuotas Vencidas - Socios";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.LightYellow;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.panelFiltros.Controls.Add(this.btnAplicarFiltros);
            this.panelFiltros.Controls.Add(this.chkMostrarInactivos);
            this.panelFiltros.Controls.Add(this.chkSoloActivos);
            this.panelFiltros.Controls.Add(this.lblFiltros);
            this.panelFiltros.Location = new System.Drawing.Point(20, 46);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1023, 53);
            this.panelFiltros.TabIndex = 1;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(520, 16);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(67, 23);
            this.btnLimpiarFiltros.TabIndex = 4;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(433, 16);
            this.btnAplicarFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(73, 23);
            this.btnAplicarFiltros.TabIndex = 3;
            this.btnAplicarFiltros.Text = "Aplicar";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.Location = new System.Drawing.Point(213, 21);
            this.chkMostrarInactivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(128, 17);
            this.chkMostrarInactivos.TabIndex = 2;
            this.chkMostrarInactivos.Text = "Mostrar solo inactivos";
            this.chkMostrarInactivos.UseVisualStyleBackColor = true;
            this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
            // 
            // chkSoloActivos
            // 
            this.chkSoloActivos.AutoSize = true;
            this.chkSoloActivos.Checked = true;
            this.chkSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloActivos.Location = new System.Drawing.Point(87, 21);
            this.chkSoloActivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSoloActivos.Name = "chkSoloActivos";
            this.chkSoloActivos.Size = new System.Drawing.Size(120, 17);
            this.chkSoloActivos.TabIndex = 1;
            this.chkSoloActivos.Text = "Mostrar solo activos";
            this.chkSoloActivos.UseVisualStyleBackColor = true;
            this.chkSoloActivos.CheckedChanged += new System.EventHandler(this.chkSoloActivos_CheckedChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.Location = new System.Drawing.Point(10, 21);
            this.lblFiltros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(51, 15);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtros:";
            // 
            // dataGridViewCuotasVencidas
            // 
            this.dataGridViewCuotasVencidas.AllowUserToAddRows = false;
            this.dataGridViewCuotasVencidas.AllowUserToDeleteRows = false;
            this.dataGridViewCuotasVencidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuotasVencidas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCuotasVencidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotasVencidas.Location = new System.Drawing.Point(20, 110);
            this.dataGridViewCuotasVencidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCuotasVencidas.Name = "dataGridViewCuotasVencidas";
            this.dataGridViewCuotasVencidas.ReadOnly = true;
            this.dataGridViewCuotasVencidas.RowHeadersWidth = 62;
            this.dataGridViewCuotasVencidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuotasVencidas.Size = new System.Drawing.Size(1023, 227);
            this.dataGridViewCuotasVencidas.TabIndex = 2;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumen.Location = new System.Drawing.Point(10, 6);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(72, 15);
            this.lblResumen.TabIndex = 3;
            this.lblResumen.Text = "Resumen:";
            // 
            // lblTotalCuotas
            // 
            this.lblTotalCuotas.AutoSize = true;
            this.lblTotalCuotas.Location = new System.Drawing.Point(93, 8);
            this.lblTotalCuotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCuotas.Name = "lblTotalCuotas";
            this.lblTotalCuotas.Size = new System.Drawing.Size(93, 13);
            this.lblTotalCuotas.TabIndex = 4;
            this.lblTotalCuotas.Text = "Total de cuotas: 0";
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.AutoSize = true;
            this.lblTotalMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalMonto.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalMonto.Location = new System.Drawing.Point(267, 8);
            this.lblTotalMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(111, 13);
            this.lblTotalMonto.TabIndex = 5;
            this.lblTotalMonto.Text = "Monto total: $0.00";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(950, 380);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 26);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(837, 380);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 26);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar a CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panelResumen
            // 
            this.panelResumen.BackColor = System.Drawing.Color.LightCyan;
            this.panelResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen.Controls.Add(this.lblResumen);
            this.panelResumen.Controls.Add(this.lblTotalCuotas);
            this.panelResumen.Controls.Add(this.lblTotalMonto);
            this.panelResumen.Location = new System.Drawing.Point(20, 346);
            this.panelResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(1023, 30);
            this.panelResumen.TabIndex = 8;
            // 
            // FrmCuotasVencidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1072, 416);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewCuotasVencidas);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCuotasVencidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuotas Vencidas";
            this.Load += new System.EventHandler(this.FrmCuotasVencidas_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasVencidas)).EndInit();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.CheckBox chkSoloActivos;
        private System.Windows.Forms.CheckBox chkMostrarInactivos;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridView dataGridViewCuotasVencidas;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblTotalCuotas;
        private System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel panelResumen;
    }
}