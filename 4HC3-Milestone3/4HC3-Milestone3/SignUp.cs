using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4HC3_Milestone3
{
    public partial class SignUp : Form
    {


        static string _username;

        public SignUp()
        {
            InitializeComponent();
            lblUsernameBlank.Visible = false;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                DialogResult = DialogResult.OK;
                _username = txtUsername.Text;
                lblUsernameBlank.Visible = false;
            }
            else
            {

                DialogResult = DialogResult.None;
                lblUsernameBlank.Visible = true;
            }
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }
    }
}
