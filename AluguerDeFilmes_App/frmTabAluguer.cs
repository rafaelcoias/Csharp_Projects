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
    public partial class frmTabAluguer : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sPesquisa;

        public frmTabAluguer()
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

        private void CriarLista()
        {
            lvDados.View = View.Details;
            lvDados.GridLines = true;
            lvDados.FullRowSelect = true;
            lvDados.Columns.Add("ID", 67, HorizontalAlignment.Left);
            lvDados.Columns.Add("Nome", 167, HorizontalAlignment.Center);
            lvDados.Columns.Add("Data", 138, HorizontalAlignment.Center);
            lvDados.Columns.Add("Preço", 137, HorizontalAlignment.Center);
            lvDados.Columns.Add("Utilizador", 125, HorizontalAlignment.Center);
        }
        private void Listar()
        {
            //Por na tabela os dados
            btnData.BackColor = Color.Yellow;
            btnID.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnUtilizador.BackColor = Color.LightSkyBlue;
            sPesquisa = "Data";
            sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY DataAluguer DESC";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnID_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.Yellow;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.LightSkyBlue;
            btnUtilizador.BackColor = Color.LightSkyBlue;
            sPesquisa = "ID";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY IDAluguer";
                LigarBD(ref Conn);
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Pesquisar mais rápido...
            (txtPesquisa.Text).Trim();
            LigarBD(ref Conn);
            //ID,
            if (sPesquisa == "ID")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Aluguer.IDAluguer) Like '" + txtPesquisa.Text +  "%'))";
            }
            //Título,
            else if (sPesquisa == "Título")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Filme.NomeFilme) Like '" + txtPesquisa.Text + "%'))";
            }
            //Duração,
            else if (sPesquisa == "Data")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Aluguer.DataAluguer) Like '" + txtPesquisa.Text + "%'))";
            }
            //Realizador,
            else if (sPesquisa == "Preço")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Filme.PreçoFilme) Like '" + txtPesquisa.Text + "%'))";
            }
            //Realizador,
            else if (sPesquisa == "Utilizador")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.Nome) Like '" + txtPesquisa.Text + "%'))";
            }
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            lvDados.Clear();
            CriarLista();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
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

        private void btnFilme_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.Yellow;
            btnData.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.LightSkyBlue;
            btnUtilizador.BackColor = Color.LightSkyBlue;
            sPesquisa = "Título";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY NomeFilme";
                LigarBD(ref Conn);
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.Yellow;
            btnPreco.BackColor = Color.LightSkyBlue;
            btnUtilizador.BackColor = Color.LightSkyBlue;
            sPesquisa = "Data";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY DataAluguer DESC";
                LigarBD(ref Conn);
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnUtilizador_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.LightSkyBlue;
            btnUtilizador.BackColor = Color.Yellow;
            sPesquisa = "Utilizador";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY Nome";
                LigarBD(ref Conn);
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnPreco_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.Yellow;
            btnUtilizador.BackColor = Color.LightSkyBlue;
            sPesquisa = "Preço";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme, Utilizador.Nome FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme ORDER BY PreçoFilme";
                LigarBD(ref Conn);
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void frmTabAluguer_Load(object sender, EventArgs e)
        {
            //Listar
            lvDados.Clear();
            CriarLista();
            Listar();
        }
    }
}
