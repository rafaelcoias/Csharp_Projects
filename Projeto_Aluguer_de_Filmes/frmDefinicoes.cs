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
    public partial class frmDefinicoes : Form
    {
        OleDbConnection Conn;
        OleDbCommand command;
        OleDbDataReader dataReader;
        public static string sSql, sLogin;
        public frmDefinicoes()
        {
            InitializeComponent();
        }
        public void LigarBD(ref OleDbConnection Conn)
        {
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form frmAlterarDados = new frmAlterarDados();
            frmAlterarDados.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Form frmHistorico = new frmHistorico();
            frmHistorico.Show();
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {

            LigarBD(ref Conn);
            sSql = "SELECT * FROM Utilizador WHERE Login = '" + sLogin + "'";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if (dataReader.GetString(6) == "Premium")
                {
                    MessageBox.Show("Você já é Premium.", "AVISO");
                }
                else
                {
                    var resultado = MessageBox.Show("Tem a certeza que pretende comprar o\npacote PREMIUM por 12,99€ / mês ?", "Verificação", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        LigarBD(ref Conn);
                        sSql = "UPDATE Utilizador SET Perfil = 'Premium' WHERE Login = '" + sLogin + "'";
                        command = new OleDbCommand(sSql, Conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Compra Realizada! Você é Premium!", "Confirmação");
                    }
                }
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza que pretende desativar\na sua conta ?", "Verificação", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                LigarBD(ref Conn);
                sSql = "SELECT * FROM Utilizador WHERE Login = '" + sLogin + "'";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    LigarBD(ref Conn);
                    sSql = "UPDATE Utilizador SET Ativo = false WHERE Login = '" + sLogin + "'";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Conta Desativada.", "Confirmação");
                    frmAluguer.bAtivo = false;
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem a certeza que pretende eliminar\na sua conta ?\nEsta operação não poderá ser cancelada.", "Verificação", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                LigarBD(ref Conn);
                sSql = "SELECT * FROM Utilizador WHERE Login = '" + sLogin + "'";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    LigarBD(ref Conn);
                    sSql = "DELETE FROM Utilizador WHERE Login = '" + sLogin + "'";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Conta Eliminada.", "Confirmação");
                    frmAluguer.bAtivo = false;
                    this.Close();
                }
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            Form frmAlterarPass = new frmAlterarPass();
            frmAlterarPass.Show();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Form frmFavoritos = new frmFavoritos();
            frmFavoritos.Show();
        }

        private void frmDefinicoes_Activated(object sender, EventArgs e)
        {
            LigarBD(ref Conn);
            sSql = "SELECT Login, Nome, Email, Telefone FROM Utilizador WHERE Login = '" + sLogin + "'";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                frmAlterarDados.sLogin = dataReader.GetString(0);
                frmAlterarDados.sUtilizador = dataReader.GetString(1);
                frmAlterarDados.sEmail = dataReader.GetString(2);
                frmAlterarDados.sTelefone = dataReader.GetString(3);
            }
        }
    }
}
