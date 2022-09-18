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
    public partial class frmRMundial : Form
    {
        public static int iHora, iMinuto, iSegundo, iDia, iR;
        public frmRMundial()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmLondres_Tick(object sender, EventArgs e)
        {
            lblLondres.Text = DateTime.Now.ToString("HH : mm : ss");
            lblDiaL.Text = DateTime.Now.ToString("dd / MM");
        }

        private void tmMadrid_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 23)
            {
                iDia = DateTime.Now.Day;
                iDia = iDia + 1;
                iHora = 0;
            }
            else
            {
                iDia = DateTime.Now.Day;
                iHora = DateTime.Now.Hour;
                iHora = iHora + 1;
            }            
            if (iHora < 10)
            {
                lblMadrid.Text = "0" + iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            else
            {
                lblMadrid.Text = iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            if (iDia < 10)
            {
                lblDiaM.Text = "0" + iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
            else
            {
                lblDiaM.Text = iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
        }

        private void tmNova_Tick(object sender, EventArgs e)
        {
            iDia = DateTime.Now.Day;
            if (DateTime.Now.Hour == 4)
            {
                iDia = iDia - 1;
                iHora = 23;
            }
            else if (DateTime.Now.Hour == 3)
            {
                iDia = iDia - 1;
                iHora = 22;
            }
            else if (DateTime.Now.Hour == 2)
            {
                iDia = iDia - 1;
                iHora = 21;
            }
            else if (DateTime.Now.Hour == 1)
            {
                iDia = iDia - 1;
                iHora = 20;
            }
            else if (DateTime.Now.Hour == 0)
            {
                iDia = iDia - 1;
                iHora = 19;
            }
            else if (DateTime.Now.Hour > 4)
            {
                iHora = DateTime.Now.Hour;
                iHora = iHora - 5;
            }
            if (iHora < 10)
            {
                lblNova.Text = "0" + iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            else
            {
                lblNova.Text = iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            if (iDia < 10)
            {
                lblDiaN.Text = "0" + iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
            else
            {
                lblDiaN.Text = iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
        }

        private void tmToquio_Tick(object sender, EventArgs e)
        {
            iDia = DateTime.Now.Day;
            iHora = DateTime.Now.Hour;
            iHora = iHora + 9;
            iR = iHora - 24;
            if (iHora > 23)
            {
                iDia = iDia + 1;
                iHora = 0;
                iHora = iHora + iR;
            }
            if (iHora < 10)
            {
                lblToquio.Text = "0" + iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            else
            {
                lblToquio.Text = iHora.ToString() + " : " + DateTime.Now.ToString("mm") + " : " + DateTime.Now.ToString("ss");
            }
            if (iDia < 10)
            {
                lblDiaT.Text = "0" + iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
            else
            {
                lblDiaT.Text = iDia.ToString() + " / " + DateTime.Now.ToString("MM");
            }
        }
    }
}
