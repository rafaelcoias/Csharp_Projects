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
    public partial class frmAlterarDados : Form
    {
        public frmAlterarDados()
        {
            InitializeComponent();
        }

        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sLogin, sUtilizador, sEmail, sMorada, sTelefone;

        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        private void frmAlterarDados_Load(object sender, EventArgs e)
        {
            txtLogin.Text = sLogin;
            txtUtilizador.Text = sUtilizador;
            txtEmail.Text = sEmail;
            txtTelefone.Text = sTelefone;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Os seus dados não serão salvos, pretende mesmo sair?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            (txtLogin.Text).Trim();
            (txtUtilizador.Text).Trim();
            (txtEmail.Text).Trim();
            (txtTelefone.Text).Trim();
            if (txtLogin.Text == "" || txtUtilizador.Text == "" || txtEmail.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos\npara fazer o seu registro.", "AVISO", MessageBoxButtons.OK);
            }
            if (txtLogin.Text != "" && txtUtilizador.Text != "" && txtEmail.Text != "" && txtTelefone.Text != "")
            {
                var resultado = MessageBox.Show("Tem a certeza que pretende Guardar as\nalterações efectuadas?", "AVISO", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    LigarBD(ref Conn);
                    sSql = "SELECT * FROM Utilizador WHERE Login = '" + txtLogin.Text + "'";
                    command = new OleDbCommand(sSql, Conn);
                    dataReader = command.ExecuteReader();
                    //Verificar se Login Existe
                    try
                    {
                        LigarBD(ref Conn);
                        sSql = "UPDATE Utilizador SET Login = '" + txtLogin.Text + "', Nome = '" + txtUtilizador.Text + "', Email = '" + txtEmail.Text + "', Telefone = '" + txtTelefone.Text + "' WHERE Login = '" + sLogin + "'";
                        command = new OleDbCommand(sSql, Conn);
                        command.ExecuteNonQuery();
                        Conn.Close();
                        var resultado2 = MessageBox.Show("Alterações guardadadas com sucesso!", "AVISO", MessageBoxButtons.OK);
                        if (resultado2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Login já existente, tente novamente.", "AVISO");
                    }
                }
            }
        }
    }
}
