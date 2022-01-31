using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_Galo_2._0
{
    public partial class frmJogo : Form
    {
        //Variáveis
        public static string sJog1, sJog2, sResultado;
        public static bool bTesteV = true, bJogo1 = true, bJogo3, bJogo5, bAI, bMulti, bJ1, bPos1, bPos2, bPos3, bPos4, bPos5, bPos6, bPos7, bPos8, bPos9, bJPos1, bJPos2, bJPos3, bJPos4, bJPos5, bJPos6, bJPos7, bJPos8, bJPos9, bJogo, bFim, bTesteIA = false, bTestePassar, bFacil = true, bDif, bPeca1 = true, bPeca2, bPeca3, bPeca4;
        public static int iJogo1 = 0, iJogo2 = 0, iPos;

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            //Resetar Tudo
            bTesteV = true;
            lblJ1.ForeColor = Color.DarkRed;
            lblJ2.ForeColor = Color.Black;
            lblResultado1.Visible = false;
            lblResultado2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            bJogo = true;
            bFim = false;
            bJ1 = true;
            bPos1 = false;
            bPos2 = false;
            bPos3 = false;
            bPos4 = false;
            bPos5 = false;
            bPos6 = false;
            bPos7 = false;
            bPos8 = false;
            bPos9 = false;
            bJPos1 = false;
            bJPos2 = false;
            bJPos3 = false;
            bJPos4 = false;
            bJPos5 = false;
            bJPos6 = false;
            bJPos7 = false;
            bJPos8 = false;
            bJPos9 = false;
            Limpar();
            Pos1.Visible = true;
            Pos2.Visible = true;
            Pos3.Visible = true;
            Pos4.Visible = true;
            Pos5.Visible = true;
            Pos6.Visible = true;
            Pos7.Visible = true;
            Pos8.Visible = true;
            Pos9.Visible = true;
            lblVencedor.Visible = false;
            btnContinuar.Visible = false;
            tmVitória.Enabled = true;
            //Ver fim do Jogo
            if (bJogo1 == true)
            {
                this.Close();
            }
            else if (bJogo3 == true)
            {
                if (iJogo1 == 1 || iJogo2 == 1)
                {
                    this.Close();
                }
            }
            else if (bJogo5 == true)
            {
                if (iJogo1 == 2 || iJogo2 == 2)
                {
                    this.Close();
                }
            }
        }
        private void VerPecaIA(PictureBox Pos)
        {
            if (bPeca1 == true)
            {
                Pos.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
            }
            else if (bPeca2 == true)
            {
                Pos.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
            }
            else if (bPeca3 == true)
            {
                Pos.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
            }
            else if (bPeca4 == true)
            {
                Pos.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
            }
        }

        private void tmIA_Tick(object sender, EventArgs e)
        {           
            tmIA.Enabled = false;
            lblJ1.ForeColor = Color.DarkRed;
            lblJ2.ForeColor = Color.Black;
            Random rnd = new Random();
            bTesteIA = false;
            //Verificar Posições possíveis
            if (bFacil == true)
            {
                do
                {
                    iPos = rnd.Next(1, 10);
                    if (iPos == 1 && bPos1 != true && bJPos1 != true)
                    {
                        VerPecaIA(Pos1);
                        bTesteIA = true;
                        bJPos1 = true;
                    }
                    else if (iPos == 2 && bPos2 != true && bJPos2 != true)
                    {
                        VerPecaIA(Pos2);
                        bTesteIA = true;
                        bJPos2 = true;
                    }
                    else if (iPos == 3 && bPos3 != true && bJPos3 != true)
                    {
                        VerPecaIA(Pos3);
                        bTesteIA = true;
                        bJPos3 = true;
                    }
                    else if (iPos == 4 && bPos4 != true && bJPos4 != true)
                    {
                        VerPecaIA(Pos4);
                        bTesteIA = true;
                        bJPos4 = true;
                    }
                    else if (iPos == 5 && bPos5 != true && bJPos5 != true)
                    {
                        VerPecaIA(Pos5);
                        bTesteIA = true;
                        bJPos5 = true;
                    }
                    else if (iPos == 6 && bPos6 != true && bJPos6 != true)
                    {
                        VerPecaIA(Pos6);
                        bJPos6 = true;
                        bTesteIA = true;
                    }
                    else if (iPos == 7 && bPos7 != true && bJPos7 != true)
                    {
                        VerPecaIA(Pos7);
                        bTesteIA = true;
                        bJPos7 = true;
                    }
                    else if (iPos == 8 && bPos8 != true && bJPos8 != true)
                    {
                        VerPecaIA(Pos8);
                        bTesteIA = true;
                        bJPos8 = true;
                    }
                    else if (iPos == 9 && bPos9 != true && bJPos9 != true)
                    {
                        VerPecaIA(Pos9);
                        bTesteIA = true;
                        bJPos9 = true;
                    }
                }
                while ((bTesteIA != true) || ((bPos1 == true && iPos == 1) || (bPos2 == true && iPos == 2) || (bPos3 == true && iPos == 3) || (bPos4 == true && iPos == 4) || (bPos5 == true && iPos == 5) || (bPos6 == true && iPos == 6) || (bPos7 == true && iPos == 7) || (bPos8 == true && iPos == 8) || (bPos9 == true && iPos == 9)));
            }
            else if (bDif == true)
            {
                //Tentar Ganhar
                if (((bJPos1 == true && bJPos3 == true) || (bJPos5 == true && bJPos8 == true)) && bPos2 != true)
                {
                    VerPecaIA(Pos2);
                    bJPos2 = true;
                }
                else if (((bJPos4 == true && bJPos6 == true) || (bJPos2 == true && bJPos8 == true) || (bJPos1 == true && bJPos9 == true) || (bJPos3 == true && bJPos7 == true)) && bPos5 != true)
                {
                    VerPecaIA(Pos5);
                    bJPos5 = true;
                }
                else if (((bJPos7 == true && bJPos9 == true) || (bJPos2 == true && bJPos5 == true)) && bPos8 != true)
                {
                    VerPecaIA(Pos8);
                    bJPos8 = true;
                }
                else if (((bJPos1 == true && bJPos7 == true) || (bJPos5 == true && bJPos6 == true)) && bPos4 != true)
                {
                    VerPecaIA(Pos4);
                    bJPos4 = true;
                }
                else if (((bJPos3 == true && bJPos9 == true) || (bJPos4 == true && bJPos5 == true)) && bPos6 != true)
                {
                    VerPecaIA(Pos6);
                    bJPos6 = true;
                }
                else if (((bJPos2 == true && bJPos3 == true) || (bJPos4 == true && bJPos7 == true) || (bJPos5 == true && bJPos9 == true)) && bPos1 != true)
                {
                    VerPecaIA(Pos1);
                    bJPos1 = true;
                }
                else if (((bJPos1 == true && bJPos2 == true) || (bJPos6 == true && bJPos9 == true) || (bJPos5 == true && bJPos7 == true)) && bPos3 != true)
                {
                    VerPecaIA(Pos3);
                    bJPos3 = true;
                }
                else if (((bJPos1 == true && bJPos4 == true) || (bJPos3 == true && bJPos5 == true) || (bJPos8 == true && bJPos9 == true)) && bPos7 != true)
                {
                    VerPecaIA(Pos7);
                    bJPos7 = true;
                }
                else if (((bJPos1 == true && bJPos5 == true) || (bJPos3 == true && bJPos6 == true) || (bJPos8 == true && bJPos7 == true)) && bPos9 != true)
                {
                    VerPecaIA(Pos9);
                    bJPos9 = true;
                }
                //Não Deixar Ganhar
                else if (((bPos1 == true && bPos3 == true) || (bPos5 == true && bPos8 == true)) && bJPos2 != true)
                {
                    VerPecaIA(Pos2);
                    bJPos2 = true;
                }
                else if (((bPos4 == true && bPos6 == true) || (bPos2 == true && bPos8 == true) || (bPos1 == true && bPos9 == true) || (bPos3 == true && bPos7 == true)) && bJPos5 != true)
                {
                    VerPecaIA(Pos5);
                    bJPos5 = true;
                }
                else if (((bPos7 == true && bPos9 == true) || (bPos2 == true && bPos5 == true)) && bJPos8 != true)
                {
                    VerPecaIA(Pos8);
                    bJPos8 = true;
                }
                else if (((bPos1 == true && bPos7 == true) || (bPos5 == true && bPos6 == true)) && bJPos4 != true)
                {
                    VerPecaIA(Pos4);
                    bJPos4 = true;
                }
                else if (((bPos3 == true && bPos9 == true) || (bPos4 == true && bPos5 == true)) && bJPos6 != true)
                {
                    VerPecaIA(Pos6);
                    bJPos6 = true;
                }
                else if (((bPos2 == true && bPos3 == true) || (bPos4 == true && bPos7 == true) || (bPos5 == true && bPos9 == true)) && bJPos1 != true)
                {
                    VerPecaIA(Pos1);
                    bJPos1 = true;
                }
                else if (((bPos1 == true && bPos2 == true) || (bPos6 == true && bPos9 == true) || (bPos5 == true && bPos7 == true)) && bJPos3 != true)
                {
                    VerPecaIA(Pos3);
                    bJPos3 = true;
                }
                else if (((bPos1 == true && bPos4 == true) || (bPos3 == true && bPos5 == true) || (bPos8 == true && bPos9 == true)) && bJPos7 != true)
                {
                    VerPecaIA(Pos7);
                    bJPos7 = true;
                }
                else if (((bPos1 == true && bPos5 == true) || (bPos3 == true && bPos6 == true) || (bPos8 == true && bPos7 == true)) && bJPos9 != true)
                {
                    VerPecaIA(Pos9);
                    bJPos9 = true;
                }
                //Jogar
                else if (bPos5 != true && bJPos5 != true)
                {
                    VerPecaIA(Pos5);
                    bJPos5 = true;
                }
                else if (bPos1 != true && bJPos1 != true)
                {
                    VerPecaIA(Pos1);
                    bJPos1 = true;
                }
                else if (bPos3 != true && bJPos3 != true)
                {
                    VerPecaIA(Pos3);
                    bJPos3 = true;
                }
                else if (bPos7 != true && bJPos7 != true)
                {
                    VerPecaIA(Pos7);
                    bJPos7 = true;
                }
                else if (bPos9 != true && bJPos9 != true)
                {
                    VerPecaIA(Pos9);
                    bJPos9 = true;
                }
                else if (bPos2 != true && bJPos2 != true)
                {
                    VerPecaIA(Pos2);
                    bJPos2 = true;
                }
                else if (bPos4 != true && bJPos4 != true)
                {
                    VerPecaIA(Pos4);
                    bJPos4 = true;
                }
                else if (bPos8 != true && bJPos8 != true)
                {
                    VerPecaIA(Pos8);
                    bJPos8 = true;
                }
                else if (bPos6 != true && bJPos6 != true)
                {
                    VerPecaIA(Pos6);
                    bJPos6 = true;
                }
            }
            bJ1 = true;
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (BackColor == Color.Black || BackColor == Color.Red || BackColor == Color.Teal || BackColor == Color.IndianRed || BackColor == Color.Maroon)
                {
                    MessageBox.Show("Cor não pode ser defenida como fundo", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    BackColor = colorDialog1.Color;
                }
            }
        }        
        private void sairDoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void Limpar()
        {
            Pos1.Visible = false;
            Pos2.Visible = false;
            Pos3.Visible = false;
            Pos4.Visible = false;
            Pos5.Visible = false;
            Pos6.Visible = false;
            Pos7.Visible = false;
            Pos8.Visible = false;
            Pos9.Visible = false;
            Pos1.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos2.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos3.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos4.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos5.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos6.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos7.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos8.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
            Pos9.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\None.png");
        }

        private void tmVitória_Tick(object sender, EventArgs e)
        {
            //Ver se há Vitória
            if (bTesteV == true && ((bPos1 == true && bPos2 == true && bPos3 == true) || (bPos4 == true && bPos5 == true && bPos6 == true) || (bPos7 == true && bPos8 == true && bPos9 == true) || (bPos1 == true && bPos4 == true && bPos7 == true) || (bPos2 == true && bPos5 == true && bPos8 == true) || (bPos3 == true && bPos6 == true && bPos9 == true) || (bPos1 == true && bPos5 == true && bPos9 == true) || (bPos3 == true && bPos5 == true && bPos7 == true)))
            {
                bTesteV = false;
                //Limpar Jogo                
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                Limpar();           
                bFim = true;
                lblVencedor.Visible = true;
                btnContinuar.Visible = true;
                //Verificar Pontos              
                if (iJogo1 == 1 && bJogo3 == true)
                {
                    lblResultado1.Visible = true;
                    lblResultado2.Visible = true;
                    label3.Visible = true;
                }
                else if (iJogo1 == 2 && bJogo5 == true)
                {
                    lblResultado1.Visible = true;
                    lblResultado2.Visible = true;
                    label3.Visible = true;
                }
                //Marcar Pontos
                if (iJogo1 == 0)
                {
                    lblJogo1.Visible = true;
                    lblJogo1.Text = "I";
                    lblResultado1.Text = "I";
                    iJogo1 = 1;
                }
                else if (iJogo1 == 1)
                {
                    lblJogo1.Text = "I I";
                    lblResultado1.Text = "I I";
                    iJogo1 = 2;
                }
                else if (iJogo1 == 2 && bJogo5 == true)
                {
                    lblJogo1.Text = "I I I";
                    lblResultado1.Text = "I I I";
                }
                lblVencedor.Text = "O " + sJog1 + " Ganhou!";               
                tmVitória.Enabled = false;
            }
            else if (bTesteV == true && ((bJPos1 == true && bJPos2 == true && bJPos3 == true) || (bJPos4 == true && bJPos5 == true && bJPos6 == true) || (bJPos7 == true && bJPos8 == true && bJPos9 == true) || (bJPos1 == true && bJPos4 == true && bJPos7 == true) || (bJPos2 == true && bJPos5 == true && bJPos8 == true) || (bJPos3 == true && bJPos6 == true && bJPos9 == true) || (bJPos1 == true && bJPos5 == true && bJPos9 == true) || (bJPos3 == true && bJPos5 == true && bJPos7 == true)))
            {
                bTesteV = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                Limpar();
                bFim = true;
                lblVencedor.Visible = true;
                btnContinuar.Visible = true;
                //Ver Pontos   
                if (iJogo2 == 2 && bJogo3 == true)
                {
                    lblResultado1.Visible = true;
                    lblResultado2.Visible = true;
                    label3.Visible = true;
                }
                else if (iJogo2 == 3 && bJogo5 == true)
                {
                    lblResultado1.Visible = true;
                    lblResultado2.Visible = true;
                    label3.Visible = true;
                }
                //Marcar Pontos
                if (iJogo2 == 0)
                {
                    lblJogo2.Visible = true;
                    lblJogo2.Text = "I";
                    lblResultado2.Text = "I";
                    iJogo2 = 1;
                }
                else if (iJogo2 == 1)
                {
                    lblJogo2.Text = "I I";
                    lblResultado2.Text = "I I";
                    iJogo2 = 2;
                }
                else if (iJogo2 == 2 && bJogo5 == true)
                {
                    lblJogo2.Text = "I I I";
                    lblResultado2.Text = "I I I";
                }
                lblVencedor.Text = "O " + sJog2 + " Ganhou!";                
                tmVitória.Enabled = false;
            }
            else if (bTesteV == true && ((bPos1 == true || bJPos1 == true) && (bPos2 == true || bJPos2 == true) && (bPos3 == true || bJPos3 == true) && (bPos4 == true || bJPos4 == true) && (bPos5 == true || bJPos5 == true) && (bPos6 == true || bJPos6 == true) && (bPos7 == true || bJPos7 == true) && (bPos8 == true || bJPos8 == true) && (bPos9 == true || bJPos9 == true) && (bFim == false)))
            {
                bTesteV = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                Limpar();
                bFim = true;
                lblVencedor.Visible = true;
                btnContinuar.Visible = true;
                lblVencedor.Text = "          Empate!   ";
            }
        }

        public frmJogo()
        {
            InitializeComponent();
            lblJ1.Text = sJog1;
            lblJ2.Text = sJog2;
            lblJ1.ForeColor = Color.DarkRed;
            lblJ2.ForeColor = Color.Black;
            bJ1 = true;
            bJogo = true;
            lblResultado1.Text = "";
            lblResultado2.Text = "";
            lblJogo1.Text = "";
            lblJogo2.Text = "";
        }
        private void Posicao_Click(object sender, EventArgs e)
        {
            //Ver posição da jogada
            if (bJogo == true)
            {
                if (bJ1 == true)
                {
                    ((PictureBox)sender).Visible = true;
                    lblJ2.ForeColor = Color.DarkRed;
                    lblJ1.ForeColor = Color.Black;
                    bTestePassar = false;
                    while (bTestePassar == false)
                    {
                        if (Convert.ToInt32(((PictureBox)sender).Tag) == 1 && bPos1 != true && bJPos1 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos1 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 2 && bPos2 != true && bJPos2 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos2 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 3 && bPos3 != true && bJPos3 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bJ1 = false;
                            bPos3 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 4 && bPos4 != true && bJPos4 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos4 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 5 && bPos5 != true && bJPos5 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos5 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 6 && bPos6 != true && bJPos6 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos6 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 7 && bPos7 != true && bJPos7 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos7 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 8 && bPos8 != true && bJPos8 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos8 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 9 && bPos9 != true && bJPos9 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\X.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Tri.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Copas.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Espadas.png");
                            }
                            bPos9 = true;
                            bJ1 = false;
                            bTestePassar = true;
                        }
                    }
                    if (bAI == true)
                    {
                        tmIA.Enabled = true;
                    }
                }
                else if (bJ1 != true && bMulti == true)
                {
                    ((PictureBox)sender).Visible = true;
                    lblJ1.ForeColor = Color.DarkRed;
                    lblJ2.ForeColor = Color.Black;
                    bTestePassar = false;
                    while (bTestePassar == false)
                    {
                        if (Convert.ToInt32(((PictureBox)sender).Tag) == 1 && bJPos1 != true && bPos1 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos1 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 2 && bJPos2 != true && bPos2 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos2 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 3 && bJPos3 != true && bPos3 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos3 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 4 && bJPos4 != true && bPos4 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos4 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 5 && bJPos5 != true && bPos5 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos5 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 6 && bJPos6 != true && bPos6 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos6 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 7 && bJPos7 != true && bPos7 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos7 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 8 && bJPos8 != true && bPos8 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos8 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                        else if (Convert.ToInt32(((PictureBox)sender).Tag) == 9 && bJPos9 != true && bPos9 != true)
                        {
                            if (bPeca1 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\O.png");
                            }
                            else if (bPeca2 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Qua.png");
                            }
                            else if (bPeca3 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Paus.png");
                            }
                            else if (bPeca4 == true)
                            {
                                ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Imagem\\Ouros.png");
                            }
                            bJPos9 = true;
                            bJ1 = true;
                            bTestePassar = true;
                        }
                    }
                }
            }
        }        
    }
}
