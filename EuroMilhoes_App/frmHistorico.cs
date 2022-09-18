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
    public partial class frmHistorico : Form
    {
        //Variáveis
        public static string sN1, sN2, sN3, sN4, sN5, sE1, sE2;
        public static int iN1, iN2, iN3, iN4, iN5, iE1, iE2, iPos, iPos1, iAux, iN;
        public static int[] aEstrelas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public static int[] aNumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
        public static int[] aNumerosO = new int[5];

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmHistorico()
        {
            InitializeComponent();
        }

        private void cbN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Passar numero para a label
            if (cbN1.SelectedIndex < 9)
            {
                lblSemanas.Text = "0" + cbN1.SelectedItem.ToString();
            }
            else
            {
                lblSemanas.Text = cbN1.SelectedItem.ToString();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbox.Items.Clear();
            lbox.Items.Add("    Números                            Estrelas");
            lbox.Items.Add("                     ");
            if (lblSemanas.Text == "01")
            {
                Shuffle(aNumeros);
                sN1 = aNumeros[0].ToString();
                sN2 = aNumeros[1].ToString();
                sN3 = aNumeros[2].ToString();
                sN4 = aNumeros[3].ToString();
                sN5 = aNumeros[4].ToString();
                Shuffle(aEstrelas);
                sE1 = aEstrelas[0].ToString();
                sE2 = aEstrelas[1].ToString();
                Ordenar();
                lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
            }
            else if (lblSemanas.Text == "02")
            {
                iN = 2;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "03")
            {
                iN = 3;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "04")
            {
                iN = 4;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "05")
            {
                iN = 5;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "06")
            {
                iN = 6;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "07")
            {
                iN = 7;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "08")
            {
                iN = 8;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "09")
            {
                iN = 9;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
            else if (lblSemanas.Text == "10")
            {
                iN = 10;
                do
                {
                    Shuffle(aNumeros);
                    sN1 = aNumeros[0].ToString();
                    sN2 = aNumeros[1].ToString();
                    sN3 = aNumeros[2].ToString();
                    sN4 = aNumeros[3].ToString();
                    sN5 = aNumeros[4].ToString();
                    Shuffle(aEstrelas);
                    sE1 = aEstrelas[0].ToString();
                    sE2 = aEstrelas[1].ToString();
                    Ordenar();
                    lbox.Items.Add(sN1 + "-" + sN2 + "-" + sN3 + "-" + sN4 + "-" + sN5 + "                        " + sE1 + "-" + sE2);
                    lbox.Items.Add("                     ");
                    iN--;
                }
                while (iN > 0);
            }
        }

        private static void Ordenar()
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

        public static void Shuffle<T>(T[] aNumeros)
        {
            Random rnd = new Random();
            //Random de 1 a 50 (i = 50 numeros)
            for (int i = aNumeros.Length; i > 1; i--)
            {
                //j = numero escolhido
                int j = rnd.Next(i);
                //tmp = numero escolhido na posição
                T aux = aNumeros[j];
                //retirar o numero do array para nao se repetir
                aNumeros[j] = aNumeros[i - 1];
                //passar esse numero a auxiliar
                aNumeros[i - 1] = aux;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lbox.Items.Clear();
        }
    }
}
