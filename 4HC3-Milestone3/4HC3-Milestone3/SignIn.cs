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
    //public class Variables
    //{
        
    //}

    public partial class SignIn : Form
    {

        static string _username;

        private Label label1;
        private CheckBox checkBox1;
        private Button btnSignIn;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;

        public SignIn()
        {
            InitializeComponent();
            lblUsernameBlank.Visible = false;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsernameBlank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 76);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign In";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.checkBox1.Location = new System.Drawing.Point(105, 239);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Terms of Service";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSignIn.Location = new System.Drawing.Point(136, 306);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(174, 59);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(170, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "1q2w3e4r";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.Location = new System.Drawing.Point(170, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 30);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "cruiksam";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "username:";
            // 
            // lblUsernameBlank
            // 
            this.lblUsernameBlank.AutoSize = true;
            this.lblUsernameBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUsernameBlank.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameBlank.Location = new System.Drawing.Point(94, 106);
            this.lblUsernameBlank.Name = "lblUsernameBlank";
            this.lblUsernameBlank.Size = new System.Drawing.Size(315, 31);
            this.lblUsernameBlank.TabIndex = 15;
            this.lblUsernameBlank.Text = "Please enter a username";
            // 
            // SignIn
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.lblUsernameBlank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void btnSignIn_Click(object sender, EventArgs e)
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

        private Label lblUsernameBlank;

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
