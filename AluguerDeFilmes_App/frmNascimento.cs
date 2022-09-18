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
    public partial class frmNascimento : Form
    {
        bool bDia, bMes, bAno;
        public frmNascimento()
        {
            InitializeComponent();
        }

        private void sbDia_Scroll(object sender, ScrollEventArgs e)
        {
            lblDia.Visible = true;
            bDia = true;
            label7.Visible = true;
            label9.Visible = true;
            lblDia.Text = sbDia.Value.ToString();
        }

        private void sbMes_Scroll(object sender, ScrollEventArgs e)
        {
            lblMes.Visible = true;
            bMes = true;
            label7.Visible = true;
            label9.Visible = true;
            lblMes.Text = sbMes.Value.ToString();
        }

        private void sbAno_Scroll(object sender, ScrollEventArgs e)
        {
            lblAno.Visible = true;
            bAno = true;
            label7.Visible = true;
            label9.Visible = true;
            lblAno.Text = sbAno.Value.ToString();
        }

        private void tmTudo_Tick(object sender, EventArgs e)
        {
            //Verificar Mês e ano bissexto
            if (sbMes.Value == 4 || sbMes.Value == 6 || sbMes.Value == 9 || sbMes.Value == 11)
            {
                sbDia.Maximum = 30;
            }
            else
            {
                sbDia.Maximum = 31;
            }
            if (sbMes.Value == 2 && (sbAno.Value == 2024 || sbAno.Value == 2028 || sbAno.Value == 2032 || sbAno.Value == 2036 || sbAno.Value == 2040 || sbAno.Value == 2044 || sbAno.Value == 2048))
            {
                sbDia.Maximum = 29;
            }
            else if (sbMes.Value == 2 && (sbAno.Value != 2024 || sbAno.Value != 2028 || sbAno.Value != 2032 || sbAno.Value != 2036 || sbAno.Value != 2040 || sbAno.Value != 2044 || sbAno.Value != 2048))
            {
                sbDia.Maximum = 28;
            }
            //Verificar 0 antes do número
            if (sbDia.Value < 10)
            {
                lblDia.Text = "0" + sbDia.Value.ToString();
            }
            else
            {
                lblDia.Text = sbDia.Value.ToString();
            }
            if (sbMes.Value < 10)
            {
                lblMes.Text = "0" + sbMes.Value.ToString();
            }
            else
            {
                lblMes.Text = sbMes.Value.ToString();
            }
            lblAno.Text = sbAno.Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (bDia == true && bMes == true && bAno == true)
            {
                frmRegistar.sDia = lblDia.Text;
                frmRegistar.sMes = lblMes.Text;
                frmRegistar.sAno = lblAno.Text;
                frmRegistar.bTeste = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos - Dia, Mês e Ano.", "AVISO");
            }
        }

        private void frmNascimento_Load(object sender, EventArgs e)
        {

        }
    }
}
