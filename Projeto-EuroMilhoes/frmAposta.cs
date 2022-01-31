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
    public partial class frmAposta : Form
    {
        public frmAposta()
        {
            InitializeComponent();
        }
        //Escolher 5 números e 2 estrelas
        private void cbN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbN1.SelectedIndex < 9)
            {
                lblN1.Text = "0" + cbN1.SelectedItem.ToString();
            }
            else
            {
                lblN1.Text = cbN1.SelectedItem.ToString();
            }
        }

        private void cbN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbN2.SelectedIndex < 9)
            {
                lblN2.Text = "0" + cbN2.SelectedItem.ToString();
            }
            else
            {
                lblN2.Text = cbN2.SelectedItem.ToString();
            }
        }

        private void cbN3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbN3.SelectedIndex < 9)
            {
                lblN3.Text = "0" + cbN3.SelectedItem.ToString();
            }
            else
            {
                lblN3.Text = cbN3.SelectedItem.ToString();
            }
        }

        private void cbN4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbN4.SelectedIndex < 9)
            {
                lblN4.Text = "0" + cbN4.SelectedItem.ToString();
            }
            else
            {
                lblN4.Text = cbN4.SelectedItem.ToString();
            }
        }

        private void cbN5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbN5.SelectedIndex < 9)
            {
                lblN5.Text = "0" + cbN5.SelectedItem.ToString();
            }
            else
            {
                lblN5.Text = cbN5.SelectedItem.ToString();
            }
        }

        private void cbE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbE1.SelectedIndex < 9)
            {
                lblE1.Text = "0" + cbE1.SelectedItem.ToString();
            }
            else
            {
                lblE1.Text = cbE1.SelectedItem.ToString();
            }
        }

        private void cbE2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbE2.SelectedIndex < 9)
            {
                lblE2.Text = "0" + cbE2.SelectedItem.ToString();
            }
            else
            {
                lblE2.Text = cbE2.SelectedItem.ToString();
            }
        }

        //Voltar para o form principal com os números e as estrelas escolhidas
        private void button1_Click(object sender, EventArgs e)
        {
            //Caso se escolha um número ou uma estrela igual
            if (lblN1.Text == lblN2.Text || lblN1.Text == lblN3.Text || lblN1.Text == lblN4.Text || lblN1.Text == lblN5.Text || lblN2.Text == lblN3.Text || lblN2.Text == lblN4.Text || lblN2.Text == lblN5.Text || lblN3.Text == lblN4.Text || lblN3.Text == lblN5.Text || lblN4.Text == lblN5.Text || lblE1.Text == lblE2.Text)
            {
                MessageBox.Show("Os Números da Sorte / as Estrelas \nnão podem ser iguais entre si.", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                frmResultado.bTesteAposta = true;
                frmPrincipal.sN1 = lblN1.Text;
                frmPrincipal.sN2 = lblN2.Text;
                frmPrincipal.sN3 = lblN3.Text;
                frmPrincipal.sN4 = lblN4.Text;
                frmPrincipal.sN5 = lblN5.Text;
                frmPrincipal.sE1 = lblE1.Text;
                frmPrincipal.sE2 = lblE2.Text;
                this.Close();
            }
        }
    }
}
