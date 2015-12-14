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
            _username = tbUsername.Text;
        }
    }
}
