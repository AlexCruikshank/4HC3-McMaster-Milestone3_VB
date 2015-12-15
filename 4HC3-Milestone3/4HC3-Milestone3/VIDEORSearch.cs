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
    public partial class VIDEORSearch : Form
    {

        static string _username = "";
        static string _filter = "";

        public VIDEORSearch()
        {
            InitializeComponent();
            cbFilters.Text = _filter;
            
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIDEORSearch));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnVid1 = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVid2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVid3 = new System.Windows.Forms.Button();
            this.btnVid4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVid5 = new System.Windows.Forms.Button();
            this.btnVid6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPageCount1 = new System.Windows.Forms.Label();
            this.lblPageCount2 = new System.Windows.Forms.Label();
            this.lblUnknownPage = new System.Windows.Forms.Label();
            this.lblLastPage = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSearch.Location = new System.Drawing.Point(537, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(708, 38);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Look for videos here...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1252, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSignUp.Location = new System.Drawing.Point(963, 12);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(187, 60);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSignIn.Location = new System.Drawing.Point(572, 12);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(187, 60);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnVid1
            // 
            this.btnVid1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid1.Location = new System.Drawing.Point(161, 247);
            this.btnVid1.Name = "btnVid1";
            this.btnVid1.Size = new System.Drawing.Size(131, 90);
            this.btnVid1.TabIndex = 12;
            this.btnVid1.Text = "VID1";
            this.btnVid1.UseVisualStyleBackColor = true;
            this.btnVid1.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Tahoma", 70F, System.Drawing.FontStyle.Bold);
            this.btnMain.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMain.Location = new System.Drawing.Point(59, 34);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(463, 150);
            this.btnMain.TabIndex = 13;
            this.btnMain.Text = "VIDEOR";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(781, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResults.Location = new System.Drawing.Point(599, 143);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(187, 50);
            this.lblResults.TabIndex = 15;
            this.lblResults.Text = "45695";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResults.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(1003, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filter By:";
            // 
            // cbFilters
            // 
            this.cbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "Most Relevant",
            "Most Popular",
            "Alphabetical",
            "Category",
            "Tags"});
            this.cbFilters.Location = new System.Drawing.Point(1126, 150);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(248, 39);
            this.cbFilters.TabIndex = 16;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(315, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Title#1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(318, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Time#1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(318, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 78);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tags#1";
            // 
            // btnVid2
            // 
            this.btnVid2.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid2.Location = new System.Drawing.Point(537, 247);
            this.btnVid2.Name = "btnVid2";
            this.btnVid2.Size = new System.Drawing.Size(131, 90);
            this.btnVid2.TabIndex = 12;
            this.btnVid2.Text = "VID2";
            this.btnVid2.UseVisualStyleBackColor = true;
            this.btnVid2.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(691, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Title#2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(694, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Time#2";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(694, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 78);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tags#2";
            // 
            // btnVid3
            // 
            this.btnVid3.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid3.Location = new System.Drawing.Point(161, 381);
            this.btnVid3.Name = "btnVid3";
            this.btnVid3.Size = new System.Drawing.Size(131, 90);
            this.btnVid3.TabIndex = 12;
            this.btnVid3.Text = "VID3";
            this.btnVid3.UseVisualStyleBackColor = true;
            this.btnVid3.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnVid4
            // 
            this.btnVid4.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid4.Location = new System.Drawing.Point(537, 381);
            this.btnVid4.Name = "btnVid4";
            this.btnVid4.Size = new System.Drawing.Size(131, 90);
            this.btnVid4.TabIndex = 12;
            this.btnVid4.Text = "VID4";
            this.btnVid4.UseVisualStyleBackColor = true;
            this.btnVid4.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(315, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "Title#3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(691, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 31);
            this.label11.TabIndex = 15;
            this.label11.Text = "Title#4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(318, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Time#3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(694, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Time#4";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(318, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 78);
            this.label14.TabIndex = 15;
            this.label14.Text = "Tags#3";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(694, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 78);
            this.label15.TabIndex = 15;
            this.label15.Text = "Tags#4";
            // 
            // btnVid5
            // 
            this.btnVid5.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid5.Location = new System.Drawing.Point(161, 511);
            this.btnVid5.Name = "btnVid5";
            this.btnVid5.Size = new System.Drawing.Size(131, 90);
            this.btnVid5.TabIndex = 12;
            this.btnVid5.Text = "VID5";
            this.btnVid5.UseVisualStyleBackColor = true;
            this.btnVid5.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnVid6
            // 
            this.btnVid6.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnVid6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnVid6.Location = new System.Drawing.Point(537, 511);
            this.btnVid6.Name = "btnVid6";
            this.btnVid6.Size = new System.Drawing.Size(131, 90);
            this.btnVid6.TabIndex = 12;
            this.btnVid6.Text = "VID6";
            this.btnVid6.UseVisualStyleBackColor = true;
            this.btnVid6.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label16.Location = new System.Drawing.Point(315, 521);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 31);
            this.label16.TabIndex = 15;
            this.label16.Text = "Title#5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label17.Location = new System.Drawing.Point(691, 521);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 31);
            this.label17.TabIndex = 15;
            this.label17.Text = "Title#6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(318, 552);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Time#5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(694, 552);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "Time#6";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(318, 569);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(171, 78);
            this.label20.TabIndex = 15;
            this.label20.Text = "Tags#5";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(694, 569);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(171, 78);
            this.label21.TabIndex = 15;
            this.label21.Text = "Tags#6";
            // 
            // lblPageCount1
            // 
            this.lblPageCount1.AutoSize = true;
            this.lblPageCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPageCount1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPageCount1.Location = new System.Drawing.Point(674, 647);
            this.lblPageCount1.Name = "lblPageCount1";
            this.lblPageCount1.Size = new System.Drawing.Size(29, 31);
            this.lblPageCount1.TabIndex = 15;
            this.lblPageCount1.Text = "1";
            this.lblPageCount1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPageCount2
            // 
            this.lblPageCount2.AutoSize = true;
            this.lblPageCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPageCount2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPageCount2.Location = new System.Drawing.Point(705, 647);
            this.lblPageCount2.Name = "lblPageCount2";
            this.lblPageCount2.Size = new System.Drawing.Size(29, 31);
            this.lblPageCount2.TabIndex = 15;
            this.lblPageCount2.Text = "2";
            this.lblPageCount2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUnknownPage
            // 
            this.lblUnknownPage.AutoSize = true;
            this.lblUnknownPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblUnknownPage.Location = new System.Drawing.Point(734, 647);
            this.lblUnknownPage.Name = "lblUnknownPage";
            this.lblUnknownPage.Size = new System.Drawing.Size(38, 31);
            this.lblUnknownPage.TabIndex = 15;
            this.lblUnknownPage.Text = "...";
            // 
            // lblLastPage
            // 
            this.lblLastPage.AutoSize = true;
            this.lblLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLastPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLastPage.Location = new System.Drawing.Point(763, 647);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(44, 31);
            this.lblLastPage.TabIndex = 15;
            this.lblLastPage.Text = "10";
            this.lblLastPage.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblUsername.Location = new System.Drawing.Point(564, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(243, 46);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "lblUsername";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSignOut.Location = new System.Drawing.Point(951, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(222, 60);
            this.btnSignOut.TabIndex = 18;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(691, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = ",";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label22.Location = new System.Drawing.Point(727, 647);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 34);
            this.label22.TabIndex = 15;
            this.label22.Text = ",";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VIDEORSearch
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 719);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUnknownPage);
            this.Controls.Add(this.lblLastPage);
            this.Controls.Add(this.lblPageCount2);
            this.Controls.Add(this.lblPageCount1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnVid6);
            this.Controls.Add(this.btnVid4);
            this.Controls.Add(this.btnVid2);
            this.Controls.Add(this.btnVid5);
            this.Controls.Add(this.btnVid3);
            this.Controls.Add(this.btnVid1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSignOut);
            this.Name = "VIDEORSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSignUp;
        private Button btnSignIn;
        private Button btnVid1;
        private Button btnMain;
        private Label label1;
        private Label lblResults;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Label label3;
        private ComboBox cbFilters;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnVid2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnVid3;
        private Button btnVid4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btnVid5;
        private Button btnVid6;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label lblPageCount1;
        private Label lblPageCount2;
        private Label lblUnknownPage;
        private Label lblLastPage;

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

        public string Filters
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
                cbFilters.Text = _filter;
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

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIDEORVideo objForm = new VIDEORVideo();
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

        private Label lblUsername;
        private Button btnSignOut;

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _username = "";
            lblUsername.Text = "";
            btnSignOut.Visible = false;
            lblUsername.Visible = false;
            btnSignIn.Visible = true;
            btnSignUp.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn popIn = new SignIn();
            if (popIn.ShowDialog() == DialogResult.OK)
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

        private Label label2;
        private Label label22;

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if(cbFilters.Text != _filter)
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
                objForm.Filters = cbFilters.Text;
                objForm.Closed += (s, args) => this.Close();
                objForm.Show();
                }
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
