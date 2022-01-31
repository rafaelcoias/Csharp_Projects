using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Calculadora : Form
    {
        //variáveis
        bool bTestarZero, bTestarPonto, bTestarN1, bTestarSoma, bTestarSub, bTestarMulti, bTestarDiv;
        double dN1, dN2, dResultado;
        int bTestarN = 0;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void numeros(string btnNumero)
        {
            if (bTestarZero == false)
            {
                txtVisor.Clear();
                txtVisor.Text = txtVisor.Text + btnNumero;
                bTestarZero = true;
            }
            else if (bTestarZero == true)
            {
                txtVisor.Text = txtVisor.Text + btnNumero;
            }
        }
        private void operaçoes()
        {
            bTestarN++;
            if (bTestarN1 == true)
            {
                try
                {
                    dN2 = Convert.ToDouble(txtVisor.Text);
                }
                catch
                {
                    txtVisor.Text = "Erro";
                    dN2 = 0;
                }
                if (bTestarSoma == true)
                {
                    if (bTestarN >= 3)
                    {
                        dResultado = dResultado + dN2;
                    }
                    else
                    {
                        dResultado = dN1 + dN2;
                    }
                    
                }
                else if (bTestarSub == true)
                {
                    if (bTestarN >= 3)
                    {
                        dResultado = dResultado - dN2;
                    }
                    else
                    {
                        dResultado = dN1 - dN2;
                    }
                }
                else if (bTestarMulti == true)
                {
                    if (bTestarN >= 3)
                    {
                        dResultado = dResultado * dN2;
                    }
                    else
                    {
                        dResultado = dN1 * dN2;
                    }
                }
                else if (bTestarDiv == true)
                {
                    if (dN2 == 0)
                    {
                        txtVisor.Text = "Impossível";
                    }
                    else
                    {
                        if (bTestarN >= 3)
                        {
                            dResultado = dResultado / dN2;
                        }
                        else
                        {
                            dResultado = dN1 / dN2;
                        }
                        dResultado = dN1 / dN2;
                    }
                }
            }
            bTestarN1 = true;
            if (bTestarN == 1)
            {
                try
                {
                    dN1 = Convert.ToDouble(txtVisor.Text);
                    txtVisor.Text = "0";
                }
                catch
                {
                    txtVisor.Text = "Erro";
                    dN1 = 0;
                }

            }
            bTestarZero = false;
            bTestarPonto = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numeros(btn1.Text);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            numeros(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numeros(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numeros(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numeros(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numeros(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numeros(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numeros(btn8.Text);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operaçoes();
            bTestarSoma = true;
            bTestarMulti = false;
            bTestarSub = false;
            bTestarDiv = false;
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            operaçoes();
            bTestarSub = true;
            bTestarMulti = false;
            bTestarDiv = false;
            bTestarSoma = false;
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            operaçoes();
            bTestarMulti = true;
            bTestarDiv = false;
            bTestarSub = false;
            bTestarSoma = false;
        }

        private void btnPercentagem_Click(object sender, EventArgs e)
        {
            if (bTestarN1 == false)
            {
                dN1 = Convert.ToDouble(txtVisor.Text) / 100;
                txtVisor.Text = Convert.ToString(dN1);
                bTestarN1 = true;
            }
            else
            {
                dN2 = Convert.ToDouble(txtVisor.Text) / 100;
                txtVisor.Text = Convert.ToString(dN2);
                bTestarN1 = false;
            }
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            operaçoes();
            bTestarDiv = true;
            bTestarMulti = false;
            bTestarSub = false;
            bTestarSoma = false;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            dN1 = Convert.ToDouble(txtVisor.Text);
            dResultado = dN1 * dN1;
            txtVisor.Text = Convert.ToString(dResultado);
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
            bTestarPonto = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numeros(btn9.Text);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numeros(btn0.Text);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            bTestarZero = false;
            bTestarPonto = false;
            bTestarN = 0;

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            int Pos, TamVisor;
            TamVisor = txtVisor.Text.Length;

            for (Pos = 0; Pos < TamVisor; Pos++)
            {
                if (txtVisor.Text[Pos] == ',')
                {
                    bTestarPonto = true;
                }
            }
            if (bTestarZero == false)
            {
                if (bTestarPonto == false)
                {
                    txtVisor.Text = "0,";
                    bTestarZero = true;
                    bTestarPonto = true;
                }
            }
            else if (bTestarZero == true)
            {
                if (bTestarPonto == false)
                {
                    txtVisor.Text = txtVisor.Text + ",";
                    bTestarPonto = true;
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                dN2 = Convert.ToDouble(txtVisor.Text);
            }
            catch
            {
                txtVisor.Text = "Impossível";
                dN2 = 0;
            }

            if (bTestarSoma == true)
            {
                if (bTestarN >= 2)
                {
                    dResultado = dResultado + dN2;
                }
                else
                {
                    dResultado = dN1 + dN2;
                }
                txtVisor.Text = Convert.ToString(dResultado);
                bTestarSoma = false;
            }
            else if (bTestarSub == true)
            {
                if (bTestarN >= 2)
                {
                    dResultado = dResultado - dN2;
                }
                else
                {
                    dResultado = dN1 - dN2;
                }
                txtVisor.Text = Convert.ToString(dResultado);
                bTestarSub = false;
            }
            else if (bTestarMulti == true)
            {
                if (bTestarN >= 2)
                {
                    dResultado = dResultado * dN2;
                }
                else
                {
                    dResultado = dN1 * dN2;
                }
                txtVisor.Text = Convert.ToString(dResultado);
                bTestarMulti = false;
            }
            else if (bTestarDiv == true)
            {
                if (dN2 == 0)
                {
                    txtVisor.Text = "Impossível";
                }
                else
                {
                    if (bTestarN >= 2)
                    {
                        dResultado = dResultado / dN2;
                    }
                    else
                    {
                        dResultado = dN1 / dN2;
                    }
                    txtVisor.Text = Convert.ToString(dResultado);
                }
                bTestarDiv = false;
            }
        }
    }
}
