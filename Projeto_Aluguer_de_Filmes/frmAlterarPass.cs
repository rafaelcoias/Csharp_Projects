using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Base_de_Dados
{
    public partial class frmAlterarPass : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sLogin;

        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        public frmAlterarPass()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            //Ver a Password
            txtPassword.PasswordChar = txt1.PasswordChar;
            tmPasse.Enabled = true;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            //Ver a Password
            txtConfrm.PasswordChar = txt1.PasswordChar;
            tmPasse1.Enabled = true;
        }

        private void tmPasse_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
            tmPasse.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Nova Password não será salva, pretende mesmo sair?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtConfrm.Text != "")
            {
                MessageBox.Show("Escreva a sua nova Password.", "AVISO", MessageBoxButtons.OK);
            }
            else if (txtConfrm.Text == "" && txtPassword.Text != "")
            {
                MessageBox.Show("Confirme a sua nova Password.", "AVISO", MessageBoxButtons.OK);
            }
            else if (txtPassword.Text == "" && txtConfrm.Text == "")
            {
                MessageBox.Show("Preencha todos os campos\npara fazer o seu registro.", "AVISO", MessageBoxButtons.OK);
            }            
            else if (txtPassword.Text != "" && txtConfrm.Text != "")
            {
                if (txtPassword.Text == txtConfrm.Text)
                {
                    var resultado = MessageBox.Show("Tem a certeza que pretende guardar as\nalterações efectuadas?", "AVISO", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        LigarBD(ref Conn);
                        sSql = "UPDATE Utilizador SET Chave = '" + txtConfrm.Text + "' WHERE Login = '" + sLogin + "'";
                        command = new OleDbCommand(sSql, Conn);
                        command.ExecuteNonQuery();
                        Conn.Close();
                        var resultado2 = MessageBox.Show("Password guardadada com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK);
                        if (resultado2 == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }
                }                
                else
                {
                    MessageBox.Show("Garanta que a password é igual em ambos os campos.", "AVISO", MessageBoxButtons.YesNo);
                }
            }
        }

        private void tmPasse1_Tick(object sender, EventArgs e)
        {
            txtConfrm.PasswordChar = '●';
            tmPasse1.Enabled = false;
        }

        private void frmAlterarPass_Load(object sender, EventArgs e)
        {

        }
    }
}
