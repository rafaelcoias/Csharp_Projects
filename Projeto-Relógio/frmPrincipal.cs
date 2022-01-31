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
    public partial class frmPrincipal : Form
    {
        public static string sHoras, sMinutos, sDia, sMes, sAno, sFicheiro, sDesc = "";
        public static bool bTesteOn = false, bTesteMusica = false, bTesteMusica2 = false, bTesteNovaMusica, bTeste1 = false, bTeste2 = false;
        public static int iMusica = 1;

        System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Musica5 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino4 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino5 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino6 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino7 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino8 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino9 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino10 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino11 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer SomDeSino12 = new System.Media.SoundPlayer();

        public frmPrincipal()
        {
            InitializeComponent();
            Musica.SoundLocation = "musicwav.wav";
            Musica2.SoundLocation = "musica2.wav";
            Musica3.SoundLocation = "musica4.wav";
            Musica5.SoundLocation = sFicheiro;
            SomDeSino1.SoundLocation = "SomDeSino1.wav";
            SomDeSino2.SoundLocation = "SomDeSino2.wav";
            SomDeSino3.SoundLocation = "SomDeSino3.wav";
            SomDeSino4.SoundLocation = "SomDeSino4.wav";
            SomDeSino5.SoundLocation = "SomDeSino5.wav";
            SomDeSino6.SoundLocation = "SomDeSino6.wav";
            SomDeSino7.SoundLocation = "SomDeSino7.wav";
            SomDeSino8.SoundLocation = "SomDeSino8.wav";
            SomDeSino9.SoundLocation = "SomDeSino9.wav";
            SomDeSino10.SoundLocation = "SomDeSino10.wav";
            SomDeSino11.SoundLocation = "SomDeSino11.wav";
            SomDeSino12.SoundLocation = "SomDeSino12.wav";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.Minute == 00 && bTesteMusica2 == false)
            {
                if ((DateTime.Now.Hour == 1 || DateTime.Now.Hour == 13))
                {
                    SomDeSino1.Play();
                }
                else if ((DateTime.Now.Hour == 2 || DateTime.Now.Hour == 14))
                {
                    SomDeSino2.Play();
                }
                else if ((DateTime.Now.Hour == 3 || DateTime.Now.Hour == 15))
                {
                    SomDeSino3.Play();
                }
                else if ((DateTime.Now.Hour == 4 || DateTime.Now.Hour == 16))
                {
                    SomDeSino4.Play();
                }
                else if ((DateTime.Now.Hour == 5 || DateTime.Now.Hour == 17))
                {
                    SomDeSino5.Play();
                }
                else if ((DateTime.Now.Hour == 6 || DateTime.Now.Hour == 18))
                {
                    SomDeSino6.Play();
                }
                else if ((DateTime.Now.Hour == 7 || DateTime.Now.Hour == 19))
                {
                    SomDeSino7.Play();
                }
                else if ((DateTime.Now.Hour == 8 || DateTime.Now.Hour == 20))
                {
                    SomDeSino8.Play();
                }
                else if ((DateTime.Now.Hour == 9 || DateTime.Now.Hour == 21))
                {
                    SomDeSino9.Play();
                }
                else if ((DateTime.Now.Hour == 10 || DateTime.Now.Hour == 22))
                {
                    SomDeSino10.Play();
                }
                else if ((DateTime.Now.Hour == 11 || DateTime.Now.Hour == 23))
                {
                    SomDeSino11.Play();
                }
                else if ((DateTime.Now.Hour == 12 || DateTime.Now.Hour == 00))
                {
                    SomDeSino12.Play();
                }
                bTesteMusica2 = true;
                tmTSino.Enabled = true;
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            gb1.Visible = true;
            btnAbrir.Visible = false;
            btnSair.Visible = false;
            btnFechar.Visible = true;
            btnSair2.Visible = true;
            btnCron.Visible = true;
            tmAbrir.Enabled = true;
            btnRMundial.Visible = true;            
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Height < 410)
            {
                Height = Height + 10;
            }
            else
            {
                tmAbrir.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            gb1.Visible = false;
            btnAbrir.Visible = true;
            btnSair.Visible = true;
            btnFechar.Visible = false;
            btnSair2.Visible = false;
            btnCron.Visible = false;
            btnRMundial.Visible = false;
            tmFechar.Enabled = true;
        }

        private void rbOff_Click(object sender, EventArgs e)
        {
            if (bTesteMusica2 == false || bTesteMusica == true)
            {
                Musica.Stop();
                Musica2.Stop();
                Musica3.Stop();
                Musica5.Stop();
            }
            bTesteMusica = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Height > 270)
            {
                Height = Height - 10;
            }
            else
            {
                tmFechar.Enabled = false;
            }
        }

        private void rbOn_Click_1(object sender, EventArgs e)
        {
            lblHorasMinutos.Visible = true;
            lblDiaMes.Visible = true;
            btnEditar.Visible = true;
            bTesteMusica = false;
            if (bTesteOn == false)
            {
                bTesteOn = true;
                rbOn.Checked = false;
                rbOff.Checked = true;
                frmToque.iMusica = 1;
                Form frmAlarme = new frmAlarme();
                frmAlarme.Show();
            }
        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            Form frmAlarme = new frmAlarme();
            frmAlarme.Show();
            tm1.Enabled = false;
        }

        private void tmAlarme_Tick(object sender, EventArgs e)
        {
            if (rbOn.Checked == true)
            {
                if ((DateTime.Now.ToString("HH : mm") == lblHorasMinutos.Text) && (DateTime.Now.ToString("dd / MM / yyyy") == lblDiaMes.Text) && (bTesteMusica == false))
                {
                    tmTAlarme.Enabled = true;
                    bTesteMusica = true;
                    if (iMusica == 1)
                    {
                        Musica.Play();
                        frmToque.iMusica = 1;
                    }
                    else if (iMusica == 2)
                    {
                        Musica2.Play();
                        frmToque.iMusica = 2;
                    }
                    else if (iMusica == 3)
                    {
                        Musica3.Play();
                        frmToque.iMusica = 3;
                    }
                    else if (iMusica == 5)
                    {
                        Musica5.SoundLocation = sFicheiro;
                        frmToque.bMudar = false;
                        Musica5.Play();
                        frmToque.iMusica = 5;
                        frmToque.sFicheiro = sFicheiro;
                    }
                    if (sDesc != "")
                    {
                        var resultado = MessageBox.Show(sDesc, "Alarme", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {

                        }
                        else if (resultado == DialogResult.Cancel)
                        {
                            if (bTesteMusica2 == false || bTesteMusica == true)
                            {
                                Musica.Stop();
                                Musica2.Stop();
                                Musica3.Stop();
                                Musica5.Stop();
                            }
                            bTesteMusica = false;
                            rbOff.Checked = true;
                            rbOn.Checked = false;
                        }
                    }
                }
                else if ((DateTime.Now.ToString("HH : mm") != lblHorasMinutos.Text) && (bTesteMusica == true))
                {
                    Musica.Stop();
                    Musica2.Stop();
                    Musica3.Stop();
                    Musica5.Stop();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form frmAlarme = new frmAlarme();
            frmAlarme.Show();
            bTesteMusica = false;
            rbOff.Checked = true;
            rbOn.Checked = false;
        }

        private void tmTAlarme_Tick(object sender, EventArgs e)
        {
            tmTAlarme.Enabled = false;
            bTesteMusica = false;
        }

        private void btnRMundial_Click(object sender, EventArgs e)
        {
            Form frmRMundial = new frmRMundial();
            frmRMundial.Show();
        }

        private void tmT_Tick(object sender, EventArgs e)
        {
            tmTSino.Enabled = false;
            bTesteMusica2 = false;
        }

        private void btnCron_Click(object sender, EventArgs e)
        {
            Form frmCron = new frmCron();
            frmCron.Show();
        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            if (bTeste1 == true && bTeste2 == true)
            {                
                frmAlarme.bTeste1 = true;
                bTeste2 = false;
                tm1.Enabled = true;
            }
            if (sMinutos == "0")
            {
                sMinutos = "00";
            }
            lblHorasMinutos.Text = sHoras + " : " + sMinutos;
            lblDiaMes.Text = sDia + " / " + sMes + " / " + sAno;
            if (bTesteNovaMusica == true)
            {
                frmToque.bTesteNovaMusica = true;
            }                   
        }
    }  
}
