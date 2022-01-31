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
    public partial class frmPremium : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sLogin, sPesquisa, sID, sID1, sIDFilme;
        public static bool bAtivo = true;
        int iTam;

        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        private void CriarLista()
        {
            lvDados.View = View.Details;
            lvDados.GridLines = true;
            lvDados.FullRowSelect = true;
            lvDados.Columns.Add("Nome do Filme", 105, HorizontalAlignment.Center);
            lvDados.Columns.Add("Duração do Filme", 105, HorizontalAlignment.Center);
            lvDados.Columns.Add("Preço", 88, HorizontalAlignment.Center);
        }
        private void Listar()
        {
            sSql = "SELECT NomeFilme, DuraçãoFilme, PreçoFilme FROM Filme ORDER BY NomeFilme";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Pesquisar mais rápido...
            (txtPesquisa.Text).Trim();
            iTam = (txtPesquisa.Text).Length;
            LigarBD(ref Conn);
            //Nome do Filme
            sSql = "SELECT NomeFilme, DuraçãoFilme, PreçoFilme FROM Filme WHERE NomeFilme LIKE '" + txtPesquisa.Text + "%'";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            lvDados.Clear();
            CriarLista();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2) });
                lvDados.Items.Add(item);
            }
            if ((txtPesquisa.Text).Length == 0)
            {
                lvDados.Clear();
                CriarLista();
                Listar();
            }
            Conn.Close();
        }

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {
            LigarBD(ref Conn);
            sSql = "SELECT * FROM Filme WHERE NomeFilme = '" + lvDados.SelectedItems[0].Text + "'";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                sIDFilme = dataReader.GetInt32(0).ToString();
                lblNome.Text = dataReader.GetString(1);
                lblRealizador.Text = dataReader.GetString(3);
                lblData.Text = dataReader.GetString(4);
                pbFilme.ImageLocation = dataReader.GetString(6);
            }
            LigarBD(ref Conn);
            sSql = "SELECT * FROM Favoritos WHERE IDUtilizador = " + Convert.ToInt32(sID1) + " AND IDFilme = " + Convert.ToInt32(sIDFilme) + "";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                lblVazio.Visible = false;
                lblCheio.Visible = true;
            }
            else
            {
                lblVazio.Visible = true;
                lblCheio.Visible = false;
            }
            Conn.Close();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Fazer Tabela
            lvDados.Clear();
            CriarLista();
            Listar();
        }

        private void btnRecentes_Click(object sender, EventArgs e)
        {
            //Fazer Tabela
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            sSql = "SELECT NomeFilme, DuraçãoFilme, PreçoFilme FROM Filme ORDER BY AnoLançamento DESC";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filme Reproduzido.", "AVISO", MessageBoxButtons.OK);
        }

        private void lblCheio_Click(object sender, EventArgs e)
        {
            lblCheio.Visible = false;
            lblVazio.Visible = true;
            LigarBD(ref Conn);
            sSql = "DELETE FROM Favoritos WHERE IDUtilizador = " + Convert.ToInt32(sID1) + " AND IDFilme = " + Convert.ToInt32(sIDFilme) + "";
            command = new OleDbCommand(sSql, Conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Filme removido dos Favoritos.", "AVISO", MessageBoxButtons.OK);
        }

        private void lblVazio_Click(object sender, EventArgs e)
        {
            lblCheio.Visible = true;
            lblVazio.Visible = false;
            LigarBD(ref Conn);
            sSql = "INSERT INTO Favoritos (IDUtilizador, IDFilme) VALUES ('" + Convert.ToInt32(sID1) + "', '" + Convert.ToInt32(sIDFilme) + "')";
            command = new OleDbCommand(sSql, Conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Filme adicionado aos Favoritos.", "AVISO", MessageBoxButtons.OK);
        }

        private void frmPremium_Load(object sender, EventArgs e)
        {
            //Fazer Tabela
            lvDados.Clear();
            CriarLista();
            Listar();
            btnDefinicoes.BackgroundImageLayout = ImageLayout.Stretch;
            bAtivo = true;
            LigarBD(ref Conn);
            sSql = "SELECT TOP 1 * FROM Filme";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                sIDFilme = dataReader.GetInt32(0).ToString();
                lblNome.Text = dataReader.GetString(1);
                lblRealizador.Text = dataReader.GetString(3);
                lblData.Text = dataReader.GetString(4);
                pbFilme.ImageLocation = dataReader.GetString(6);
            }
            LigarBD(ref Conn);
            sSql = "SELECT * FROM Favoritos WHERE IDUtilizador = " + Convert.ToInt32(sID1) + " AND IDFilme = " + Convert.ToInt32(sIDFilme) + "";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                lblVazio.Visible = false;
                lblCheio.Visible = true;
            }
            else
            {
                lblVazio.Visible = true;
                lblCheio.Visible = false;
            }
            Conn.Close();
        }

        public frmPremium()
        {
            InitializeComponent();
        }

        public frmPremium(string sID)
        {
            InitializeComponent();
            sID1 = sID;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Quer Terminar Sessão?", "Verificação", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            Form frmDefinicoes = new frmDefinicoes();
            frmDefinicoes.Show();
        }
    }
}
