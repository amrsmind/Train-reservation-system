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
    public partial class updatetripform : Form
    {
        private string adminssn;
        public updatetripform(string tempadmin)
        {
            InitializeComponent();
            adminssn = tempadmin;
        }

        private void updatetripform_Load(object sender, EventArgs e)
        {
        }

        private void departurecheck_CheckedChanged(object sender, EventArgs e)
        {
            departuredate.Enabled = (departuredatecheck.CheckState == CheckState.Checked);
        }

        private void departuredate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void arrivaldatecheck_CheckedChanged(object sender, EventArgs e)
        {
            arrivaldate.Enabled = (arrivaldatecheck.CheckState == CheckState.Checked);

        }

        private void departuretimecheck_CheckedChanged(object sender, EventArgs e)
        {
            departuretime.Enabled = (departuretimecheck.CheckState == CheckState.Checked);
        }

        private void arrivaltimecheck_CheckedChanged(object sender, EventArgs e)
        {
            arrivaltime.Enabled = (arrivaltimecheck.CheckState == CheckState.Checked);

        }

        private void trainnumcheck_CheckedChanged(object sender, EventArgs e)
        {
            trainnumtext.Enabled = (trainnumcheck.CheckState == CheckState.Checked);
        }

        private void routenumcheck_CheckedChanged(object sender, EventArgs e)
        {
            routenumtext.Enabled = (routenumcheck.CheckState == CheckState.Checked);
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = "select * from trips where trip_num='" + tripnumtext.Text + "' and Controlledby='"+adminssn+"'";
            sqlcommand.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcommand);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl); 
            if (dtbl.Rows.Count == 1)
            {
                //MessageBox.Show("your are ready to update the trip");
                DataRow r = dtbl.Rows[0];
                string startdate = r["startdate"].ToString();
                string enddate = r["enddate"].ToString();
                string starttime = r["starttime"].ToString();
                string endtime = r["endtime"].ToString();
                string train_num = r["train_num"].ToString();
                string route_num = r["route_num"].ToString();

                if (departuredatecheck.Checked)
                {
                    startdate = departuredate.Text;
                }
                if (arrivaldatecheck.Checked)
                {
                    enddate = arrivaldate.Text;
                }
                if (departuretimecheck.Checked)
                {
                    starttime = departuretime.Text;
                }
                if (arrivaltimecheck.Checked)
                {
                    endtime = arrivaltime.Text;
                }
                if (trainnumcheck.Checked)
                {
                    train_num = trainnumtext.Text;
                }
                if (routenumcheck.Checked)
                {
                    route_num = routenumtext.Text;
                }
                sqlcommand.CommandText = "update trips SET StartDate='" +startdate+ "',EndDate='" + enddate + "',StartTime='" + starttime + "',EndTime='" + endtime + "',train_num='" + train_num + "',route_num='" + route_num + "' where trip_num = '" + tripnumtext.Text + "'";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("updated!");
            }
            else
            {
                MessageBox.Show("there's no a trip such like that to update");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new adminaccess(adminssn).Show();
            this.Hide();
        }
    }
}
