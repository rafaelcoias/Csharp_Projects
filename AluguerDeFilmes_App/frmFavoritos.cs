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
    public partial class frmFavoritos : Form
    {
        OleDbConnection Conn;
        OleDbCommand command;
        OleDbDataReader dataReader;
        public static string sSql, sID, sIDFilme;

        public frmFavoritos()
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
            sSql = "SELECT Filme.NomeFilme, Filme.DuraçãoFilme, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Favoritos ON Utilizador.IDUtilizador = Favoritos.IDUtilizador) ON Filme.IDFilme = Favoritos.IDFilme WHERE(((Favoritos.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
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

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {
            sSql = "SELECT * FROM Utilizador WHERE IDUtilizador = " + Convert.ToInt32(sID) + "";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if (dataReader.GetString(6) == "Premium")
                {
                    var resultado = MessageBox.Show("Quer ver o Filme ?", "AVISO", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Filme Reproduzido.", "AVISO");
                    }
                }
                else
                {
                    MessageBox.Show("Tem de Alugar o Filme.", "AVISO");
                }
            }                
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFavoritos_Load(object sender, EventArgs e)
        {
            CriarLista();
            Listar();
        }
    }
}
