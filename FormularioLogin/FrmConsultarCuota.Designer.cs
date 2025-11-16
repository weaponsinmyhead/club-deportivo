namespace FormularioLogin
{
    partial class FrmConsultarCuota
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
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblTipoMiembro = new System.Windows.Forms.Label();
            this.lblTipoMiembroValor = new System.Windows.Forms.Label();
            this.dataGridViewCuotas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCuotas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Consultar Cuotas";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(30, 80);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(40, 20);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(120, 77);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 26);
            this.txtDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(340, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Location = new System.Drawing.Point(120, 130);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(14, 20);
            this.lblNombreValor.TabIndex = 5;
            this.lblNombreValor.Text = "-";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(30, 160);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.Location = new System.Drawing.Point(120, 160);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(14, 20);
            this.lblApellidoValor.TabIndex = 7;
            this.lblApellidoValor.Text = "-";
            // 
            // lblTipoMiembro
            // 
            this.lblTipoMiembro.AutoSize = true;
            this.lblTipoMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoMiembro.Location = new System.Drawing.Point(30, 190);
            this.lblTipoMiembro.Name = "lblTipoMiembro";
            this.lblTipoMiembro.Size = new System.Drawing.Size(50, 20);
            this.lblTipoMiembro.TabIndex = 8;
            this.lblTipoMiembro.Text = "Tipo:";
            // 
            // lblTipoMiembroValor
            // 
            this.lblTipoMiembroValor.AutoSize = true;
            this.lblTipoMiembroValor.Location = new System.Drawing.Point(120, 190);
            this.lblTipoMiembroValor.Name = "lblTipoMiembroValor";
            this.lblTipoMiembroValor.Size = new System.Drawing.Size(14, 20);
            this.lblTipoMiembroValor.TabIndex = 9;
            this.lblTipoMiembroValor.Text = "-";
            // 
            // dataGridViewCuotas
            // 
            this.dataGridViewCuotas.AllowUserToAddRows = false;
            this.dataGridViewCuotas.AllowUserToDeleteRows = false;
            this.dataGridViewCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotas.Location = new System.Drawing.Point(30, 250);
            this.dataGridViewCuotas.Name = "dataGridViewCuotas";
            this.dataGridViewCuotas.ReadOnly = true;
            this.dataGridViewCuotas.RowHeadersWidth = 62;
            this.dataGridViewCuotas.Size = new System.Drawing.Size(740, 250);
            this.dataGridViewCuotas.TabIndex = 10;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(340, 520);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 40);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCuotas.Location = new System.Drawing.Point(30, 220);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(194, 25);
            this.lblCuotas.TabIndex = 12;
            this.lblCuotas.Text = "Historial de Cuotas";
            // 
            // FrmConsultarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewCuotas);
            this.Controls.Add(this.lblTipoMiembroValor);
            this.Controls.Add(this.lblTipoMiembro);
            this.Controls.Add(this.lblApellidoValor);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cuotas";
            this.Load += new System.EventHandler(this.FrmConsultarCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblApellidoValor;
        private System.Windows.Forms.Label lblTipoMiembro;
        private System.Windows.Forms.Label lblTipoMiembroValor;
        private System.Windows.Forms.DataGridView dataGridViewCuotas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCuotas;
    }
}