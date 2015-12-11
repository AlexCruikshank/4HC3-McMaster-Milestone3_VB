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
        public Main()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp popUp = new SignUp();
            popUp.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn popIn = new SignIn();
            popIn.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main objForm = new Main();
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIDEORSearch objForm = new VIDEORSearch();
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e) 
        {
            this.Hide();
            VIDEORSearch objForm = new VIDEORSearch();
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
        }
    }
}
