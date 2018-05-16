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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //private adminaccess adm;
        //private customeraccess cus;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            string query = "select * from users where email='" + textBox1.Text.Trim() + "'and pass='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                DataRow r = dtbl.Rows[0];
                string AorC = r["accessibility"].ToString();
                //MessageBox.Show(AorC);
                if (AorC.Equals("True"))
                {
                    sqlconnection.Close();
                    //admin
                    new adminaccess(r["ssn"].ToString()).Show();
                    this.Hide();                    
                }
                else
                {
                    sqlconnection.Close();
                    //customer
                    new beforecustomeraccess(r["ssn"].ToString()).Show();
                    this.Hide();
                }
            }
            else
            {
                sqlconnection.Close();
                MessageBox.Show("your email or password is not correct please try again");
            }
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }


                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new welcomeform().Show();
            this.Hide();
        }
    }
}
