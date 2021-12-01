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
    public partial class Inserisci_modifica : Form
    {
        SqlConnection connection;
        public Inserisci_modifica(SqlConnection con)
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

        private int modifica(string marca, string citta, out string messaggio)
        {

            string cmdSql = $"UPDATE Marche SET Città = '{citta}' WHERE Marca = '{marca}'";
            try
            {
                SqlCommand com = new SqlCommand(cmdSql, connection);
                messaggio = "Modifica riuscita";
    
                return com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                messaggio = ex.Message;
                return -1;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inserisci_modifica_Load_1(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");

            //label2.Text = contarighe("select count(codice) from Marche").ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            modifica(textBox1.Text, textBox2.Text, out string msg);
            MessageBox.Show($"{msg}");
            visualizza("SELECT * FROM Marche");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cellrow= dataGridView1.CurrentRow.Index;
            txtindice.Text = dataGridView1[0, cellrow].Value.ToString();
            textBox1.Text = dataGridView1[1, cellrow].Value.ToString();
            textBox2.Text = dataGridView1[2, cellrow].Value.ToString();

        }
    }
}
