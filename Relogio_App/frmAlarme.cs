using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relógio
{
    public partial class frmAlarme : Form
    {
        System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();

        public static bool bTeste1 = false, bTeste2;
        public static string sFicheiro;

        public frmAlarme()
        {            
            InitializeComponent();
            Musica.SoundLocation = "musicwav.wav";
            Musica.Stop();
        }

        private void sbHoras_Scroll(object sender, ScrollEventArgs e)
        {
            lblHoras.Text = sbHoras.Value.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal.sHoras = lblHoras.Text;
            frmPrincipal.sMinutos = lblMinutos.Text;
            frmPrincipal.sDia = lblDia.Text;
            frmPrincipal.sMes = lblMes.Text;
            frmPrincipal.sAno = lblAno.Text;
            this.Close();
        }

        private void sbMinutos_Scroll(object sender, ScrollEventArgs e)
        {
            lblMinutos.Text = sbMinutos.Value.ToString();
        }
        private void frmAlarme_Activated(object sender, EventArgs e)
        {            
            Musica.Stop();
            frmToque.sFicheiro = sFicheiro;
            sbHoras.Value = DateTime.Now.Hour;
            sbMinutos.Value = DateTime.Now.Minute;            
            sbDia.Value = DateTime.Now.Day;
            sbMes.Value = DateTime.Now.Month;
            sbAno.Value = DateTime.Now.Year;
            if (sbHoras.Value < 10)
            {
                lblHoras.Text = "0" + sbHoras.Value.ToString();
            }
            else
            {
                lblHoras.Text = sbHoras.Value.ToString();
            }
            if (sbMinutos.Value < 10)
            {
                lblMinutos.Text = "0" + sbMinutos.Value.ToString();
            }
            else
            {
                lblMinutos.Text = sbMinutos.Value.ToString();
            }
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
            if (bTeste1 == false)
            {
                frmPrincipal.bTeste1 = true;
                frmPrincipal.bTeste2 = true;
                this.Close();
            }
        }

        private void sbDia_Scroll(object sender, ScrollEventArgs e)
        {
            lblDia.Text = sbDia.Value.ToString();
        }

        private void sbMes_Scroll(object sender, ScrollEventArgs e)
        {
            lblMes.Text = sbMes.Value.ToString();
        }

        private void sbAno_Scroll(object sender, ScrollEventArgs e)
        {
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
            if (sbHoras.Value < 10)
            {
                lblHoras.Text = "0" + sbHoras.Value.ToString();
            }
            else
            {
                lblHoras.Text = sbHoras.Value.ToString();
            }
            if (sbMinutos.Value < 10)
            {
                lblMinutos.Text = "0" + sbMinutos.Value.ToString();
            }
            else
            {
                lblMinutos.Text = sbMinutos.Value.ToString();
            }
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

        private void frmAlarme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.sHoras = lblHoras.Text;
            frmPrincipal.sMinutos = lblMinutos.Text;
            frmPrincipal.sDia = lblDia.Text;
            frmPrincipal.sMes = lblMes.Text;
            frmPrincipal.sAno = lblAno.Text;
        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            Form frmToque = new frmToque();
            frmToque.Show();
            tm1.Enabled = false;
        }

        private void btnDescrição_Click(object sender, EventArgs e)
        {
            Form frmDesc = new frmDesc();
            frmDesc.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmAlarme_Load(object sender, EventArgs e)
        {

        }

        private void lblMes_Click(object sender, EventArgs e)
        {

        }

        private void btnMudarSom_Click(object sender, EventArgs e)
        {
            frmToque.sFicheiro = sFicheiro;
            tm1.Enabled = true;
        }

    }
}
