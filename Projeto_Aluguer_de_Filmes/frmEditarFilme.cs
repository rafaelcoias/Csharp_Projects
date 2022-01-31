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
    public partial class frmEditarFilme : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql, sNome, sAno, sPreço, sID;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPreco.Text != "")
            {
                var resultado = MessageBox.Show("Tem a certeza que pretende Guardar as\nalterações efectuadas?", "AVISO", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    LigarBD(ref Conn);
                    sSql = "SELECT * FROM Filme WHERE IDFilme = " + Convert.ToInt32(sID) + "";
                    command = new OleDbCommand(sSql, Conn);
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        LigarBD(ref Conn);
                        sSql = "UPDATE Filme SET PreçoFilme = '" + txtPreco.Text + "' WHERE IDFilme = " + Convert.ToInt32(sID) + "";
                        command = new OleDbCommand(sSql, Conn);
                        command.ExecuteNonQuery();
                        Conn.Close();
                        var resultado2 = MessageBox.Show("Alterações guardadadas com sucesso!", "AVISO", MessageBoxButtons.OK);
                        if (resultado2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }                       
                }
            }
            else
            {

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Os dados editados não serão salvos.\nPretende sair?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void LigarBD(ref OleDbConnection Conn)
        {
            //fazer conexão BaseDeDados
            Conn = new OleDbConnection();
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\BD\\BaseDeDados.accdb";
            Conn.ConnectionString = sConn;
            Conn.Open();
        }

        public frmEditarFilme()
        {
            InitializeComponent();
        }

        private void frmEditarFilme_Load(object sender, EventArgs e)
        {
            LigarBD(ref Conn);
            sSql = "SELECT NomeFilme, AnoLançamento, PreçoFilme FROM Filme WHERE IDFilme = " + Convert.ToInt32(sID) + "";
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                lblNome.Text = dataReader.GetString(0);
                lblAno.Text = dataReader.GetString(1);
                txtPreco.Text = dataReader.GetString(2);
            }
        }
    }
}
