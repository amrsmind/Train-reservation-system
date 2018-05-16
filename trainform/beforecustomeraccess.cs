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
    public partial class beforecustomeraccess : Form
    {
        string customerssn;
        public beforecustomeraccess(string tempssn)
        {
            InitializeComponent();
            customerssn = tempssn;
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
                    sqlcommand.CommandText = "delete from trips where trip_num='" + row["trip_num"] + "'";
                    sqlcommand.ExecuteNonQuery();
                }

            }
        }

        private void beforecustomeraccess_Load(object sender, EventArgs e)
        {


        }

        private void booktripbutton_Click(object sender, EventArgs e)
        {
            new customeraccess(customerssn).Show();
            this.Hide();
        }

        private void canceltripbutton_Click(object sender, EventArgs e)
        {
            new canceltripform(customerssn).Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new Loginform().Show();
            this.Hide();
        }
    }
}
