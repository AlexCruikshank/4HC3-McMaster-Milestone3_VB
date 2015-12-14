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
    public partial class Main : Form
    {
        static string _username = "";

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
        public bool SignedIn
        {

            set
            {
                if (value == true)
                {
                    lblUsername.Text = _username;
                    btnSignOut.Visible = true;
                    lblUsername.Visible = true;
                    btnSignIn.Visible = false;
                    btnSignUp.Visible = false;
                }
                else if (value == false)
                {
                    _username = "";
                    btnSignOut.Visible = false;
                    lblUsername.Visible = false;
                    btnSignIn.Visible = true;
                    btnSignUp.Visible = true;
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            if (lblUsername.Text != "" && lblUsername.Text != "lblUsername")
            {
                lblUsername.Text = _username;
                btnSignOut.Visible = true;
                lblUsername.Visible = true;
                btnSignIn.Visible = false;
                btnSignUp.Visible = false;
            }else
            {
                btnSignOut.Visible = false;
                lblUsername.Visible = false;
                btnSignIn.Visible = true;
                btnSignUp.Visible = true;

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp popUp = new SignUp();
            if (popUp.ShowDialog() == DialogResult.OK)
            {
                _username = popUp.Username;
                lblUsername.Text = _username;
                btnSignOut.Visible = true;
                lblUsername.Visible = true;
                btnSignIn.Visible = false;
                btnSignUp.Visible = false;
            }
            popUp.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn popIn = new SignIn();
            if (popIn.ShowDialog() == DialogResult.OK )
                {
                    _username = popIn.Username;
                    lblUsername.Text = _username;
                    btnSignOut.Visible = true;
                    lblUsername.Visible = true;
                    btnSignIn.Visible = false;
                    btnSignUp.Visible = false;
                }
            
            popIn.Close();
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _username = "";
            lblUsername.Text = "";
            btnSignOut.Visible = false;
            lblUsername.Visible = false;
            btnSignIn.Visible = true;
            btnSignUp.Visible = true;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main objForm = new Main();
            if (lblUsername.Text != "" && lblUsername.Text != "lblUsername")
            {
                objForm.Username = _username;
                objForm.SignedIn = true;
            }
            else
            {
                objForm.Username = "";
                objForm.SignedIn = false;
            }
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIDEORSearch objForm = new VIDEORSearch();
            if (lblUsername.Text != "" && lblUsername.Text != "lblUsername")
            {
                objForm.Username = _username;
                objForm.SignedIn = true;
            }
            else
            {
                objForm.Username = "";
                objForm.SignedIn = false;
            }
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e) 
        {
            this.Hide();
            VIDEORSearch objForm = new VIDEORSearch();
            if (lblUsername.Text != "" && lblUsername.Text != "lblUsername")
            {
                objForm.Username = _username;
                objForm.SignedIn = true;
            }else
            {
                objForm.Username = "";
                objForm.SignedIn = false;
            }
            
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }
    }
}
