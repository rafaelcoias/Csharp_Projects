using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Base_de_Dados
{
    public partial class frmAdminPrincipal : Form
    {
        public frmAdminPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Quer Terminar Sessão?", "Verificação", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUtilizadores_Click(object sender, EventArgs e)
        {
            Form frmUtilizadores = new frmUtilizadores();
            frmUtilizadores.Show();
        }

        private void btnAlugueres_Click(object sender, EventArgs e)
        {
            Form frmTabAluguer = new frmTabAluguer();
            frmTabAluguer.Show();
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            Form frmTabFilmes = new frmTabFilmes();
            frmTabFilmes.Show();
        }
    }
}
