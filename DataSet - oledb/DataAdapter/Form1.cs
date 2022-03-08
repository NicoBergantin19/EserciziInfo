using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        DataTable Dt;
        OleDbDataAdapter Da;
        DataSet Ds;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ds = new DataSet("Auto");
            Da = new OleDbDataAdapter();
            //Dt = new DataTable("Marche");
            con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\5E Informatica\dbIV_convertito_originale.mdb");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Ds.Tables[listBox1.SelectedItem.ToString()];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            con.Open();
            Dt = con.GetSchema("Tables");
            //dataGridView1.DataSource = Dt;
            Ds = new DataSet();
            Da = new OleDbDataAdapter();
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            foreach (DataRow Riga in Dt.Rows)
            {
                if (Riga[3].ToString() == "TABLE")
                {
                    string query = "SELECT * FROM " + Riga[2].ToString();
                    Da.SelectCommand.CommandText = query;
                    Da.Fill(Ds, Riga[2].ToString());
                    listBox1.Items.Add(Riga[2].ToString());
                }

            }
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            /*Da = new OleDbDataAdapter(query1, con);
              DataTable Data = new DataTable("Marche");
            Da.SelectCommand = con.CreateCommand();
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = query1;
            Da.Fill(Data);
            foreach (DataRow riga in Data.Rows)
            {
                listBox1.Items.Add(riga["Marca"].ToString());
            }*/
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Da = new OleDbDataAdapter(textBox1.Text, con);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message, "Errore");
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Dt = Ds.Tables[listBox1.SelectedItem.ToString()];
            for (int colonna = 0; colonna < Dt.Columns.Count; colonna++)
            {
                string descrizione = "";
                descrizione += Dt.Columns[colonna].ColumnName.ToUpper() + " proprietà:";
                descrizione += Dt.Columns[colonna].AutoIncrement ? " Auto incrementa" : " Non auto incrementa";
                descrizione += " lungh. max:" + Dt.Columns[colonna].MaxLength + " ";
                descrizione += Dt.Columns[colonna].ReadOnly ? " Read Only" : "Modificabile";
                descrizione += Dt.Columns[colonna].Unique ? " Unica" : " Non unica";
                descrizione += Dt.Columns[colonna].DataType.ToString();

                listBox3.Items.Add(descrizione);

            }
        }

        private void button6_Click(object sender, EventArgs e)  //Aggiorna i dati modificati dal datagrid al db
        {
            if (Dt != null)
            {
                Dt.AcceptChanges();
            }
        }

        private void button7_Click(object sender, EventArgs e)  //Update
        {
            OleDbCommandBuilder cmb = new OleDbCommandBuilder(Da);
            try
            {
                Da.Update(Dt);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
