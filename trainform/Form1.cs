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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-1E1MS5M;Initial Catalog=train;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            if (radioButton1.Checked)
            {
                sqlcommand.CommandText = "INSERT INTO USERS VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',1)";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                sqlconnection.Open();
                sqlcommand.CommandText = "INSERT INTO ADMINS VALUES('"+textBox1.Text+"')";
            }
            else
            {
                sqlcommand.CommandText = "INSERT INTO USERS VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',0)";
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                sqlconnection.Open();
                sqlcommand.CommandText = "INSERT INTO CUSTOMERS VALUES('" + textBox1.Text + "')";
            }
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            ClearTextBoxes(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
