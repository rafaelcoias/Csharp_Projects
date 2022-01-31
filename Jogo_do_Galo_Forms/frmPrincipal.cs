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
    public partial class frmPrincipal : Form
    {
        //Variáveis
        public static string sJog1 = "Jogador 1", sJog2 = "Jogador 2";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contraIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sJog1 = tb1.Text;
            sJog2 = tb2.Text;
            frmJogo.bMulti = false;
            frmJogo.bAI = true;
            if (sJog1.Length > 9 || sJog2.Length > 9)
            {
                lblAviso.Visible = true;
            }
            else if (sJog1.Length < 2 || sJog2.Length < 2)
            {
                sJog1 = "Jogador 1";
            }
            else if ((sJog1.Length < 10 && sJog2.Length < 10) && (sJog1.Length > 2 && sJog2.Length > 2))
            {
                frmJogo.sJog1 = sJog1;
                frmJogo.sJog2 = "Computador";
                tmJogo.Enabled = true;
                lblAviso.Visible = false;
            }
        }

        private void tmJogo_Tick(object sender, EventArgs e)
        {
            Form frmJogo = new frmJogo();
            frmJogo.Show();
            tmJogo.Enabled = false;
        }

        private void jogoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmJogo.bJogo1 = true;
            frmJogo.bJogo3 = false;
            frmJogo.bJogo5 = false;
        }

        private void melhorDe3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogo.bJogo1 = false;
            frmJogo.bJogo3 = true;
            frmJogo.bJogo5 = false;
        }

        private void melhorDe5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogo.bJogo1 = false;
            frmJogo.bJogo3 = false;
            frmJogo.bJogo5 = true;
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (colorDialog1.Color == Color.Black || colorDialog1.Color == Color.Red )
                {
                    MessageBox.Show("Cor não pode ser defenida como fundo", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    BackColor = colorDialog1.Color;
                }
            }            
        }

        private void fácilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogo.bFacil = true;
            frmJogo.bDif = false;
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJogo.bDif = true;
            frmJogo.bFacil = false;
        }

        private void peçasDeJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPecas = new frmPecas();
            frmPecas.Show();
        }

        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sJog1 = tb1.Text;
            sJog2 = tb2.Text;
            frmJogo.bMulti = true;
            frmJogo.bAI = false;
            if (sJog1.Length > 9 || sJog2.Length > 9)
            {
                lblAviso.Visible = true;
            }
            else if (sJog1.Length < 2 || sJog2.Length < 2)
            {
                sJog1 = "Jogador 1";
                sJog2 = "Jogador 2";
            }
            else if ((sJog1.Length < 10 && sJog2.Length < 10) && (sJog1.Length > 2 && sJog2.Length > 2))
            {
                frmJogo.sJog1 = sJog1;
                frmJogo.sJog2 = sJog2;
                tmJogo.Enabled = true;
                lblAviso.Visible = false;
            }
        }
    }
}
