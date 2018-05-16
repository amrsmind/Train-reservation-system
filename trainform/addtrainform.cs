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
    public partial class addtrainform : Form
    {
        private string adminssn;
        public addtrainform(string tempssn)
        {
            InitializeComponent();
            adminssn = tempssn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trainnumtext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = "INSERT INTO trains VALUES('" + trainnumtext.Text + "','" + availseattext.Text + "','" + adminssn + "')";
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            int availseatnum = int.Parse(availseattext.Text); //convert string to int 
            string trainnum = trainnumtext.Text;
            sqlconnection.Open();
            for (int i = 0; i < availseatnum; i++)
            {
                sqlcommand.CommandText = "insert into seats values('"+i+1+"','"+trainnum+"')";
                sqlcommand.ExecuteNonQuery();
            }
            sqlconnection.Close();
        }

        private void addtrainform_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new adminaccess(adminssn).Show(); //doubt //i think there's no doubt now
            this.Close(); 
        }
    }
}
