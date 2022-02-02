using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DataAdapter
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataTable Dt;
        SqlDataAdapter Da;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Da = new SqlDataAdapter();
            Dt = new DataTable("Marche");
            con = new SqlConnection(@"Data Source=INFORMATICA216\INFORMATICA225;Initial Catalog=master;Integrated Security=True");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlConnection connDB = new SqlConnection($@"Data Source=INFORMATICA216\INFORMATICA225;Initial Catalog={listBox1.SelectedItem};Integrated Security=True");

            connDB.Open();

            /*string query = $"SELECT * FROM {listBox2.SelectedItem}";
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = query;

            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;*/

            Dt = connDB.GetSchema("tables");
            foreach (DataRow riga in Dt.Rows)
            {
                listBox2.Items.Add(riga["table_name"].ToString());
            }

            connDB.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string query1 = "Select * FROM Marche";
            //Da = new SqlDataAdapter(query1, con);
            //Dt = new DataTable("Marche");
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = query1;

            con.Open();
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();*/

            con.Open();
            Dt = con.GetSchema("databases");
            //dataGridView1.DataSource = Dt;
            foreach (DataRow table in Dt.Rows)
            {
                //dataGridView1.DataSource = Dt;
                listBox1.Items.Add(table[0].ToString());
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection($@"Data Source=INFORMATICA216\INFORMATICA225;Initial Catalog={listBox1.SelectedItem};Integrated Security=True");
            connDB.Open();

            string query = $"SELECT * FROM {listBox2.SelectedItem}";
            Da = new SqlDataAdapter(query, connDB);
            Dt = new DataTable("Tabella");
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;

            connDB.Close();
        }
    }
}
