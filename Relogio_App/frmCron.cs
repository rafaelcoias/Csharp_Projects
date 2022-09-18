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
    public partial class frmCron : Form
    {
        public static int iMilesimos = 0, iSegundos = 0, iMinutos = 0;
        public static bool bTeste = false;
        public frmCron()
        {
            InitializeComponent();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            if (bTeste == false)
            {
                bTeste = true;
                lblVolta.Visible = true;
                lblVolta.Text = "Volta1 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta.Visible == true && lblVolta2.Visible == false)
            {
                lblVolta2.Visible = true;
                lblVolta2.Text = "Volta2 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta2.Visible == true && lblVolta3.Visible == false)
            {
                lblVolta3.Visible = true;
                lblVolta3.Text = "Volta3 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta3.Visible == true && lblVolta4.Visible == false)
            {
                lblVolta4.Visible = true;
                lblVolta4.Text = "Volta4 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta4.Visible == true && lblVolta5.Visible == false)
            {
                lblVolta5.Visible = true;
                lblVolta5.Text = "Volta5 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta5.Visible == true && lblVolta6.Visible == false)
            {
                lblVolta6.Visible = true;
                lblVolta6.Text = "Volta6 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta6.Visible == true && lblVolta7.Visible == false)
            {
                lblVolta7.Visible = true;
                lblVolta7.Text = "Volta7 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta7.Visible == true && lblVolta8.Visible == false)
            {
                lblVolta8.Visible = true;
                lblVolta8.Text = "Volta8 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
            else if (lblVolta8.Visible == true)
            {
                lblVolta9.Visible = true;
                lblVolta9.Text = "Volta9 - " + lblMinutos.Text + " : " + lblSegundos.Text + " : " + lblMil.Text;
            }
        }

        private void btnRepor_Click(object sender, EventArgs e)
        {
            btnRetomar.Visible = false;
            btnRepor.Visible = false;
            bTeste = false;
            lblVolta.Visible = false;
            lblVolta2.Visible = false;
            lblVolta3.Visible = false;
            lblVolta4.Visible = false;
            lblVolta5.Visible = false;
            lblVolta6.Visible = false;
            lblVolta7.Visible = false;
            lblVolta8.Visible = false;
            lblVolta9.Visible = false;
            btnIniciar.Visible = true;
            iMilesimos = 0; iSegundos = 0; iMinutos = 0;
            lblMinutos.Text = "00"; lblSegundos.Text = "00"; lblMil.Text = "00";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            tmCron.Enabled = false;
            btnParar.Visible = false;
            btnVolta.Visible = false;
            btnRetomar.Visible = true;
            btnRepor.Visible = true;
        }

        private void btnRetomar_Click(object sender, EventArgs e)
        {
            btnParar.Visible = true;
            btnRetomar.Visible = false;
            btnVolta.Visible = true;
            btnRepor.Visible = false;
            tmCron.Enabled = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmCron.Enabled = true;
            btnIniciar.Visible = false;
            btnVolta.Visible = true;
            btnParar.Visible = true;
        }

        private void tmCron_Tick(object sender, EventArgs e)
        {
            iMilesimos++;
            lblMil.Text = "0" + iMilesimos.ToString();
            if (iMilesimos == 10)
            {
                iSegundos++;
                iMilesimos = -1;
            }
            if (iSegundos < 10)
            {
                lblSegundos.Text = "0" + iSegundos.ToString();
            }
            else
            {
                lblSegundos.Text = iSegundos.ToString();
            }
            if (iSegundos == 60)
            {
                iSegundos = 0;
                iMinutos++;
            }
            if (iMinutos < 10)
            {
                lblMinutos.Text = "0" + iMinutos.ToString();
            }
            else
            {
                lblMinutos.Text = iMinutos.ToString();
            }
        }
    }
}
