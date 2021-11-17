using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace oldb
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        string stringa = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Studente\Documents\car.accdb";
        public Form1()
        {
            con = new OleDbConnection();
            con.ConnectionString=stringa;


            InitializeComponent();
        }

        private void testcon_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("connessione aperta");
            }
            catch(OleDbException msg)
            {
                MessageBox.Show(msg.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void creaclienti_Click(object sender, EventArgs e)
        {
            string queery = "create table clienti (id autoincrement primary key, cognome varchar(20), nome text(20), fatturato float)";
            OleDbCommand cmd = new OleDbCommand(queery, con);
          
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();


            }
            catch (OleDbException msg)
            {
                MessageBox.Show(msg.Message);
                MessageBox.Show("tutto ok");
            }
            finally
            {
                con.Close();
            }
        }

        private void nuovocl_Click(object sender, EventArgs e)
        {
            string queery = " INSERT INTO clienti ( cognome, nome, fatturato )VALUES('dibianca', 'ciao', 1000); ";
            OleDbCommand cmd = new OleDbCommand(queery, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("tutto ok");

            }
            catch (OleDbException msg)
            {
                MessageBox.Show(msg.Message);
                MessageBox.Show("no ok");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
