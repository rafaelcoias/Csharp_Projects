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
    public partial class frmDesc : Form
    {
        public static string sDescricao;
        int iDescTam;
        public frmDesc()
        {
            InitializeComponent();
            MessageBox.Show("Prima Enter após escrever.", "Descrição do Alarme", MessageBoxButtons.OK);
        }

        private void tbDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                sDescricao = tbDesc.Text;
                iDescTam = sDescricao.Length;
                if (iDescTam > 22)
                {
                    MessageBox.Show("Limite de letras atingido.\nTente Novamente.", "Descrição do Alarme", MessageBoxButtons.OK);
                    tbDesc.Text = "";
                }
                else
                {
                    frmPrincipal.sDesc = sDescricao;
                    this.Close();
                }
            }
        }
    }
}
