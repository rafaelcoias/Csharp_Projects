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
    public partial class frmRegistar : Form
    {
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sDia, sMes, sAno;
        public static bool bTeste = false;

        public frmRegistar()
        {
            InitializeComponent();
        }
        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Ver a Password
            txtPassword.PasswordChar = txtLogin.PasswordChar;
            tmPasse.Enabled = true;
        }

        private void tmPasse_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
            tmPasse.Enabled = false;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Os seus dados não serão salvos, pretende mesmo sair?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmRegistar_Activated(object sender, EventArgs e)
        {
            if (bTeste == true)
            {
                txtNascimento.Text = sAno + "/" + sMes + "/" + sDia;
            }
            else
            {
                txtNascimento.Text = "";
            }
        }

        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            (txtLogin.Text).Trim();
            (txtUtilizador.Text).Trim();
            (txtEmail.Text).Trim();
            (txtTelefone.Text).Trim();
            if (txtLogin.Text == "" || txtUtilizador.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtNascimento.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos\npara fazer o seu registro.", "AVISO", MessageBoxButtons.OK);
            }
            if (txtLogin.Text != "" && txtUtilizador.Text != "" && txtPassword.Text != "" && txtEmail.Text != "" && txtNascimento.Text != "" && txtTelefone.Text != "")
            {
                LigarBD(ref Conn);
                sSql = "SELECT * FROM Utilizador WHERE Login = '" + txtLogin.Text + "'";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                //Verificar se Login Existe
                if (dataReader.Read())
                {
                    MessageBox.Show("Nome de Login já existe, por favor tente outro.", "AVISO");
                }
                else
                {
                    LigarBD(ref Conn);
                    sSql = "INSERT INTO Utilizador (Login, Nome, Email, DataNascimento, Telefone, Chave, Perfil, Ativo) VALUES ('" + txtLogin.Text + "', '" + txtUtilizador.Text + "', '" + txtEmail.Text + "', '" + txtNascimento.Text + "', '" + txtTelefone.Text + "', '" + txtPassword.Text + "', 'Utilizador', true)";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    Conn.Close();
                    var resultado = MessageBox.Show("Registro guardado com sucesso!", "AVISO", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void txtNascimento_Click(object sender, EventArgs e)
        {
            Form frmNascimento = new frmNascimento();
            frmNascimento.Show();
        }
    }
}
