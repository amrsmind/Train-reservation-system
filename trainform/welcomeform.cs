using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainform
{
    public partial class welcomeform : Form
    {
        public welcomeform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Registerform().Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            new Loginform().Show();
            this.Hide();
        }
    }
}
