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
    public partial class frmAdicionarFilme : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sFicheiro = "";

        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        public frmAdicionarFilme()
        {
            InitializeComponent();
        }

        private void btnCapa_Click(object sender, EventArgs e)
        {
            ofd1.InitialDirectory = "c:\\";
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                sFicheiro = ofd1.FileName;
                pbCapa.ImageLocation = sFicheiro;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Os dados não serão salvos.\nPretende sair?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "" || txtDuracao.Text == "" || txtRealizador.Text == "" || txtAno.Text == "" || txtPreco.Text == "" || sFicheiro == "")
            {
                MessageBox.Show("Preencha todos os campos\npara fazer o seu registro.", "AVISO", MessageBoxButtons.OK);
            }
            if (txtTitulo.Text != "" && txtDuracao.Text != "" && txtRealizador.Text != "" && txtAno.Text != "" && txtPreco.Text != "" && sFicheiro != "" )
            {
                //Verificar se Filme Existe
                LigarBD(ref Conn);
                sSql = "SELECT * FROM Filme WHERE NomeFilme = '" + txtTitulo.Text + "'";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    if (txtDuracao.Text == dataReader.GetString(2) && txtAno.Text == dataReader.GetString(4) && txtRealizador.Text == dataReader.GetString(3))
                    {
                        MessageBox.Show("Filme já adicionado, por favor insira outro.", "AVISO");
                    }
                }
                else
                {
                    LigarBD(ref Conn);
                    sSql = "INSERT INTO Filme (NomeFilme, DuraçãoFilme, Realizador, AnoLançamento, PreçoFilme, CapaFilme) VALUES ('" + txtTitulo.Text + "', '" + txtDuracao.Text + "', '" + txtRealizador.Text + "', '" + txtAno.Text + "', '" + txtPreco.Text + "', '" + sFicheiro + "')";
                    command = new OleDbCommand(sSql, Conn);
                    command.ExecuteNonQuery();
                    Conn.Close();
                    var resultado = MessageBox.Show("Registro guardado com sucesso!", "AVISO", MessageBoxButtons.OK);
                    if (resultado == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
