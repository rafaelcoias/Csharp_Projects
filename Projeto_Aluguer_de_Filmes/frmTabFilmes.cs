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
    public partial class frmTabFilmes : Form
    {
        public frmTabFilmes()
        {
            InitializeComponent();
        }

        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sID, sPesquisa;
        int iID = 0, iTam;

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
            lvDados.Columns.Add("Nome", 141, HorizontalAlignment.Center);
            lvDados.Columns.Add("Duração", 119, HorizontalAlignment.Center);
            lvDados.Columns.Add("Realizador", 150, HorizontalAlignment.Center);
            lvDados.Columns.Add("Ano", 77, HorizontalAlignment.Center);
        }

        private void Listar()
        {
            //Por na tabela os dados
            btnTitulo.BackColor = Color.Yellow;
            btnID.BackColor = Color.LightSkyBlue;
            btnDuracao.BackColor = Color.LightSkyBlue;
            btnRealizador.BackColor = Color.LightSkyBlue;
            btnAno.BackColor = Color.LightSkyBlue;
            sPesquisa = "Título";
            sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY NomeFilme";
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {
            iID = Convert.ToInt32(lvDados.SelectedItems[0].Text);
            frmEditarFilme.sID = lvDados.SelectedItems[0].Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("Tem a certeza que pretende eliminar\neste filme da lista de filmes ?", "Verificação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    LigarBD(ref Conn);
                    sSql = "SELECT * FROM Filme WHERE IDFilme = " + iID + "";
                    command = new OleDbCommand(sSql, Conn);
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        LigarBD(ref Conn);
                        sSql = "DELETE FROM Filme WHERE IDFilme = " + iID + "";
                        command = new OleDbCommand(sSql, Conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Filme Eliminado.", "Confirmação");
                    }
                    else
                    {
                        MessageBox.Show("Selecione o filme que quer eliminar.", "AVISO", MessageBoxButtons.YesNo);
                    }
                }
            }            
            catch
            {
                MessageBox.Show("Selecione o filme que quer eliminar.", "AVISO", MessageBoxButtons.YesNo);
            }
            iID = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            iID = 0;
            Form frmAdicionarFilme = new frmAdicionarFilme();
            frmAdicionarFilme.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LigarBD(ref Conn);
            sSql = "SELECT * FROM Filme WHERE IDFilme = " + iID + "";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Form frmEditarFilme = new frmEditarFilme();
                frmEditarFilme.Show();
            }
            else
            {
                MessageBox.Show("Selecione o filme que quer editar.", "AVISO", MessageBoxButtons.YesNo);
            }
            iID = 0;
        }

        private void frmTabFilmes_Activated(object sender, EventArgs e)
        {
            lvDados.Clear();
            CriarLista();
            Listar();
        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnTitulo.BackColor = Color.Yellow;
            btnDuracao.BackColor = Color.LightSkyBlue;
            btnRealizador.BackColor = Color.LightSkyBlue;
            btnAno.BackColor = Color.LightSkyBlue;
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
                sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY NomeFilme";
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

        private void btnID_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.Yellow;
            btnTitulo.BackColor = Color.LightSkyBlue;
            btnDuracao.BackColor = Color.LightSkyBlue;
            btnRealizador.BackColor = Color.LightSkyBlue;
            btnAno.BackColor = Color.LightSkyBlue;
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
                sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY IDFilme";
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

        private void btnDuracao_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnTitulo.BackColor = Color.LightSkyBlue;
            btnDuracao.BackColor = Color.Yellow;
            btnRealizador.BackColor = Color.LightSkyBlue;
            btnAno.BackColor = Color.LightSkyBlue;
            sPesquisa = "Duração";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY DuraçãoFilme";
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

        private void btnFav_Click(object sender, EventArgs e)
        {
            Form frmTabFavoritos = new frmTabFavoritos();
            frmTabFavoritos.Show();
        }

        private void btnRealizador_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnTitulo.BackColor = Color.LightSkyBlue;
            btnDuracao.BackColor = Color.LightSkyBlue;
            btnRealizador.BackColor = Color.Yellow;
            btnAno.BackColor = Color.LightSkyBlue;
            sPesquisa = "Realizador";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY Realizador";
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

        private void btnAno_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnTitulo.BackColor = Color.LightSkyBlue;
            btnDuracao.BackColor = Color.LightSkyBlue;
            btnRealizador.BackColor = Color.LightSkyBlue;
            btnAno.BackColor = Color.Yellow;
            sPesquisa = "Ano";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDFilme, NomeFilme, DuraçãoFilme, Realizador, AnoLançamento FROM Filme ORDER BY AnoLançamento";
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
            iID = 0;
            //Pesquisar mais rápido...
            (txtPesquisa.Text).Trim();
            iTam = (txtPesquisa.Text).Length;
            LigarBD(ref Conn);
            //ID,
            if (sPesquisa == "ID")
            {
                sSql = "SELECT * FROM Filme WHERE IDFilme LIKE '" + txtPesquisa.Text + "%'";
            }
            //Título,
            else if (sPesquisa == "Título")
            {
                sSql = "SELECT * FROM Filme WHERE NomeFilme LIKE '" + txtPesquisa.Text + "%'";
            }
            //Duração,
            else if (sPesquisa == "Duração")
            {
                sSql = "SELECT * FROM Filme WHERE DuraçãoFilme LIKE '" + txtPesquisa.Text + "%'";
            }
            //Realizador,
            else if (sPesquisa == "Realizador")
            {
                sSql = "SELECT * FROM Filme WHERE Realizador LIKE '" + txtPesquisa.Text + "%'";
            }
            //Ano,
            else if (sPesquisa == "Ano")
            {
                sSql = "SELECT * FROM Filme WHERE AnoLançamento LIKE '" + txtPesquisa.Text + "%'";
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

        private void frmTabFilmes_Load(object sender, EventArgs e)
        {
            lvDados.Clear();
            CriarLista();
            Listar();
            btnAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
