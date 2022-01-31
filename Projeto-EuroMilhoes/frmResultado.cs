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
    public partial class frmResultado : Form
    {
        //Variáveis
        public static string sN1 = " ", sN2, sN3, sN4, sN5, sE1, sE2, sRN1, sRN2, sRN3, sRN4, sRN5, sRE1, sRE2, sPremio;
        string sMensagem, sTitulo;
        public static bool bTesteAposta = false;
        int iN1, iN2, iN3, iN4, iN5, iE1, iE2, iPos, iPos1, iAux;
        int[] aNumeros = new int[5];
        int[] aRNumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
        int[] aREstrelas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        //Para mostrar a opção de Ganhar 
        private void button1_Click(object sender, EventArgs e)
        {
            sN1 = sRN1;
            sN2 = sRN2;
            sN3 = sRN3;
            sN4 = sRN4;
            sN5 = sRN5;
            sE1 = sRE1;
            sE2 = sRE2;
            btnVerificar.Visible = true;
            button1.Visible = false;
        }

        private void frmResultado_Activated(object sender, EventArgs e)
        {
            if (bTesteAposta == false)
            {
                lblNumeros.Visible = false;
                lblEstrelas.Visible = false;
            }
            else
            {
                lblNumeros.Visible = true;
                lblEstrelas.Visible = true;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            btnVerificar.Visible = false;
            //Verificar se ganhou/perdeu
            Ordenar();
            if (sN1 == sRN1 && sN2 == sRN2 && sN3 == sRN3 && sN4 == sRN4 && sN5 == sRN5 && sE1 == sRE1 && sE2 == sRE2)
            {
                sMensagem = "Parabéns, você ganhou " + sPremio + " !!!";
                sTitulo = "Ganhou!";                 
            }
            else
            {
                sMensagem = "Você não ganhou os " + sPremio + " .";
                sTitulo = "Não Ganhou";
            }
            MessageBox.Show(sMensagem, sTitulo, MessageBoxButtons.OK);
        }       

        //Ativar Botões dos números e estrelas
        private void btnE2_Click(object sender, EventArgs e)
        {
            btnE2.Visible = false;
            lblE2.Visible = true;
            btnOrdenar.Visible = true;
            btnVerificar.Visible = true;
            button1.Visible = true;
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            btnE1.Visible = false;
            btnE2.Visible = true;
            lblE1.Visible = true;
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            btnN5.Visible = false;
            btnE1.Visible = true;
            lblN5.Visible = true;
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            btnN4.Visible = false;
            btnN5.Visible = true;
            lblN4.Visible = true;
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            btnN3.Visible = false;
            btnN4.Visible = true;
            lblN3.Visible = true;
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            btnN2.Visible = false;
            btnN3.Visible = true;
            lblN2.Visible = true;
        }

        private void btnN1_Click(object sender, EventArgs e)
        {            
            btnN1.Visible = false;
            btnN2.Visible = true;
        }



        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenar();
            lblN1.Text = sRN1;
            lblN2.Text = sRN2;
            lblN3.Text = sRN3;
            lblN4.Text = sRN4;
            lblN5.Text = sRN5;
            lblE1.Text = sRE1;
            lblE2.Text = sRE2;
            lblNumeros.Text = "Seus Números : " + sN1 + " " + sN2 + " " + sN3 + " " + sN4 + " " + sN5;
            lblEstrelas.Text = "Suas Estrelas : " + sE1 + " " + sE2;
            
            //Não voltar a ordenar
            btnOrdenar.Visible = false;
        }
        //Baralhar Numeros ou Estrelas
        public static void Shuffle<T>(T[] aRNumeros)
        {
            Random rnd = new Random();
            //Random de 1 a 50 (i = 50 numeros)
            for (int i = aRNumeros.Length; i > 1; i--)
            {
                //j = numero escolhido
                int j = rnd.Next(i);
                //tmp = numero escolhido na posição
                T aux = aRNumeros[j];
                //retirar o numero do array para nao se repetir
                aRNumeros[j] = aRNumeros[i - 1];
                //passar esse numero a auxiliar
                aRNumeros[i - 1] = aux;

            }
        }

        public frmResultado()
        {
            InitializeComponent();
            //Apresentar a aposta, caso haja
            lblNumeros.Text = "Seus Números : " + sN1 + " " + sN2 + " " + sN3 + " " + sN4 + " " + sN5;
            lblEstrelas.Text = "Suas Estrelas : " + sE1 + " " + sE2;
            //Sortear Números
            Shuffle(aRNumeros);
            if (aRNumeros[0] < 10)
            {
                lblN1.Text = "0" + aRNumeros[0].ToString();

            }
            else
            {
                lblN1.Text = aRNumeros[0].ToString();
            }
            if (aRNumeros[1] < 10)
            {
                lblN2.Text = "0" + aRNumeros[1].ToString();

            }
            else
            {
                lblN2.Text = aRNumeros[1].ToString();
            }
            if (aRNumeros[2] < 10)
            {
                lblN3.Text = "0" + aRNumeros[2].ToString();

            }
            else
            {
                lblN3.Text = aRNumeros[2].ToString();
            }
            if (aRNumeros[3] < 10)
            {
                lblN4.Text = "0" + aRNumeros[3].ToString();

            }
            else
            {
                lblN4.Text = aRNumeros[3].ToString();
            }
            if (aRNumeros[4] < 10)
            {
                lblN5.Text = "0" + aRNumeros[4].ToString();

            }
            else
            {
                lblN5.Text = aRNumeros[4].ToString();
            }
            //Sortear Estrelas
            Shuffle(aREstrelas);
            if (aREstrelas[0] < 10)
            {
                lblE1.Text = "0" + aREstrelas[0].ToString();

            }
            else
            {
                lblE1.Text = aREstrelas[0].ToString();
            }
            if (aREstrelas[1] < 10)
            {
                lblE2.Text = "0" + aREstrelas[1].ToString();

            }
            else
            {
                lblE2.Text = aREstrelas[1].ToString();
            }
        }

        private void Ordenar()
        {
            //Ordenar Resultado

            //Converter a Int
            iN1 = aRNumeros[0];
            iN2 = aRNumeros[1];
            iN3 = aRNumeros[2];
            iN4 = aRNumeros[3];
            iN5 = aRNumeros[4];
            iE1 = aREstrelas[0];
            iE2 = aREstrelas[1];
            aNumeros[0] = iN1;
            aNumeros[1] = iN2;
            aNumeros[2] = iN3;
            aNumeros[3] = iN4;
            aNumeros[4] = iN5;
            //Ordenar os números e estrelas
            for (iPos = 0; iPos < 4; iPos++)
            {
                for (iPos1 = iPos + 1; iPos1 < 5; iPos1++)
                {
                    if (aNumeros[iPos] > aNumeros[iPos1])
                    {
                        iAux = aNumeros[iPos];
                        aNumeros[iPos] = aNumeros[iPos1];
                        aNumeros[iPos1] = iAux;
                    }
                }
            }
            if (iE1 > iE2)
            {
                iAux = iE1;
                iE1 = iE2;
                iE2 = iAux;
            }
            //Verificar 0 e converter tudo a string
            if (aNumeros[0] < 10)
            {
                sRN1 = "0" + aNumeros[0].ToString();
            }
            else
            {
                sRN1 = aNumeros[0].ToString();
            }
            if (aNumeros[1] < 10)
            {
                sRN2 = "0" + aNumeros[1].ToString();
            }
            else
            {
                sRN2 = aNumeros[1].ToString();
            }
            if (aNumeros[2] < 10)
            {
                sRN3 = "0" + aNumeros[2].ToString();
            }
            else
            {
                sRN3 = aNumeros[2].ToString();
            }
            if (aNumeros[3] < 10)
            {
                sRN4 = "0" + aNumeros[3].ToString();
            }
            else
            {
                sRN4 = aNumeros[3].ToString();
            }
            if (aNumeros[4] < 10)
            {
                sRN5 = "0" + aNumeros[4].ToString();
            }
            else
            {
                sRN5 = aNumeros[4].ToString();
            }
            if (iE1 < 10)
            {
                sRE1 = "0" + iE1.ToString();
            }
            else
            {
                sRE1 = iE1.ToString();
            }
            if (iE2 < 10)
            {
                sRE2 = "0" + iE2.ToString();
            }
            else
            {
                sRE2 = iE2.ToString();
            }

            //Ordenar Aposta
            if (sN1 != " ")
            {
                //Converter a Int
                iN1 = Convert.ToInt32(sN1);
                iN2 = Convert.ToInt32(sN2);
                iN3 = Convert.ToInt32(sN3);
                iN4 = Convert.ToInt32(sN4);
                iN5 = Convert.ToInt32(sN5);
                iE1 = Convert.ToInt32(sE1);
                iE2 = Convert.ToInt32(sE2);
                aNumeros[0] = iN1;
                aNumeros[1] = iN2;
                aNumeros[2] = iN3;
                aNumeros[3] = iN4;
                aNumeros[4] = iN5;
                //Ordenar os números e estrelas
                for (iPos = 0; iPos < 4; iPos++)
                {
                    for (iPos1 = iPos + 1; iPos1 < 5; iPos1++)
                    {
                        if (aNumeros[iPos] > aNumeros[iPos1])
                        {
                            iAux = aNumeros[iPos];
                            aNumeros[iPos] = aNumeros[iPos1];
                            aNumeros[iPos1] = iAux;
                        }
                    }
                }
                if (iE1 > iE2)
                {
                    iAux = iE1;
                    iE1 = iE2;
                    iE2 = iAux;
                }
                //Verificar 0 e converter tudo a string
                if (aNumeros[0] < 10)
                {
                    sN1 = "0" + aNumeros[0].ToString();
                }
                else
                {
                    sN1 = aNumeros[0].ToString();
                }
                if (aNumeros[1] < 10)
                {
                    sN2 = "0" + aNumeros[1].ToString();
                }
                else
                {
                    sN2 = aNumeros[1].ToString();
                }
                if (aNumeros[2] < 10)
                {
                    sN3 = "0" + aNumeros[2].ToString();
                }
                else
                {
                    sN3 = aNumeros[2].ToString();
                }
                if (aNumeros[3] < 10)
                {
                    sN4 = "0" + aNumeros[3].ToString();
                }
                else
                {
                    sN4 = aNumeros[3].ToString();
                }
                if (aNumeros[4] < 10)
                {
                    sN5 = "0" + aNumeros[4].ToString();
                }
                else
                {
                    sN5 = aNumeros[4].ToString();
                }
                if (iE1 < 10)
                {
                    sE1 = "0" + iE1.ToString();
                }
                else
                {
                    sE1 = iE1.ToString();
                }
                if (iE2 < 10)
                {
                    sE2 = "0" + iE2.ToString();
                }
                else
                {
                    sE2 = iE2.ToString();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
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
