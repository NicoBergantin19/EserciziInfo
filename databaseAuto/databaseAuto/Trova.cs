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
using System.Data;

namespace databaseAuto
{
    public partial class Trova : Form
    {
        SqlConnection connection;
        public Trova(SqlConnection con)
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

        private void Trova_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                visualizza($"SELECT * FROM Marche WHERE Città = '{textBox1.Text}' AND Marca = '{textBox2.Text}'");
            else if (radioButton2.Checked == true)
                visualizza($"SELECT * FROM Marche WHERE Città = '{textBox1.Text}'");
            else
                visualizza($"SELECT * FROM Marche WHERE Marca = '{textBox2.Text}'");
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Marche WHERE Città = '{textBox1.Text}' AND Marca = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Azione eseguita correttamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                visualizza(query);
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
