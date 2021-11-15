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
    public partial class Dtable : Form
    {
        SqlConnection connection;
        public Dtable(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        private int contarighe(string querySql)
        {
            SqlCommand com = new SqlCommand(querySql, connection);
            return (int)com.ExecuteScalar();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtable_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");

            label2.Text = contarighe("select count(codice) from Marche").ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT Marca FROM Marche");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT Città FROM Marche");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
