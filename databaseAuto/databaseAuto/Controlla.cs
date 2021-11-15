using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace databaseAuto
{
    public partial class Controlla : Form
    {
        SqlConnection connection;
        public Controlla(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }

        /*Conta le righe che hanno quei determinati valori*/
        private void Controlla_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand controllo = new SqlCommand($"SELECT COUNT (*) FROM Marche WHERE Città = '{textBox1.Text}' AND Marca = '{textBox2.Text}'", connection);
                int cont = Convert.ToInt32(controllo.ExecuteScalar()); //salva il numero di righe in contatore

                if (cont > 0)
                {
                    MessageBox.Show("Sono state trovati " + cont + " elementi con i valori inseriti", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Non sono stati trovati riscontri con i valori inseriti", "", MessageBoxButtons.OK);
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
