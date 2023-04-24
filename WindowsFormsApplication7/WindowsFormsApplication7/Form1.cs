using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string registrationEmailInputs
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string registrationUserInput
        {
            set
            {
                textBox2.Text = value;
            }
        }

        public string registrationPasswordInput
        {
            set
            {
                textBox3.Text = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userDetailPanel.Hide();

            homeControl1.Show();
            homeControl1.BringToFront();

            registrationControl1.Hide();
            loginControl11.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            userDetailPanel.Hide();

            homeControl1.Show();
            homeControl1.BringToFront();

            registrationControl1.Hide();
            loginControl11.Hide();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            userDetailPanel.Show();

            registrationControl1.Show();
            registrationControl1.BringToFront();

            homeControl1.Hide();
            loginControl11.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            userDetailPanel.Hide();

            loginControl11.Show();
            loginControl11.BringToFront();

            homeControl1.Hide();
            registrationControl1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
