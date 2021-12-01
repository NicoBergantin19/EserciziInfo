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
    enum selezione {all, città, marca};
    public partial class ViewList : Form
    {
        SqlConnection con;
        selezione valore;
        public ViewList(SqlConnection connection)
        {
            InitializeComponent();
            con = connection;
        }

        private void visualizza(string querySql, selezione val)
        {
            SqlCommand com = new SqlCommand(querySql, con);
            SqlDataReader rd;
            rd = com.ExecuteReader();
            listBox1.Items.Clear();
            while(rd.Read())
            {
                //listBox1.Items.Add(rd[0].ToString() + " " + rd[1] + " " + rd[2]);
                //listBox1.Items.Add(rd["codice"].ToString() + " " + rd["marca"] + " " + rd["città"]);
                switch(val)
                {
                    case selezione.all:
                        listBox1.Items.Add(rd.GetInt32(0) + " " + rd.GetString(1) + " " + rd.GetString(2));
                        break;
                    case selezione.città:
                        listBox1.Items.Add(rd.GetInt32(0) + " " +rd.GetString(2));
                        break;
                    case selezione.marca:
                        listBox1.Items.Add(rd.GetInt32(0) + " " + rd.GetString(1));
                        break;
                }

                
            }
            rd.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewList_Load(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche", selezione.all);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche", selezione.all);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche", selezione.marca);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            visualizza("SELECT * FROM Marche", selezione.città);
        }
    }
}
