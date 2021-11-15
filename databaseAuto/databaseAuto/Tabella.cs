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
    public partial class Tabella : Form
    {
        SqlConnection connection;
        public Tabella(SqlConnection con)
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
            rd = com.ExecuteReader();
            while (rd.Read())
            {
                //listBox1.Items.Add(rd[0].ToString() + " " + rd[1] + " " + rd[2]);
                //listBox1.Items.Add(rd["codice"].ToString() + " " + rd["marca"] + " " + rd["città"]);
                dataGridView1.Rows.Add(rd.GetInt32(0), rd.GetString(1), rd.GetString(2));
            }
            rd.Close();
        }

        private void Tabella_Load(object sender, EventArgs e)
        {
            visualizza("select * from Marche");
            
            label2.Text = contarighe("select count(codice) from Marche").ToString();
        }
    }
}
