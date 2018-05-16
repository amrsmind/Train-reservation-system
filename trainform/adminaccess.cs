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
    public partial class adminaccess : Form
    {
        private string adminssn;
        public adminaccess(string tempssn)
        {
            InitializeComponent();
            adminssn = tempssn;
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            string query = "select * from trips";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
            DataTable dtbl = new DataTable();
            String currentdate = DateTime.Now.ToString("yyy.MM.dd");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            foreach (DataRow row in dtbl.Rows)
            {
                string tripdateend = row["enddate"].ToString();
                if (DateTime.Parse(tripdateend) > DateTime.Parse(currentdate))
                {
                    sqlcommand.CommandText = "delete from trips where trip_num='"+row["trip_num"]+"'";
                    sqlcommand.ExecuteNonQuery();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new addtrainform(adminssn).Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new Loginform().Show();
            this.Hide();
        }

        private void updatetrain_Click(object sender, EventArgs e)
        {
            new updatetrainform(adminssn).Show();
            this.Hide();
        }

        private void addtrip_Click(object sender, EventArgs e)
        {
            new addtripform(adminssn).Show();
            this.Hide();

        }

        private void updatetrip_Click(object sender, EventArgs e)
        {
            new updatetripform(adminssn).Show();
            this.Hide();
        }

        private void adminaccess_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainDataSet1.trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.trainDataSet1.trains);
            // TODO: This line of code loads data into the 'trainDataSet1.trips' table. You can move, or remove it, as needed.
            this.tripsTableAdapter.Fill(this.trainDataSet1.trips);

        }

        private void showtablebutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            sqlconnection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT trip_num, StartDate, EndDate, StartTime, EndTime, trips.Controlledby, route_num, trains.train_num,trains.avail_seat FROM dbo.trips,dbo.trains where trips.train_num = trains.train_num",sqlconnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            tripstrainsdata.DataSource = dtbl;


        }
    }
}
