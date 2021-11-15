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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtable_Load(object sender, EventArgs e)
        {
            
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

        private void Inserisci_modifica_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");

            label2.Text = contarighe("select count(codice) from Marche").ToString();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)| string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("campi vuoti non validi");
                return;
            }
            string query = $"UPDATE Marche SET Città='{textBox2.Text}' where Marca='{textBox1.Text}'";
            SqlCommand cmd = new SqlCommand(query,connection);
            try
            {
                int rigeh= cmd.ExecuteNonQuery();
                if (rigeh == 0)
                {
                    MessageBox.Show($"la marca {textBox1.Text} non esiste");
                    return;
                }
                string query2 = $"select top 1 città from Marche where Marca='{textBox1.Text}'";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                SqlDataReader leggi=cmd2.ExecuteReader();
                
                leggi.Read();
                MessageBox.Show($"sono state modificate {rigeh} righe\nora {textBox1.Text} ha sede a {leggi["Città"]}");
                leggi.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("si è verificato un errore:\n"+error.Message);
                
            }

            visualizza("SELECT * FROM Marche");

            label2.Text = contarighe("select count(codice) from Marche").ToString();

        }
    }
}
