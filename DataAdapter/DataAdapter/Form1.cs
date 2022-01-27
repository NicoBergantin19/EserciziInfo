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
            con = new SqlConnection("Data Source = informatica201\\informatica225; Initial Catalog=auto; Integrated Security = True");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string query1 = "Select * FROM Marche";
            /*Da = new SqlDataAdapter(query1, con);
              Dt = new DataTable("Marche");*/
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = query1;

            con.Open();
            Da.Fill(Dt); 
            dataGridView1.DataSource = Dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            con.Open();
            
            string query1 = "Select * FROM Marche";
            /*Da = new SqlDataAdapter(query1, con);*/
              DataTable Data = new DataTable("Marche");
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = query1;
            Da.Fill(Data);
            foreach (DataRow riga in Data.Rows)
            {
                listBox1.Items.Add(riga["Marca"].ToString());
            }
            con.Close();
        }
    }
}
