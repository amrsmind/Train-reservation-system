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

namespace trainform
{
    public partial class canceltripform : Form
    {
        string customerssn;
        public canceltripform(string tempssn)
        {
            InitializeComponent();
            customerssn = tempssn;
        }

        private void canceltripform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            canceltripbutton.Enabled = !string.IsNullOrWhiteSpace(tripnumtext.Text);

        }

        private void canceltripbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            sqlconnection.Open();
            string query = "select * from bookedtrips where ssn='"+customerssn+"' and trip_num='"+tripnumtext.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            if (dtbl.Rows.Count>0)
            {
                sqlcommand.CommandText = "delete from bookedtrips where ssn='" + customerssn + "' and trip_num='" + tripnumtext.Text + "'";
                sqlcommand.ExecuteNonQuery();
                foreach (DataRow row in dtbl.Rows)
                {
                    sqlcommand.CommandText = "insert into canceledtrips values('"+customerssn+"','"+tripnumtext.Text+"','"+Int32.Parse(row["seats"].ToString())+"')";
                    sqlcommand.ExecuteNonQuery();
                }
                query = "select * from canceledtrips";
                DataTable dtbl1 = new DataTable();
                sda = new SqlDataAdapter(query, sqlconnection);
                sda.Fill(dtbl1);
                DataTable dtbl2 = new DataTable();
                query = "select availseats from trips where trip_num='"+tripnumtext.Text+"' ";
                sda = new SqlDataAdapter(query, sqlconnection);
                sda.Fill(dtbl2);
                DataRow r = dtbl2.Rows[0];
                int availseats = Int32.Parse(r["availseats"].ToString());
                int bookedseats = 0;
                int cumulativebookedseats = 0;
                foreach (DataRow row in dtbl1.Rows)
                {
                    bookedseats = Int32.Parse(row["seats"].ToString());
                    cumulativebookedseats += bookedseats;
                }
                int newavailseats = cumulativebookedseats + availseats;
                sqlcommand.CommandText = "UPDATE trips set availseats='"+newavailseats+"' where trip_num='"+tripnumtext.Text+"'";
                sqlcommand.ExecuteNonQuery();
                sqlcommand.CommandText = "delete from canceledtrips";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("your trip has been canceled");
            }
            else
            {
                MessageBox.Show("sorry you didn't booked this trip before");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new beforecustomeraccess(customerssn).Show();
            this.Hide();
        }
    }
}
