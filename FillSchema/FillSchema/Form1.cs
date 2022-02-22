using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FillSchema
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
            con = new SqlConnection("Data Source = informatica216\\informatica225; Initial Catalog=auto; Integrated Security = True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query1 = "Select * FROM Marche";
            Da = new SqlDataAdapter(query1, con);
            Dt = new DataTable("Marche");

            //Da.FillSchema(Dt, SchemaType.Source);
            Da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            string query2 = "SELECT * FROM Marche WHERE Città = 'Bologna'";
            Da = new SqlDataAdapter(query2, con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int colonna = 0; colonna < Dt.Columns.Count; colonna++)
            {
                string descrizione = "";
                descrizione += Dt.Columns[colonna].ColumnName.ToUpper() + " proprietà:";
                descrizione += Dt.Columns[colonna].AutoIncrement ? " Auto incrementa" : " Non auto incrementa";
                descrizione += " lungh. max:" + Dt.Columns[colonna].MaxLength + " ";
                descrizione += Dt.Columns[colonna].ReadOnly ? " Read Only" : "Modificabile";
                descrizione += Dt.Columns[colonna].Unique ? " Unica" : " Non unica";
                descrizione += Dt.Columns[colonna].DataType.ToString();

                listBox1.Items.Add(descrizione);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmb = new SqlCommandBuilder(Da);
            try
            {
                Da.Update(Dt);
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            if (Dt != null)
            {
                foreach (DataRow riga in Dt.Rows)
                {
                    listBox3.Items.Add(riga.RowState.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Dt != null)
            {
                Dt.AcceptChanges();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Dt != null)
            {
                Dt.RejectChanges();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (DataRow riga in Dt.Rows)
            {
                foreach (DataColumn col in Dt.Columns)
                {
                    listBox2.Items.Add("originale" + riga[col, DataRowVersion.Original].ToString() + "Corrente:" + riga[col, DataRowVersion.Current].ToString());
                }
            }
        }
    }
}