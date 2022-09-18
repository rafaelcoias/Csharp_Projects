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
    public partial class frmUtilizadores : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sLogin, sNome, sID, sPerfil, sPTeste = "Login", sPesquisa = "Login";
        public static bool bAtivo;
        int iTam, iTam2;

        public frmUtilizadores()
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
            lvDados.Columns.Add("ID", 63, HorizontalAlignment.Left);
            lvDados.Columns.Add("Login", 100, HorizontalAlignment.Center);
            lvDados.Columns.Add("Nome", 125, HorizontalAlignment.Center);
            lvDados.Columns.Add("Email", 208, HorizontalAlignment.Center);
            lvDados.Columns.Add("Nascimento", 90, HorizontalAlignment.Center);
            lvDados.Columns.Add("Telefone", 90, HorizontalAlignment.Center);
            lvDados.Columns.Add("Perfil", 90, HorizontalAlignment.Center);
            lvDados.Columns.Add("Ativo", 49, HorizontalAlignment.Left);
        }

        private void Listar()
        {
            //Por na tabela os dados
            btnLogin.BackColor = Color.Yellow;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnID.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
            sPesquisa = "Login";
            sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Login";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                lvDados.Items.Add(item);
            }
            Conn.Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {            
            //Fazer Tabela
            if (sPTeste == "Login")
            {
                lvDados.Clear();
                CriarLista();
                Listar();
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void lvDados_DoubleClick(object sender, EventArgs e)
        {
            //Selecionar utilizador para ver as informações mais detalhadas
            int iID = Convert.ToInt32(lvDados.SelectedItems[0].Text);
            LigarBD(ref Conn);
            sSql = "SELECT * FROM Utilizador WHERE IDUtilizador = " + iID + "";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                sID = iID.ToString();
                sNome = dataReader.GetString(2);
                sPerfil = dataReader.GetString(6);
                bAtivo = dataReader.GetBoolean(8);
                frmInfoUtilizador.sNome = sNome;
                frmInfoUtilizador.sID = sID;
                frmInfoUtilizador.sPerfil = sPerfil;
                frmInfoUtilizador.bAtivo = bAtivo;
                if (bAtivo == dataReader.GetBoolean(8))
                {
                    Form frmInfoUtilizador = new frmInfoUtilizador();
                    frmInfoUtilizador.Show();
                }
            }            
            Conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.Yellow;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
            sPesquisa = "Login";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Login";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }           
            Conn.Close();
        }

        private void btnUtili_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.Yellow;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
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
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Nome";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.Yellow;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
            sPesquisa = "Perfil";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Perfil";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }            
            Conn.Close();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.Yellow;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
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
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY IDUtilizador";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);                    
                }
            }
            Conn.Close();
        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            //Fazer Tabela
            if (sPTeste == "Login")
            {
                lvDados.Clear();
                CriarLista();
                Listar();
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.Yellow;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.LightSkyBlue;
            sPesquisa = "Email";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Email";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnNascimento_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.Yellow;
            btnTelefone.BackColor = Color.LightSkyBlue;
            sPesquisa = "Nascimento";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY DataNascimento";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.LightSkyBlue;
            btnEmail.BackColor = Color.LightSkyBlue;
            btnNascimento.BackColor = Color.LightSkyBlue;
            btnTelefone.BackColor = Color.Yellow;
            sPesquisa = "Telefone";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Telefone";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);
                }
            }
            Conn.Close();
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            //Mudar a ordem em relação à coluna
            btnID.BackColor = Color.LightSkyBlue;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnUtili.BackColor = Color.LightSkyBlue;
            btnPerfil.BackColor = Color.LightSkyBlue;
            btnAtivo.BackColor = Color.Yellow;
            sPesquisa = "Ativo";
            lvDados.Clear();
            CriarLista();
            LigarBD(ref Conn);
            if (txtPesquisa.Text != "")
            {
                txtPesquisa_TextChanged(txtPesquisa, e);
            }
            else
            {
                sSql = "SELECT IDUtilizador, Login, Nome, Email, DataNascimento, Telefone, Perfil, Ativo FROM Utilizador ORDER BY Ativo";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(7).ToString() });
                    lvDados.Items.Add(item);                    
                }
            }            
            Conn.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Pesquisar mais rápido...
            lvDados.Clear();
            CriarLista();
            (txtPesquisa.Text).Trim();
            iTam = (txtPesquisa.Text).Length;
            LigarBD(ref Conn);
            //ID,
            if (sPesquisa == "ID")
            {
                sSql = "SELECT * FROM Utilizador WHERE IDUtilizador LIKE '" + txtPesquisa.Text + "%'";
            }
            //Logins,
            else if (sPesquisa == "Login")
            {
                sSql = "SELECT * FROM Utilizador WHERE Login LIKE '" + txtPesquisa.Text + "%'";
            }
            //Nomes,
            else if (sPesquisa == "Utilizador")
            {
                sSql = "SELECT * FROM Utilizador WHERE Nome LIKE '" + txtPesquisa.Text + "%'";
            }
            //Perfis,
            else if (sPesquisa == "Perfil")
            {
                sSql = "SELECT * FROM Utilizador WHERE Perfil LIKE '" + txtPesquisa.Text + "%'";
            }
            //Ativos,
            else if (sPesquisa == "Ativo")
            {
                sSql = "SELECT * FROM Utilizador WHERE Ativo LIKE '" + txtPesquisa.Text + "%'";
            }
            //Email,
            else if (sPesquisa == "Email")
            {
                sSql = "SELECT * FROM Utilizador WHERE Email LIKE '" + txtPesquisa.Text + "%'";
            }
            //Nascimento,
            else if (sPesquisa == "Nascimento")
            {
                sSql = "SELECT * FROM Utilizador WHERE DataNascimento LIKE '" + txtPesquisa.Text + "%'";
            }
            //Telefone,
            else if (sPesquisa == "Telefone")
            {
                sSql = "SELECT * FROM Utilizador WHERE Telefone LIKE '" + txtPesquisa.Text + "%'";
            }
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new[] { dataReader.GetInt32(0).ToString(), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetBoolean(8).ToString() });
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
    }
}
