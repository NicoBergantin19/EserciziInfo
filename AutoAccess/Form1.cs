using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AutoAccess
{
    public partial class Form1 : Form
    {
        public OleDbConnection connection;
        public string ConString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\5E Informatica\AutoAccess\bin\Debug\eeeMachine.accdb";
        public Form1()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = ConString;
            InitializeComponent();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                textBox1.Text = ("Connessione eseguita\r\n" + connection.ServerVersion + "\r\n" + connection.ConnectionString + "\r\n");
                MessageBox.Show("Connessione eseguita correttamente", "", MessageBoxButtons.OK);
            }
            catch (OleDbException error)
            {
                MessageBox.Show(error.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cHECKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                textBox1.Text = "La connessione è aperta\n";
            }
            else
            {
                textBox1.Text = "La connessione è chiusa\n";
            }
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                textBox1.Text = "La connessione è stata chiusa\n";
            }
            else
            {
                textBox1.Text = "La connessione è già chiusa\n";
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ricercaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creaTabellaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scanceaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vardaTabeaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
