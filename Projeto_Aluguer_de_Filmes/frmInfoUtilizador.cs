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
    public partial class frmInfoUtilizador : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sPesquisa, sID, sNome, sPerfil;
        public static bool bAtivo;
        int iTam, iTam2;

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
        }

        private void Listar()
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.Yellow;
            btnPreco.BackColor = Color.LightSkyBlue;
            sPesquisa = "Data";
            LigarBD(ref Conn);
            sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY DataAluguer DESC";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = true;
            btnGuardar.Visible = false;
            LigarBD(ref Conn);
            sSql = "UPDATE Utilizador SET Perfil = '" + comboBox1.Text + "'  WHERE Nome = '" + lblNome.Text + "'";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (checkBox1.Checked == true)
            {
                sSql = "UPDATE Utilizador SET Ativo = true WHERE Nome = '" + lblNome.Text + "'";
            }
            else
            {
                sSql = "UPDATE Utilizador SET Ativo = false WHERE Nome = '" + lblNome.Text + "'";
            }
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();

        }

        private void btnID_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.Yellow;
            btnFilme.BackColor = Color.LightSkyBlue;
            btnData.BackColor = Color.LightSkyBlue;
            btnPreco.BackColor = Color.LightSkyBlue;
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
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY IDAluguer";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
                    lvDados.Items.Add(item);
                }
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
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY NomeFilme";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
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
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY DataAluguer";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
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
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + ")) ORDER BY PreçoFilme";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Pesquisar mais rápido...
            (txtPesquisa.Text).Trim();
            iTam = (txtPesquisa.Text).Length;
            LigarBD(ref Conn);
            //ID,
            if (sPesquisa == "ID")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Aluguer.IDAluguer) LIKE '" + txtPesquisa.Text + "%')) AND (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
            }
            //Título,
            else if (sPesquisa == "Título")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Filme.NomeFilme) LIKE '" + txtPesquisa.Text + "%')) AND (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
            }
            //Duração,
            else if (sPesquisa == "Data")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Aluguer.DataAluguer) LIKE '" + txtPesquisa.Text + "%')) AND (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
            }
            //Realizador,
            else if (sPesquisa == "Preço")
            {
                sSql = "SELECT Aluguer.IDAluguer, Filme.NomeFilme, Aluguer.DataAluguer, Filme.PreçoFilme FROM Filme INNER JOIN(Utilizador INNER JOIN Aluguer ON Utilizador.IDUtilizador = Aluguer.IDUtilizador) ON Filme.IDFilme = Aluguer.IDFilme WHERE (((Filme.PreçoFilme) LIKE '" + txtPesquisa.Text + "%')) AND (((Utilizador.IDUtilizador) = " + Convert.ToInt32(sID) + "))";
            }
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            lvDados.Clear();
            CriarLista();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3) });
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmInfoUtilizador()
        {
            InitializeComponent();
        }

        private void frmInfoUtilizador_Load(object sender, EventArgs e)
        {
            lblNome.Text = sNome;
            lblID.Text = sID;
            comboBox1.Text = sPerfil;
            checkBox1.Checked = bAtivo;
            //Fazer Tabela
            lvDados.Clear();
            CriarLista();
            Listar();
        }
    }
}
