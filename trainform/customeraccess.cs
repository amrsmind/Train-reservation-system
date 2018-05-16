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
    public partial class customeraccess : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        string customerssn;
        
        public customeraccess(string tempssn)
        {
            InitializeComponent();
            customerssn = tempssn;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new beforecustomeraccess(customerssn).Show();
            this.Hide();
        }

        private void customeraccess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainDataSet1.seats' table. You can move, or remove it, as needed.
            this.seatsTableAdapter.Fill(this.trainDataSet1.seats);
            // TODO: This line of code loads data into the 'trainDataSet1.trips' table. You can move, or remove it, as needed.
            this.tripsTableAdapter.Fill(this.trainDataSet1.trips);
            // TODO: This line of code loads data into the 'trainDataSet1.trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.trainDataSet1.trains);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departuredatecheck_CheckedChanged(object sender, EventArgs e)
        {
            departuredate.Enabled = (departuredatecheck.CheckState == CheckState.Checked);

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

        private void sourcecheck_CheckedChanged(object sender, EventArgs e)
        {
            sourcetext.Enabled = (sourcecheck.CheckState == CheckState.Checked);

        }

        private void destinationcheck_CheckedChanged(object sender, EventArgs e)
        {
            destinationtext.Enabled = (destinationcheck.CheckState == CheckState.Checked);
        }

        private bool certainbool(bool ischecked,string value1,string value2)
        {
            return value1.Equals(value2) || !ischecked; 
        }

        private void showtrips_Click(object sender, EventArgs e)
        {
            string departuredatecheckstring = Convert.ToString(departuredatecheck.Checked);
            string arrivaldatecheckstring = Convert.ToString(arrivaldatecheck.Checked);
            string arrivaltimecheckstring = Convert.ToString(arrivaltimecheck.Checked);
            string departuretimecheckstring = Convert.ToString(departuretimecheck.Checked);
            string sourcecheckstring = Convert.ToString(sourcecheck.Checked);
            string destinationcheckstring = Convert.ToString(destinationcheck.Checked);

            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            sqlconnection.Open();
            sda = new SqlDataAdapter("select distinct trips.StartDate,trips.EndDate,trips.StartTime,trips.EndTime,fromto.startpoint,fromto.endpoint,trips.availseats,trips.trip_num,trains.train_num" +
    " from trips, fromto, trains" +
    " where trips.route_num = fromto.route_num and trips.train_num = trains.train_num " +
    "and (trips.startdate = '" + departuredate.Text + "' or 'False' = '"+departuredatecheckstring+"')"+ 
    "and (trips.enddate = '" + arrivaldate.Text + "' or 'False' = '"+arrivaldatecheckstring+"' )" +
    "and (trips.starttime = '" + departuretime.Text + "' or 'False' = '"+departuretimecheckstring+"' )"+
    "and (trips.endtime = '" + arrivaltime.Text + "' or 'False' = '"+arrivaltimecheckstring+"' )" +
    "and (fromto.startpoint = '" + sourcetext.Text + "' or 'False' = '"+sourcecheckstring+"' )" +
    "and (fromto.endpoint = '" + destinationtext.Text + "' or 'False' = '"+destinationcheckstring+"' )" 
    , sqlconnection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seatsnumuserwants = Int32.Parse(seatsnumbertext.Text);
            int rowscount = dataGridView1.Rows.Count;
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            //for (int i = 0; i < rowscount; i++)
            //{
            //    bool ischecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
            //    if (ischecked)
            //    {
            //        int availseat = (int)dataGridView1.Rows[i].Cells[6].Value;
            //        if (seatsnumuserwants > 0 && seatsnumuserwants <= availseat)
            //        {
            //            int restofseat = availseat - seatsnumuserwants;
            //            string tripnum = (string)dataGridView1.Rows[i].Cells[7].Value;
            //            sqlcommand.CommandText = "update trips set availseats = '" + restofseat + "' where trip_num = '" + tripnum + "' ";
            //            sqlcommand.ExecuteNonQuery();
            //            sqlcommand.CommandText = "insert into bookedtrips values('" + customerssn + "','" + tripnum + "')";
            //            sqlcommand.ExecuteNonQuery();
            //        }
            //        else
            //        {
            //            MessageBox.Show("unfortunately, there's no available space");
            //        }
            //    }
            //    sqlconnection.Close();
            //}
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["checktrips"].Value))
                {
                    int availseat = (int)row.Cells["availseats"].Value;
                    if (seatsnumuserwants > 0 && seatsnumuserwants <= availseat)
                    {
                        int restofseat = availseat - seatsnumuserwants;
                        string tripnum = row.Cells["trip_num"].Value.ToString();
                        sqlcommand.CommandText = "update trips set availseats = '" + restofseat + "' where trip_num = '" + tripnum + "' ";
                        sqlcommand.ExecuteNonQuery();
                        sqlcommand.CommandText = "insert into bookedtrips values('" + customerssn + "','" + tripnum + "','"+seatsnumuserwants+"')";
                        sqlcommand.ExecuteNonQuery();
                        MessageBox.Show("trip has been booked");
                    }
                    else
                    {
                        MessageBox.Show("unfortunately, there's no available space");
                    }
                }
            }
            sqlconnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seatsnumbertext_TextChanged(object sender, EventArgs e)
        {
            bookbutton.Enabled = !string.IsNullOrWhiteSpace(seatsnumbertext.Text);
        }
    }
}
