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
            string cmdSql = $"INSERT INTO Marche (Marca, Città) VALUES (@marca, @citta)";
            //string cmdSql = $"INSERT INTO Marche (Marca, Città) VALUES ('{marca}', '{citta}')";
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

                // 1 meteodo generazione parametri
                /*if(com.Parameters.Count==0)
                {
                    com.Parameters.AddWithValue("@marca", marca);
                    com.Parameters.AddWithValue("@citta", citta);
                }
                return com.ExecuteNonQuery();*/

                // 2 metodo
                /*com.Parameters.Add("@marca", SqlDbType.Text);
                com.Parameters.Add("@citta", SqlDbType.NVarChar, 3);
                com.Parameters["@marca"].Value = marca;
                com.Parameters[1].Value = citta;
                return com.ExecuteNonQuery();*/

                // 3 metodo
                /*SqlParameter P1 = new SqlParameter("@marca",SqlDbType.VarChar,3);
                com.Parameters.Add(P1);
                com.Parameters[0].Value = marca;
                SqlParameter P2 = new SqlParameter("@citta", SqlDbType.VarChar, 3);
                com.Parameters.Add(P2);
                com.Parameters[1].Value = citta;*/

                // 4 metodo
                SqlParameter P1 = new SqlParameter();
                P1.ParameterName = "@marca";
                P1.SqlDbType = SqlDbType.NVarChar;
                P1.Size = 10;
                P1.Value = marca;
                com.Parameters.Add(P1);
                SqlParameter P2 = new SqlParameter();
                P2.ParameterName = "@citta";
                P2.SqlDbType = SqlDbType.NVarChar;
                P2.Size = 10;
                P2.Value = citta;
                com.Parameters.Add(P2);
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

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
