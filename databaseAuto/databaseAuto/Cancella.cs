using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseAuto
{
    public partial class Cancella : Form
    {
        SqlConnection connection;
        public Cancella(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        private void visualizza(string querySql)
        {
            SqlCommand com = new SqlCommand(querySql, connection);
            SqlDataReader rd;
            DataTable td = new DataTable();
            rd = com.ExecuteReader();
            td.Load(rd);
            dataGridView1.DataSource = td;

            rd.Close();
        }
        private void Cancella_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM dbo.Marche WHERE Città = '{textBox1.Text}' AND Marca = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Azione eseguita correttamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                visualizza("SELECT * FROM Marche");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
