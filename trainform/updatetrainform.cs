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
    public partial class updatetrainform : Form
    {
        private string adminssn;
        public updatetrainform(string tempssn)
        {
            InitializeComponent();
            adminssn = tempssn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            if(trainnumbercheck.Checked && availseatscheck.Checked)
            {
                sqlcommand.CommandText = "select COUNT(*) from trips where train_num ='"+trainnumtext.Text+"'";
                int trainintrip = (int)sqlcommand.ExecuteScalar();
                if (trainintrip > 0)
                {
                    MessageBox.Show("you can't change anything in this train because it's used in trip/s");
                    return;
                }
                sqlcommand.CommandText = "UPDATE TRAINS SET train_num='"+newtrainnumbertext.Text+"',avail_seat='"+newavailseats.Text+"' where train_num = '"+trainnumtext.Text+"'";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("done");

            }
            else if (trainnumbercheck.Checked)
            {
                sqlcommand.CommandText = "select COUNT(*) from trips where train_num ='" + trainnumtext.Text + "'";
                int trainintrip = (int)sqlcommand.ExecuteScalar();
                if (trainintrip > 0)
                {
                    MessageBox.Show("you can't change anything in this train because it's used in trip/s");
                    return;
                }
                sqlcommand.CommandText = "UPDATE TRAINS SET train_num='" + newtrainnumbertext.Text + "' where train_num = '" + trainnumtext.Text + "'";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("done");


            }
            else if (availseatscheck.Checked)
            {
                sqlcommand.CommandText = "select COUNT(*) from trips where train_num ='" + trainnumtext.Text + "'";

                int trainintrip = (int)sqlcommand.ExecuteScalar();  
                if (trainintrip > 0)
                {
                    MessageBox.Show("you can't change anything in this train because it's used in trip/s");
                    return;
                }
                sqlcommand.CommandText = "UPDATE TRAINS SET avail_seat='" + newavailseats.Text + "' where train_num = '" + trainnumtext.Text + "'";

                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("you didn't choose any change");
                sqlconnection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trainnumtext_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            string query = "SELECT * FROM trains WHERE train_num='" + trainnumtext.Text.Trim() + "' and controlledby='"+adminssn.Trim()+"' ";
            sqlconnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 1)
            {
                MessageBox.Show("there's no train number such like that");
            }
            else
            {
                MessageBox.Show("the train is ready to update");
            }
            sqlconnection.Close();
        }

        private void trainnumbercheeck_CheckedChanged(object sender, EventArgs e)
        {
            newtrainnumbertext.Enabled = (trainnumbercheck.CheckState == CheckState.Checked);
        }

        private void availseatscheck_CheckedChanged(object sender, EventArgs e)
        {
            newavailseats.Enabled = (availseatscheck.CheckState == CheckState.Checked);
        }

        private void newtrainnumbertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new adminaccess(adminssn).Show();
            this.Hide();
        }
    }
}
