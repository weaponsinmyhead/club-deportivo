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
    public partial class FrmInicio : Form
    {
        private Form FormLogin;
		public FrmInicio(Form formLogin)
        {
            InitializeComponent();
            FormLogin = formLogin;
		}


        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro(this);
            frmRegistro.Show();
            this.Hide();
        }

        private void pcuota_Click(object sender, EventArgs e)
        {
			FrmPagoCuota frmPagoCuota = new FrmPagoCuota(this);
			frmPagoCuota.Show();
			this.Hide();
		}

		private void vcuotas_Click(object sender, EventArgs e)
		{
            FrmConsultarCuota frmConsultarCuota = new FrmConsultarCuota(this);
            frmConsultarCuota.Show();
            this.Hide();
        }

        private void cuotasven_Click(object sender, EventArgs e)
        {
            FrmCuotasVencidas frmCuotasVencidas = new FrmCuotasVencidas(this);
            frmCuotasVencidas.Show();
            this.Hide();
        }
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
			FormLogin.Show();
		}

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
