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
    public partial class frmTabFavoritos : Form
    {
        //Variáveis
        public static OleDbConnection Conn;
        public static OleDbCommand command;
        public static OleDbDataReader dataReader;
        public static string sSql;
        int iCount, iMax, iFav;

        public frmTabFavoritos()
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
            lvDados.Columns.Add("Nº de Gostos", 100, HorizontalAlignment.Left);
            lvDados.Columns.Add("Filme", 150, HorizontalAlignment.Center);
        }

        private void Listar()
        {
            //Por na tabela os dados
            iMax = 0;
            iCount = 0;
            iFav = 0;
            sSql = "SELECT COUNT(IDFilme) FROM Filme";
            LigarBD(ref Conn);
            command = new OleDbCommand(sSql, Conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                iMax = dataReader.GetInt32(0);
            }
            while (iCount < iMax)
            {
                iFav = 0;
                iCount++;
                LigarBD(ref Conn);
                sSql = "SELECT IDFavoritos FROM Favoritos WHERE IDFilme = " + iCount + "";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    iFav++;
                }
                LigarBD(ref Conn);
                sSql = "SELECT NomeFilme FROM Filme WHERE IDFilme = " + iCount + "";
                command = new OleDbCommand(sSql, Conn);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    if (iFav != 0)
                    {
                        ListViewItem item = new ListViewItem(new[] { iFav.ToString(), dataReader.GetString(0) });
                        lvDados.Items.Add(item);
                    }                   
                }
            }
        }

        private void frmTabFavoritos_Load(object sender, EventArgs e)
        {
            lvDados.Clear();
            CriarLista();
            Listar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
