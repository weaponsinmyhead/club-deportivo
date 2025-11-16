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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(268, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cuotas - Vencimientos";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDni.Location = new System.Drawing.Point(270, 53);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(330, 51);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(135, 20);
            this.txtDni.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(477, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(270, 74);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombreValor.Location = new System.Drawing.Point(330, 74);
            this.lblNombreValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(10, 13);
            this.lblNombreValor.TabIndex = 5;
            this.lblNombreValor.Text = "-";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellido.Location = new System.Drawing.Point(270, 94);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoValor.Location = new System.Drawing.Point(330, 94);
            this.lblApellidoValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(10, 13);
            this.lblApellidoValor.TabIndex = 7;
            this.lblApellidoValor.Text = "-";
            // 
            // lblTipoMiembro
            // 
            this.lblTipoMiembro.AutoSize = true;
            this.lblTipoMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoMiembro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTipoMiembro.Location = new System.Drawing.Point(270, 113);
            this.lblTipoMiembro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoMiembro.Name = "lblTipoMiembro";
            this.lblTipoMiembro.Size = new System.Drawing.Size(36, 13);
            this.lblTipoMiembro.TabIndex = 8;
            this.lblTipoMiembro.Text = "Tipo:";
            // 
            // lblTipoMiembroValor
            // 
            this.lblTipoMiembroValor.AutoSize = true;
            this.lblTipoMiembroValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTipoMiembroValor.Location = new System.Drawing.Point(330, 113);
            this.lblTipoMiembroValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoMiembroValor.Name = "lblTipoMiembroValor";
            this.lblTipoMiembroValor.Size = new System.Drawing.Size(10, 13);
            this.lblTipoMiembroValor.TabIndex = 9;
            this.lblTipoMiembroValor.Text = "-";
            // 
            // dataGridViewCuotas
            // 
            this.dataGridViewCuotas.AllowUserToAddRows = false;
            this.dataGridViewCuotas.AllowUserToDeleteRows = false;
            this.dataGridViewCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotas.Location = new System.Drawing.Point(267, 157);
            this.dataGridViewCuotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCuotas.Name = "dataGridViewCuotas";
            this.dataGridViewCuotas.ReadOnly = true;
            this.dataGridViewCuotas.RowHeadersWidth = 62;
            this.dataGridViewCuotas.Size = new System.Drawing.Size(493, 162);
            this.dataGridViewCuotas.TabIndex = 10;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(680, 120);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(80, 26);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCuotas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCuotas.Location = new System.Drawing.Point(270, 129);
            this.lblCuotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(146, 17);
            this.lblCuotas.TabIndex = 12;
            this.lblCuotas.Text = "Historial de Cuotas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 36;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::FormularioLogin.Properties.Resources.ClubDepPic;
            this.picLogo.Location = new System.Drawing.Point(12, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(227, 246);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 33;
            this.picLogo.TabStop = false;
            // 
            // FrmConsultarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.panel1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cuotas";
            this.Load += new System.EventHandler(this.FrmConsultarCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}