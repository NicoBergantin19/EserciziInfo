using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseAuto
{
    public partial class Inserimento : Form
    {
        SqlConnection con;
        public Inserimento(SqlConnection connection)
        {
            InitializeComponent();
            con = connection;
        }

        private int Ins(string marca, string citta, out string messaggio)
        {
            string cmdSql = $"INSERT INTO Marche (Marca, Città) VALUES ('{marca}', '{citta}')";
            try
            {
                messaggio = "Inserimento riuscito";
                SqlCommand com = new SqlCommand(cmdSql, con);
                //SqlCommand com = con.CreateCommand();
                //com.CommandType = CommandType.Text;
                //com.CommandText = cmdSql;
                // SqlCommand com = new SqlCommand();
                //com.Connection = con;
                //com.CommandType = CommandType.Text;
                //com.CommandText = cmdSql;
                return com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                messaggio = ex.Message;
                return -1;
            }
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Ins(txtMarca.Text.Trim(), txtCitta.Text.Trim(), out string msg);
            MessageBox.Show($"{msg}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Inserimento_Load(object sender, EventArgs e)
        {

        }
    }
}
