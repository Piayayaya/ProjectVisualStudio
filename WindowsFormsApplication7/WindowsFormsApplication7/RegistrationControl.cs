using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var emailInput = this.emailBtn.Text;
            var usernameInput = this.usernameBtn.Text;
            var passwordInput = this.passBtn.Text;

            var parent = this.Parent as Form1;
            parent.registrationEmailInputs =  emailInput;
            parent.registrationUserInput = usernameInput;
            parent.registrationPasswordInput = passwordInput;
        }
    }
}
