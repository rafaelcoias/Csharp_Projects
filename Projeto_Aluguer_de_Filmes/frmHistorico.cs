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
    public partial class frmHistorico : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sID;

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
            lvDados.Columns.Add("Data de Aluguer", 105, HorizontalAlignment.Center);
            lvDados.Columns.Add("Preço do Aluguer", 105, HorizontalAlignment.Center);
        }
        private void Listar()
        {
            sSql = "SELECT Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        public frmHistorico()
        {
            InitializeComponent();
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            //Fazer Tabela
            lvDados.Clear();
            CriarLista();
            Listar();
        }

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecente_Click(object sender, EventArgs e)
        {
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            sSql = "SELECT Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY DataAluguer DESC";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void btnAntigo_Click(object sender, EventArgs e)
        {
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            sSql = "SELECT Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY DataAluguer";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }
    }
}
