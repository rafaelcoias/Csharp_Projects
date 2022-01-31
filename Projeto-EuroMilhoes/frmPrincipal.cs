using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EuroMilhoes
{
    public partial class frmPrincipal : Form
    {
        //Variáveis
        public static string sN1, sN2, sN3, sN4, sN5, sE1, sE2;

        private void btnProxima_Click(object sender, EventArgs e)
        {
            //Fazer Premio aleatório
            Random rndPremio = new Random();
            iPremio = rndPremio.Next(10, 100);
            lblPremio.Text = iPremio + " ´ 000 ´ 000 €";
            //Reiniciar tudo
            btnApostar.Visible = true;
            btnResultado.Visible = true;
            lblNumeros.Visible = false;
            lblEstrelas.Visible = false;
            sN1 = " ";
            sN2 = "";
            sN3 = "";
            sN4 = "";
            sN5 = "";
            sE1 = "";
            sE2 = "";
            frmResultado.sPremio = lblPremio.Text;
            frmResultado.bTesteAposta = false;
            frmResultado.sN1 = sN1;
            frmResultado.sN2 = sN2;
            frmResultado.sN3 = sN3;
            frmResultado.sN4 = sN4;
            frmResultado.sN5 = sN5;
            frmResultado.sE1 = sE1;
            frmResultado.sE2 = sE2;
        }

        private void btnSemanas_Click(object sender, EventArgs e)
        {
            frmHistorico frmHistorico = new frmHistorico();
            frmHistorico.Show();
        }

        int iPremio;

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            //Passar a Aposta para o form Principal
            lblNumeros.Text = "Números da Sorte : " + sN1 + " " + sN2 + " " + sN3 + " " + sN4 + " " + sN5;
            lblEstrelas.Text = "Estrelas : " + sE1 + " " + sE2;
            frmResultado.sPremio = lblPremio.Text;
            frmResultado.sN1 = sN1;
            frmResultado.sN2 = sN2;
            frmResultado.sN3 = sN3;
            frmResultado.sN4 = sN4;
            frmResultado.sN5 = sN5;
            frmResultado.sE1 = sE1;
            frmResultado.sE2 = sE2;
        }

        public frmPrincipal()
        {
            InitializeComponent();
            //Fazer Premio aleatório
            Random rndPremio = new Random();
            iPremio = rndPremio.Next(10, 100);
            lblPremio.Text = iPremio + " ´ 000 ´ 000 €";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Ir para o form do resultado
            lblNumeros.Visible = true;
            lblEstrelas.Visible = true;
            btnResultado.Visible = false;
            btnApostar.Visible = false;
            Form frmResultado = new frmResultado();
            frmResultado.Show();
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            //Ir para o form Aposta e abilitar os números da sorte escolhidos
            btnApostar.Visible = false;
            Form frmAposta = new frmAposta();
            frmAposta.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
