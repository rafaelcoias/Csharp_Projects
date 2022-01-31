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
    public partial class frmPecas : Form
    {
        public frmPecas()
        {
            InitializeComponent();
        }

        private void rb1_Click(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            frmJogo.bPeca1 = true;
            frmJogo.bPeca2 = false;
            frmJogo.bPeca3 = false;
            frmJogo.bPeca4 = false;
        }

        private void rb2_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            rb3.Checked = false;
            rb4.Checked = false;
            frmJogo.bPeca1 = false;
            frmJogo.bPeca2 = true;
            frmJogo.bPeca3 = false;
            frmJogo.bPeca4 = false;
        }

        private void rb3_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = true;
            rb4.Checked = false;
            frmJogo.bPeca1 = false;
            frmJogo.bPeca2 = false;
            frmJogo.bPeca3 = true;
            frmJogo.bPeca4 = false;
        }

        private void rb4_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = true;
            frmJogo.bPeca1 = false;
            frmJogo.bPeca2 = false;
            frmJogo.bPeca3 = false;
            frmJogo.bPeca4 = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
