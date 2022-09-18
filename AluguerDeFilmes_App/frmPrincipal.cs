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
    public partial class frmPrincipal : Form
    {
        OleDbConnection Conn;
        System.Media.SoundPlayer Musica = new System.Media.SoundPlayer();
        public static int iTentar = 0;
        public static string sBloqueado, sLogin, sID;

        public frmPrincipal()
        {
            InitializeComponent();
            Musica.SoundLocation = "netflixIntro.wav";
        }
        public void LigarBD(ref OleDbConnection Conn)
        {
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {           
            if (iTentar == 0 || iTentar == 1 || iTentar == 2)
            {
                (txtLogin.Text).Trim();
                (txtPasse.Text).Trim();
                if (txtLogin.Text == "")
                {
                    MessageBox.Show("Preencha o Nome de Utilizador");
                }
                if (txtPasse.Text == "")
                {
                    MessageBox.Show("Preencha a Palavra-Passe");
                }
                if (txtPasse.Text != "" && txtLogin.Text != "")
                {
                    OleDbCommand command;
                    OleDbDataReader dataReader;
                    string sSql;
                    sSql = "SELECT * FROM Utilizador WHERE Login = '" + txtLogin.Text + "'";
                    LigarBD(ref Conn);
                    command = new OleDbCommand(sSql, Conn);
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        sLogin = txtLogin.Text;
                        if (dataReader.GetBoolean(8) == true)
                        {
                            if (txtPasse.Text == dataReader.GetString(7) && iTentar < 3)
                            {
                                if(dataReader.GetString(6) == "Admistrador")
                                {
                                    Form frmAdminPrincipal = new frmAdminPrincipal();
                                    frmAdminPrincipal.Show();
                                }             
                                else if (dataReader.GetString(6) == "Utilizador")
                                {                                    
                                    LigarBD(ref Conn);
                                    sSql = "SELECT IDUtilizador, Login, Nome, Email, Telefone FROM Utilizador WHERE Login = '" + sLogin + "'";
                                    command = new OleDbCommand(sSql, Conn);
                                    dataReader = command.ExecuteReader();
                                    if (dataReader.Read())
                                    {
                                        frmDefinicoes.sLogin = sLogin;
                                        frmAlterarDados.sLogin = dataReader.GetString(1);
                                        frmAlterarDados.sUtilizador = dataReader.GetString(2);
                                        frmAlterarDados.sEmail = dataReader.GetString(3);
                                        frmAlterarDados.sTelefone = dataReader.GetString(4);
                                        frmAlterarPass.sLogin = dataReader.GetString(1);
                                        frmHistorico.sID = (dataReader.GetInt32(0)).ToString();
                                        frmFavoritos.sID = (dataReader.GetInt32(0)).ToString();
                                        sID = dataReader.GetInt32(0).ToString();
                                    }
                                    Form frmAluguer = new frmAluguer(sID);
                                    frmAluguer.Show();
                                }
                                else if (dataReader.GetString(6) == "Premium")
                                {                                   
                                    LigarBD(ref Conn);
                                    sSql = "SELECT IDUtilizador, Login, Nome, Email, Telefone FROM Utilizador WHERE Login = '" + sLogin + "'";
                                    command = new OleDbCommand(sSql, Conn);
                                    dataReader = command.ExecuteReader();
                                    if (dataReader.Read())
                                    {
                                        frmDefinicoes.sLogin = sLogin;
                                        frmAlterarDados.sLogin = dataReader.GetString(1);
                                        frmAlterarDados.sUtilizador = dataReader.GetString(2);
                                        frmAlterarDados.sEmail = dataReader.GetString(3);
                                        frmAlterarDados.sTelefone = dataReader.GetString(4);
                                        frmAlterarPass.sLogin = dataReader.GetString(1);
                                        frmHistorico.sID = (dataReader.GetInt32(0)).ToString();
                                        frmFavoritos.sID = (dataReader.GetInt32(0)).ToString();
                                        sID = dataReader.GetInt32(0).ToString();
                                    }
                                    Form frmPremium = new frmPremium(sID);
                                    frmPremium.Show();
                                }
                                iTentar = 0;
                            }
                            else if (txtPasse.Text != dataReader.GetString(7) && iTentar < 3)
                            {
                                iTentar++;
                                if (iTentar == 1)
                                {
                                    MessageBox.Show("Palavra Passe Incorreta!", "Restam 2 Tentativas");
                                }
                                else if (iTentar == 2)
                                {
                                    MessageBox.Show("Palavra Passe Incorreta!", "Restam 1 Tentativas");
                                }
                                else if (iTentar > 2)
                                {
                                    iTentar = 0;
                                    MessageBox.Show("Utilizador Bloqueado!\nContacte 963 687 459 para mais informações.");
                                    sSql= "UPDATE Utilizador SET Ativo = false WHERE Login = '" + txtLogin.Text + "'";
                                    command = new OleDbCommand(sSql, Conn);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Utilizador Bloqueado!\nContacte 963 687 459 para mais informações.");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Utilizador Não Existe!");
                    }
                    Conn.Close();
                }
            }       
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Form frmRegistar = new frmRegistar();
            frmRegistar.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\Imagem\\netflix_logo.png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\Imagem\\netflix lg.jpg");
            Musica.Play();
            tmInicio.Enabled = true;
        }

        private void tmInicio_Tick(object sender, EventArgs e)
        {
            tmInicio.Enabled = false;
            lblUtilizador.Visible = true;
            lblPasse.Visible = true;
            txtLogin.Visible = true;
            txtPasse.Visible = true;
            btnEntrar.Visible = true;
            btnSair.Visible = true;
            btnRegistar.Visible = true;
            gb1.Visible = true;
            pictureBox2.Visible = true;
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\Imagem\\black.png");
        }
    }
}
