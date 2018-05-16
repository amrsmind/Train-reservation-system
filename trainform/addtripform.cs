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
    public partial class addtripform : Form
    {
        private string adminssn;
        public addtripform(string tempssn)
        {
            InitializeComponent();
            adminssn = tempssn;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            string querytogettrainnum = "select * from trains where trains.train_num = '" + trainnumtext.Text + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(querytogettrainnum, sqlconnection);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            if(dtbl1.Rows.Count != 1)
            {
                MessageBox.Show("wrong train number");
                return;
            }
            //sqlcommand.CommandText = "Insert into trips values('"+tripnumtext.Text+ "','"+departuredate.Text+ "','"+arrivaldate.Text+ "','"+departuretime.Text+ "','"+arrivaltime.Text+ "','"+adminssn+ "','"+trainnumtext.Text+ "','"+routenumtext.Text+"')";
            string query = "select * from fromto where startpoint='" + Fromtext.Text.Trim() + "' and endpoint='" + totext.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            DataRow r1 = dtbl1.Rows[0];
            if (dtbl.Rows.Count == 1)
            {
                DataRow r = dtbl.Rows[0];
                if (newroutecheck.Checked)
                {
                    MessageBox.Show("it's not new route it's already existed at route number " + r["route_num"] + " but trip has been added"); 
                }
                else
                {
                    MessageBox.Show("Trip has been added");
                }
                sqlcommand.CommandText = "Insert into trips values('"+tripnumtext.Text+ "','"+departuredate.Text+ "','"+arrivaldate.Text+ "','"+departuretime.Text+ "','"+arrivaltime.Text+ "','"+adminssn+ "','"+trainnumtext.Text+ "','"+ r["route_num"].ToString()+ "','"+r1["avail_seat"] +"')";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
            }
            else
            {
                sqlcommand.CommandText = "INSERT into fromto values('"+routenumtext.Text+"','"+Fromtext.Text+ "','"+totext.Text+"')";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                sqlconnection.Open();
                sqlcommand.CommandText = "Insert into trips values('" + tripnumtext.Text + "','" + departuredate.Text + "','" + arrivaldate.Text + "','" + departuretime.Text + "','" + arrivaltime.Text + "','" + adminssn + "','" + trainnumtext.Text + "','" +routenumtext.Text+ "','" + r1["avail_seat"] + "')";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Trip has been added");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void newroutecheck_CheckedChanged(object sender, EventArgs e)
        {
            routenumtext.Enabled = (newroutecheck.CheckState == CheckState.Checked);

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            new adminaccess(adminssn).Show();
            this.Hide();
        }

        private void routenumtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void addtripform_Load(object sender, EventArgs e)
        {

        }
    }
}
