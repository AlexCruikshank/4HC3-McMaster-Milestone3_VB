﻿using System;
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
    public partial class VIDEORVideo : Form
    {
        public VIDEORVideo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblOtherTime4 = new System.Windows.Forms.Label();
            this.lblOtherTime2 = new System.Windows.Forms.Label();
            this.lblOtherTime3 = new System.Windows.Forms.Label();
            this.lblOtherTime1 = new System.Windows.Forms.Label();
            this.lblOtherTitle4 = new System.Windows.Forms.Label();
            this.lblOtherTitle2 = new System.Windows.Forms.Label();
            this.lblOtherTitle3 = new System.Windows.Forms.Label();
            this.lblOtherTitle1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOtherVids4 = new System.Windows.Forms.Button();
            this.btnOtherVids2 = new System.Windows.Forms.Button();
            this.btnOtherVids3 = new System.Windows.Forms.Button();
            this.btnOtherVids1 = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPopularVids1 = new System.Windows.Forms.Button();
            this.lblPopularTime4 = new System.Windows.Forms.Label();
            this.btnPopularVids3 = new System.Windows.Forms.Button();
            this.lblPopularTime2 = new System.Windows.Forms.Label();
            this.btnPopularVids2 = new System.Windows.Forms.Button();
            this.lblPopularTime3 = new System.Windows.Forms.Label();
            this.btnPopularVids4 = new System.Windows.Forms.Button();
            this.lblPopularTime1 = new System.Windows.Forms.Label();
            this.lblPopularTitle1 = new System.Windows.Forms.Label();
            this.lblPopularTitle4 = new System.Windows.Forms.Label();
            this.lblPopularTitle3 = new System.Windows.Forms.Label();
            this.lblPopularTitle2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblMainVideoDesc = new System.Windows.Forms.Label();
            this.lblMainVideoTags = new System.Windows.Forms.Label();
            this.lblMainVideoTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOtherTime4
            // 
            this.lblOtherTime4.AutoSize = true;
            this.lblOtherTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOtherTime4.Location = new System.Drawing.Point(458, 206);
            this.lblOtherTime4.Name = "lblOtherTime4";
            this.lblOtherTime4.Size = new System.Drawing.Size(55, 17);
            this.lblOtherTime4.TabIndex = 45;
            this.lblOtherTime4.Text = "Time#4";
            // 
            // lblOtherTime2
            // 
            this.lblOtherTime2.AutoSize = true;
            this.lblOtherTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOtherTime2.Location = new System.Drawing.Point(458, 104);
            this.lblOtherTime2.Name = "lblOtherTime2";
            this.lblOtherTime2.Size = new System.Drawing.Size(55, 17);
            this.lblOtherTime2.TabIndex = 46;
            this.lblOtherTime2.Text = "Time#2";
            // 
            // lblOtherTime3
            // 
            this.lblOtherTime3.AutoSize = true;
            this.lblOtherTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOtherTime3.Location = new System.Drawing.Point(144, 206);
            this.lblOtherTime3.Name = "lblOtherTime3";
            this.lblOtherTime3.Size = new System.Drawing.Size(55, 17);
            this.lblOtherTime3.TabIndex = 48;
            this.lblOtherTime3.Text = "Time#3";
            // 
            // lblOtherTime1
            // 
            this.lblOtherTime1.AutoSize = true;
            this.lblOtherTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOtherTime1.Location = new System.Drawing.Point(144, 104);
            this.lblOtherTime1.Name = "lblOtherTime1";
            this.lblOtherTime1.Size = new System.Drawing.Size(55, 17);
            this.lblOtherTime1.TabIndex = 49;
            this.lblOtherTime1.Text = "Time#1";
            // 
            // lblOtherTitle4
            // 
            this.lblOtherTitle4.AutoSize = true;
            this.lblOtherTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOtherTitle4.Location = new System.Drawing.Point(455, 175);
            this.lblOtherTitle4.Name = "lblOtherTitle4";
            this.lblOtherTitle4.Size = new System.Drawing.Size(96, 31);
            this.lblOtherTitle4.TabIndex = 33;
            this.lblOtherTitle4.Text = "Title#4";
            // 
            // lblOtherTitle2
            // 
            this.lblOtherTitle2.AutoSize = true;
            this.lblOtherTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOtherTitle2.Location = new System.Drawing.Point(455, 73);
            this.lblOtherTitle2.Name = "lblOtherTitle2";
            this.lblOtherTitle2.Size = new System.Drawing.Size(96, 31);
            this.lblOtherTitle2.TabIndex = 32;
            this.lblOtherTitle2.Text = "Title#2";
            // 
            // lblOtherTitle3
            // 
            this.lblOtherTitle3.AutoSize = true;
            this.lblOtherTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOtherTitle3.Location = new System.Drawing.Point(141, 175);
            this.lblOtherTitle3.Name = "lblOtherTitle3";
            this.lblOtherTitle3.Size = new System.Drawing.Size(96, 31);
            this.lblOtherTitle3.TabIndex = 30;
            this.lblOtherTitle3.Text = "Title#3";
            // 
            // lblOtherTitle1
            // 
            this.lblOtherTitle1.AutoSize = true;
            this.lblOtherTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOtherTitle1.Location = new System.Drawing.Point(141, 73);
            this.lblOtherTitle1.Name = "lblOtherTitle1";
            this.lblOtherTitle1.Size = new System.Drawing.Size(96, 31);
            this.lblOtherTitle1.TabIndex = 29;
            this.lblOtherTitle1.Text = "Title#1";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSearch.Location = new System.Drawing.Point(551, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(708, 38);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "Look for videos here...";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Location = new System.Drawing.Point(1267, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 57);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "?";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(977, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 60);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(586, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 60);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btnOtherVids4
            // 
            this.btnOtherVids4.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnOtherVids4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOtherVids4.Location = new System.Drawing.Point(362, 170);
            this.btnOtherVids4.Name = "btnOtherVids4";
            this.btnOtherVids4.Size = new System.Drawing.Size(89, 58);
            this.btnOtherVids4.TabIndex = 24;
            this.btnOtherVids4.Text = "04";
            this.btnOtherVids4.UseVisualStyleBackColor = true;
            this.btnOtherVids4.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnOtherVids2
            // 
            this.btnOtherVids2.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnOtherVids2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOtherVids2.Location = new System.Drawing.Point(362, 68);
            this.btnOtherVids2.Name = "btnOtherVids2";
            this.btnOtherVids2.Size = new System.Drawing.Size(89, 58);
            this.btnOtherVids2.TabIndex = 23;
            this.btnOtherVids2.Text = "02";
            this.btnOtherVids2.UseVisualStyleBackColor = true;
            this.btnOtherVids2.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnOtherVids3
            // 
            this.btnOtherVids3.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnOtherVids3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOtherVids3.Location = new System.Drawing.Point(48, 170);
            this.btnOtherVids3.Name = "btnOtherVids3";
            this.btnOtherVids3.Size = new System.Drawing.Size(89, 58);
            this.btnOtherVids3.TabIndex = 21;
            this.btnOtherVids3.Text = "03";
            this.btnOtherVids3.UseVisualStyleBackColor = true;
            this.btnOtherVids3.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnOtherVids1
            // 
            this.btnOtherVids1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnOtherVids1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOtherVids1.Location = new System.Drawing.Point(48, 68);
            this.btnOtherVids1.Name = "btnOtherVids1";
            this.btnOtherVids1.Size = new System.Drawing.Size(89, 58);
            this.btnOtherVids1.TabIndex = 20;
            this.btnOtherVids1.Text = "01";
            this.btnOtherVids1.UseVisualStyleBackColor = true;
            this.btnOtherVids1.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Tahoma", 70F, System.Drawing.FontStyle.Bold);
            this.btnMain.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnMain.Location = new System.Drawing.Point(73, 43);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(463, 150);
            this.btnMain.TabIndex = 26;
            this.btnMain.Text = "VIDEOR";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOtherVids1);
            this.groupBox1.Controls.Add(this.lblOtherTime4);
            this.groupBox1.Controls.Add(this.btnOtherVids3);
            this.groupBox1.Controls.Add(this.lblOtherTime2);
            this.groupBox1.Controls.Add(this.btnOtherVids2);
            this.groupBox1.Controls.Add(this.lblOtherTime3);
            this.groupBox1.Controls.Add(this.btnOtherVids4);
            this.groupBox1.Controls.Add(this.lblOtherTime1);
            this.groupBox1.Controls.Add(this.lblOtherTitle1);
            this.groupBox1.Controls.Add(this.lblOtherTitle4);
            this.groupBox1.Controls.Add(this.lblOtherTitle3);
            this.groupBox1.Controls.Add(this.lblOtherTitle2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.Location = new System.Drawing.Point(12, 661);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 265);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OTHER VIDEOS IN THIS CATEGORY";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPopularVids1);
            this.groupBox2.Controls.Add(this.lblPopularTime4);
            this.groupBox2.Controls.Add(this.btnPopularVids3);
            this.groupBox2.Controls.Add(this.lblPopularTime2);
            this.groupBox2.Controls.Add(this.btnPopularVids2);
            this.groupBox2.Controls.Add(this.lblPopularTime3);
            this.groupBox2.Controls.Add(this.btnPopularVids4);
            this.groupBox2.Controls.Add(this.lblPopularTime1);
            this.groupBox2.Controls.Add(this.lblPopularTitle1);
            this.groupBox2.Controls.Add(this.lblPopularTitle4);
            this.groupBox2.Controls.Add(this.lblPopularTitle3);
            this.groupBox2.Controls.Add(this.lblPopularTitle2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox2.Location = new System.Drawing.Point(707, 661);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 265);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OTHER POPULAR VIDEOS";
            // 
            // btnPopularVids1
            // 
            this.btnPopularVids1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnPopularVids1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPopularVids1.Location = new System.Drawing.Point(48, 68);
            this.btnPopularVids1.Name = "btnPopularVids1";
            this.btnPopularVids1.Size = new System.Drawing.Size(89, 58);
            this.btnPopularVids1.TabIndex = 20;
            this.btnPopularVids1.Text = "01";
            this.btnPopularVids1.UseVisualStyleBackColor = true;
            this.btnPopularVids1.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblPopularTime4
            // 
            this.lblPopularTime4.AutoSize = true;
            this.lblPopularTime4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPopularTime4.Location = new System.Drawing.Point(464, 206);
            this.lblPopularTime4.Name = "lblPopularTime4";
            this.lblPopularTime4.Size = new System.Drawing.Size(55, 17);
            this.lblPopularTime4.TabIndex = 45;
            this.lblPopularTime4.Text = "Time#4";
            // 
            // btnPopularVids3
            // 
            this.btnPopularVids3.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnPopularVids3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPopularVids3.Location = new System.Drawing.Point(48, 170);
            this.btnPopularVids3.Name = "btnPopularVids3";
            this.btnPopularVids3.Size = new System.Drawing.Size(89, 58);
            this.btnPopularVids3.TabIndex = 21;
            this.btnPopularVids3.Text = "03";
            this.btnPopularVids3.UseVisualStyleBackColor = true;
            this.btnPopularVids3.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblPopularTime2
            // 
            this.lblPopularTime2.AutoSize = true;
            this.lblPopularTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPopularTime2.Location = new System.Drawing.Point(464, 104);
            this.lblPopularTime2.Name = "lblPopularTime2";
            this.lblPopularTime2.Size = new System.Drawing.Size(55, 17);
            this.lblPopularTime2.TabIndex = 46;
            this.lblPopularTime2.Text = "Time#2";
            // 
            // btnPopularVids2
            // 
            this.btnPopularVids2.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnPopularVids2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPopularVids2.Location = new System.Drawing.Point(368, 68);
            this.btnPopularVids2.Name = "btnPopularVids2";
            this.btnPopularVids2.Size = new System.Drawing.Size(89, 58);
            this.btnPopularVids2.TabIndex = 23;
            this.btnPopularVids2.Text = "02";
            this.btnPopularVids2.UseVisualStyleBackColor = true;
            this.btnPopularVids2.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblPopularTime3
            // 
            this.lblPopularTime3.AutoSize = true;
            this.lblPopularTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPopularTime3.Location = new System.Drawing.Point(144, 206);
            this.lblPopularTime3.Name = "lblPopularTime3";
            this.lblPopularTime3.Size = new System.Drawing.Size(55, 17);
            this.lblPopularTime3.TabIndex = 48;
            this.lblPopularTime3.Text = "Time#3";
            // 
            // btnPopularVids4
            // 
            this.btnPopularVids4.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.btnPopularVids4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPopularVids4.Location = new System.Drawing.Point(368, 170);
            this.btnPopularVids4.Name = "btnPopularVids4";
            this.btnPopularVids4.Size = new System.Drawing.Size(89, 58);
            this.btnPopularVids4.TabIndex = 24;
            this.btnPopularVids4.Text = "04";
            this.btnPopularVids4.UseVisualStyleBackColor = true;
            this.btnPopularVids4.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // lblPopularTime1
            // 
            this.lblPopularTime1.AutoSize = true;
            this.lblPopularTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPopularTime1.Location = new System.Drawing.Point(144, 104);
            this.lblPopularTime1.Name = "lblPopularTime1";
            this.lblPopularTime1.Size = new System.Drawing.Size(55, 17);
            this.lblPopularTime1.TabIndex = 49;
            this.lblPopularTime1.Text = "Time#1";
            // 
            // lblPopularTitle1
            // 
            this.lblPopularTitle1.AutoSize = true;
            this.lblPopularTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPopularTitle1.Location = new System.Drawing.Point(141, 73);
            this.lblPopularTitle1.Name = "lblPopularTitle1";
            this.lblPopularTitle1.Size = new System.Drawing.Size(96, 31);
            this.lblPopularTitle1.TabIndex = 29;
            this.lblPopularTitle1.Text = "Title#1";
            // 
            // lblPopularTitle4
            // 
            this.lblPopularTitle4.AutoSize = true;
            this.lblPopularTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPopularTitle4.Location = new System.Drawing.Point(461, 175);
            this.lblPopularTitle4.Name = "lblPopularTitle4";
            this.lblPopularTitle4.Size = new System.Drawing.Size(96, 31);
            this.lblPopularTitle4.TabIndex = 33;
            this.lblPopularTitle4.Text = "Title#4";
            // 
            // lblPopularTitle3
            // 
            this.lblPopularTitle3.AutoSize = true;
            this.lblPopularTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPopularTitle3.Location = new System.Drawing.Point(141, 175);
            this.lblPopularTitle3.Name = "lblPopularTitle3";
            this.lblPopularTitle3.Size = new System.Drawing.Size(96, 31);
            this.lblPopularTitle3.TabIndex = 30;
            this.lblPopularTitle3.Text = "Title#3";
            // 
            // lblPopularTitle2
            // 
            this.lblPopularTitle2.AutoSize = true;
            this.lblPopularTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPopularTitle2.Location = new System.Drawing.Point(461, 73);
            this.lblPopularTitle2.Name = "lblPopularTitle2";
            this.lblPopularTitle2.Size = new System.Drawing.Size(96, 31);
            this.lblPopularTitle2.TabIndex = 32;
            this.lblPopularTitle2.Text = "Title#2";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 70F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPlay.Location = new System.Drawing.Point(250, 261);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(890, 320);
            this.btnPlay.TabIndex = 26;
            this.btnPlay.Text = "Press Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblMainVideoDesc
            // 
            this.lblMainVideoDesc.AutoSize = true;
            this.lblMainVideoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMainVideoDesc.Location = new System.Drawing.Point(257, 584);
            this.lblMainVideoDesc.Name = "lblMainVideoDesc";
            this.lblMainVideoDesc.Size = new System.Drawing.Size(227, 31);
            this.lblMainVideoDesc.TabIndex = 32;
            this.lblMainVideoDesc.Text = "Video Description";
            // 
            // lblMainVideoTags
            // 
            this.lblMainVideoTags.AutoSize = true;
            this.lblMainVideoTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMainVideoTags.Location = new System.Drawing.Point(260, 615);
            this.lblMainVideoTags.Name = "lblMainVideoTags";
            this.lblMainVideoTags.Size = new System.Drawing.Size(35, 17);
            this.lblMainVideoTags.TabIndex = 46;
            this.lblMainVideoTags.Text = "tags";
            // 
            // lblMainVideoTitle
            // 
            this.lblMainVideoTitle.AutoSize = true;
            this.lblMainVideoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblMainVideoTitle.Location = new System.Drawing.Point(257, 218);
            this.lblMainVideoTitle.Name = "lblMainVideoTitle";
            this.lblMainVideoTitle.Size = new System.Drawing.Size(179, 39);
            this.lblMainVideoTitle.TabIndex = 32;
            this.lblMainVideoTitle.Text = "Video Title";
            // 
            // VIDEORVideo
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 938);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMainVideoTags);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblMainVideoTitle);
            this.Controls.Add(this.lblMainVideoDesc);
            this.Name = "VIDEORVideo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblOtherTime4;
        private Label lblOtherTime2;
        private Label lblOtherTime3;
        private Label lblOtherTime1;
        private Label lblOtherTitle4;
        private Label lblOtherTitle2;
        private Label lblOtherTitle3;
        private Label lblOtherTitle1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button button3;
        private Button button2;
        private Button btnOtherVids4;
        private Button btnOtherVids2;
        private Button btnOtherVids3;
        private Button btnOtherVids1;
        private Button btnMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnPopularVids1;
        private Label lblPopularTime4;
        private Button btnPopularVids3;
        private Label lblPopularTime2;
        private Button btnPopularVids2;
        private Label lblPopularTime3;
        private Button btnPopularVids4;
        private Label lblPopularTime1;
        private Label lblPopularTitle1;
        private Label lblPopularTitle4;
        private Label lblPopularTitle3;
        private Label lblPopularTitle2;
        private Button btnPlay;
        private Label lblMainVideoDesc;
        private Label lblMainVideoTags;
        private Label lblMainVideoTitle;

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIDEORVideo objForm = new VIDEORVideo();
            objForm.Closed += (s, args) => this.Close();
            objForm.Show();
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
    }
}