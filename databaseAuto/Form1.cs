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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=INFORMATICA201\\INFORMATICA225;Initial Catalog=Auto;Integrated Security=True";
            //con.ConnectionString = "Server=INFORMATICA208\\INFORMATICA225;Database=Car;Integrated Security=False;Persist Security Info=False; User ID=sa;Password=1"; //Persist Securety Info = False serve per rimuovere le credenziali di accesso dopo la connessione
            try
            {
                con.Open();
                txt.Text = ("Connessione eseguita\r\n" + con.ServerVersion + "\r\n" + con.ConnectionString + "\r\n");
            }
            catch (SqlException ex)
            {
                txt.Text += ("Connessione fallita" + ex.ToString());
            }
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                txt.Text += ($"{con.State}\n");
                txt.Text += ($"{ con.DataSource}\n");
                //txt.Text += ($"{ con.ServerVersion}\n");
                txt.Text += ($"{ con.ConnectionString}\n");
            }
            else
            {
                txt.Text += "La connessione non è istanziata\r\n";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(con != null && con.State == ConnectionState.Open)
            {
                con.Close();
                con = null;
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(con != null && con.State == ConnectionState.Open)
            {
                Inserimento ins = new Inserimento(con);
                ins.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                ViewList list = new ViewList(con);
                list.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }

        private void showTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                Tabella table = new Tabella(con);
                table.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }

        private void showGridTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                Dtable dtable = new Dtable(con);
                dtable.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }

        private void inserisciModificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                Inserisci_modifica modify = new Inserisci_modifica(con);
                modify.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }

        private void cancellaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificaConSelezioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                Inserisci_modifica modifica = new Inserisci_modifica(con);
                modifica.Show();
            }
            else
            {
                txt.Text += "La connessione non è aperta";
            }
        }
    }
}
