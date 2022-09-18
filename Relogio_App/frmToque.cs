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
    public partial class frmToque : Form
    {
        //Variáveis
        System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica5 = new System.Media.SoundPlayer();
        public static int iMusica;
        public static string sFicheiro;
        public static bool bTesteNovaMusica = false, bMudar;

        public frmToque()
        {
            InitializeComponent();
            Musica.SoundLocation = "musicwav.wav";
            Musica2.SoundLocation = "musica2.wav";
            Musica3.SoundLocation = "musica4.wav";
            Musica5.SoundLocation = sFicheiro;
        }

        private void rbMusica1_Click(object sender, EventArgs e)
        {
            btnMudar.Visible = false;
            rbMusica2.Checked = false;
            rbMusica3.Checked = false;
            rbNovaMusica.Checked = false;
            frmPrincipal.iMusica = 1;
            if (iMusica == 2)
            {
                Musica2.Stop();
            }
            else if (iMusica == 3)
            {
                Musica3.Stop();
            }
            else if (iMusica == 5)
            {
                Musica5.Stop();
            }
            iMusica = 1;
            Musica.Play();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal.sFicheiro = sFicheiro;
            frmAlarme.sFicheiro = sFicheiro;
            this.Close();
        }

        private void rbNovaMusica_Click(object sender, EventArgs e)
        {
            btnMudar.Visible = true;
            rbMusica1.Checked = false;
            rbMusica2.Checked = false;
            rbMusica3.Checked = false;
            frmPrincipal.iMusica = 5;
            if (iMusica == 1)
            {
                Musica.Stop();
            }
            else if (iMusica == 2)
            {
                Musica2.Stop();
            }
            else if (iMusica == 3)
            {
                Musica3.Stop();
            }           
            iMusica = 5;
            Musica5.Play();
            tm1.Enabled = true;
            bMudar = true;
        }

        private void frmToque_Activated(object sender, EventArgs e)
        {
            if (iMusica == 1)
            {
                Musica.SoundLocation = "musicwav.wav";
                rbMusica2.Checked = false;
                rbMusica3.Checked = false;
                rbNovaMusica.Checked = false;
                rbMusica1.Checked = true;
                Musica.Play();
            }
            else if (iMusica == 2)
            {
                Musica2.SoundLocation = "musica2.wav";
                rbMusica1.Checked = false;
                rbMusica3.Checked = false;
                rbNovaMusica.Checked = false;
                rbMusica2.Checked = true;
                Musica2.Play();
            }
            else if (iMusica == 3)
            {
                Musica3.SoundLocation = "musica4.wav";
                rbMusica2.Checked = false;
                rbMusica1.Checked = false;
                rbNovaMusica.Checked = false;
                rbMusica3.Checked = true;
                Musica3.Play();
            }
            else if (iMusica == 5)
            {
                if (bMudar == true)
                {
                    sFicheiro = ofd1.FileName;
                    bMudar = false;
                }
                Musica5.SoundLocation = sFicheiro;
                rbMusica2.Checked = false;
                rbMusica3.Checked = false;
                rbMusica1.Checked = false;
                rbNovaMusica.Checked = true;
                btnMudar.Visible = true;
                Musica5.Play();
            }
        }

        private void rbMusica3_Click(object sender, EventArgs e)
        {
            btnMudar.Visible = false;
            rbNovaMusica.Checked = false;
            rbMusica2.Checked = false;
            rbMusica1.Checked = false;
            frmPrincipal.iMusica = 3;
            if (iMusica == 2)
            {
                Musica2.Stop();
            }
            else if (iMusica == 1)
            {
                Musica.Stop();
            }
            else if (iMusica == 5)
            {
                Musica5.Stop();
            }
            iMusica = 3;
            Musica3.Play();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            bTesteNovaMusica = false;
            tm1.Enabled = true;
            bMudar = true;
        }

        private void rbMusica2_Click_1(object sender, EventArgs e)
        {
            btnMudar.Visible = false;
            rbMusica1.Checked = false;
            rbMusica3.Checked = false;
            rbNovaMusica.Checked = false;
            frmPrincipal.iMusica = 2;
            if (iMusica == 1)
            {
                Musica.Stop();
            }
            else if (iMusica == 3)
            {
                Musica3.Stop();
            }
            else if (iMusica == 5)
            {
                Musica5.Stop();
            }
            iMusica = 2;
            Musica2.Play();
        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            tm1.Enabled = false;
            if (bTesteNovaMusica == false)
            {
                ofd1.InitialDirectory = "c:\\";
                ofd1.Filter = "wav files (*.wav)|*.wav";
                ofd1.FilterIndex = 2;
                ofd1.RestoreDirectory = true;
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    sFicheiro = ofd1.FileName;
                }
                bTesteNovaMusica = true;
            }
            Musica5.Play();
        }
    }
}
