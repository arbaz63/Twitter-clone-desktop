namespace twitter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.postsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddPost = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPost = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.searchResultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.trendingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.retweetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHome = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.Label();
            this.txtRetweets = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAnalytics = new System.Windows.Forms.Label();
            this.iconAnalytics = new System.Windows.Forms.PictureBox();
            this.iconRetweets = new System.Windows.Forms.PictureBox();
            this.iconProfile = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.analytics1 = new twitter.controls.analytics();
            this.headerPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAddPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAnalytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRetweets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // postsPanel
            // 
            this.postsPanel.AutoScroll = true;
            this.postsPanel.BackColor = System.Drawing.Color.White;
            this.postsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.postsPanel.Location = new System.Drawing.Point(254, 175);
            this.postsPanel.Name = "postsPanel";
            this.postsPanel.Size = new System.Drawing.Size(580, 500);
            this.postsPanel.TabIndex = 0;
            this.postsPanel.WrapContents = false;
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.panel3);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.panelAddPost);
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerPanel.Location = new System.Drawing.Point(254, 11);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(580, 152);
            this.headerPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(572, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(-33, -105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 18);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Home";
            // 
            // panelAddPost
            // 
            this.panelAddPost.Controls.Add(this.pictureBox5);
            this.panelAddPost.Controls.Add(this.panel1);
            this.panelAddPost.Controls.Add(this.txtPost);
            this.panelAddPost.Controls.Add(this.pictureBox1);
            this.panelAddPost.Controls.Add(this.btnPost);
            this.panelAddPost.Location = new System.Drawing.Point(20, 41);
            this.panelAddPost.Name = "panelAddPost";
            this.panelAddPost.Size = new System.Drawing.Size(535, 106);
            this.panelAddPost.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::twitter.Properties.Resources.picture;
            this.pictureBox5.Location = new System.Drawing.Point(68, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(66, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-33, -105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 18);
            this.panel2.TabIndex = 8;
            // 
            // txtPost
            // 
            this.txtPost.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPost.BorderColor = System.Drawing.Color.White;
            this.txtPost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPost.Location = new System.Drawing.Point(64, 5);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(453, 56);
            this.txtPost.TabIndex = 6;
            this.txtPost.Text = "What\'s happening?";
            this.txtPost.TextChanged += new System.EventHandler(this.txtPost_TextChanged);
            this.txtPost.Enter += new System.EventHandler(this.txtPost_Enter);
            this.txtPost.Leave += new System.EventHandler(this.txtPost_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPost.Enabled = false;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPost.Location = new System.Drawing.Point(442, 68);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 33);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Tweet";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // searchResultsPanel
            // 
            this.searchResultsPanel.AutoSize = true;
            this.searchResultsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.searchResultsPanel.Location = new System.Drawing.Point(270, 47);
            this.searchResultsPanel.Name = "searchResultsPanel";
            this.searchResultsPanel.Size = new System.Drawing.Size(553, 94);
            this.searchResultsPanel.TabIndex = 2;
            this.searchResultsPanel.Visible = false;
            this.searchResultsPanel.WrapContents = false;
            // 
            // trendingPanel
            // 
            this.trendingPanel.AutoScroll = true;
            this.trendingPanel.AutoSize = true;
            this.trendingPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trendingPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.trendingPanel.Location = new System.Drawing.Point(859, 96);
            this.trendingPanel.Margin = new System.Windows.Forms.Padding(1);
            this.trendingPanel.Name = "trendingPanel";
            this.trendingPanel.Size = new System.Drawing.Size(284, 100);
            this.trendingPanel.TabIndex = 2;
            this.trendingPanel.WrapContents = false;
            // 
            // panelProfile
            // 
            this.panelProfile.AutoScroll = true;
            this.panelProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelProfile.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelProfile.Location = new System.Drawing.Point(256, 12);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(576, 770);
            this.panelProfile.TabIndex = 6;
            this.panelProfile.Visible = false;
            this.panelProfile.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // retweetPanel
            // 
            this.retweetPanel.AutoScroll = true;
            this.retweetPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.retweetPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.retweetPanel.Location = new System.Drawing.Point(256, 14);
            this.retweetPanel.Name = "retweetPanel";
            this.retweetPanel.Size = new System.Drawing.Size(577, 770);
            this.retweetPanel.TabIndex = 8;
            this.retweetPanel.Visible = false;
            this.retweetPanel.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Location = new System.Drawing.Point(254, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 13);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(859, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 39);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 1);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trends for you";
            // 
            // txtHome
            // 
            this.txtHome.AutoSize = true;
            this.txtHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHome.Location = new System.Drawing.Point(72, 113);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(72, 25);
            this.txtHome.TabIndex = 6;
            this.txtHome.Text = "Home";
            this.txtHome.Click += new System.EventHandler(this.txtHome_Click);
            // 
            // txtProfile
            // 
            this.txtProfile.AutoSize = true;
            this.txtProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfile.Location = new System.Drawing.Point(72, 163);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(80, 25);
            this.txtProfile.TabIndex = 6;
            this.txtProfile.Text = "Profile";
            this.txtProfile.Click += new System.EventHandler(this.txtProfile_Click);
            // 
            // txtRetweets
            // 
            this.txtRetweets.AutoSize = true;
            this.txtRetweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetweets.Location = new System.Drawing.Point(72, 209);
            this.txtRetweets.Name = "txtRetweets";
            this.txtRetweets.Size = new System.Drawing.Size(109, 25);
            this.txtRetweets.TabIndex = 6;
            this.txtRetweets.Text = "Retweets";
            this.txtRetweets.Click += new System.EventHandler(this.txtRetweets_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Logout";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAnalytics
            // 
            this.lblAnalytics.AutoSize = true;
            this.lblAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalytics.Location = new System.Drawing.Point(72, 256);
            this.lblAnalytics.Name = "lblAnalytics";
            this.lblAnalytics.Size = new System.Drawing.Size(108, 25);
            this.lblAnalytics.TabIndex = 6;
            this.lblAnalytics.Text = "Analytics";
            this.lblAnalytics.Click += new System.EventHandler(this.lblAnalytics_Click);
            // 
            // iconAnalytics
            // 
            this.iconAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.iconAnalytics.Image = global::twitter.Properties.Resources.analytics_black;
            this.iconAnalytics.Location = new System.Drawing.Point(12, 242);
            this.iconAnalytics.Name = "iconAnalytics";
            this.iconAnalytics.Size = new System.Drawing.Size(84, 49);
            this.iconAnalytics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAnalytics.TabIndex = 14;
            this.iconAnalytics.TabStop = false;
            // 
            // iconRetweets
            // 
            this.iconRetweets.BackColor = System.Drawing.Color.Transparent;
            this.iconRetweets.Image = ((System.Drawing.Image)(resources.GetObject("iconRetweets.Image")));
            this.iconRetweets.Location = new System.Drawing.Point(14, 205);
            this.iconRetweets.Name = "iconRetweets";
            this.iconRetweets.Size = new System.Drawing.Size(77, 34);
            this.iconRetweets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRetweets.TabIndex = 14;
            this.iconRetweets.TabStop = false;
            // 
            // iconProfile
            // 
            this.iconProfile.BackColor = System.Drawing.Color.Transparent;
            this.iconProfile.Image = ((System.Drawing.Image)(resources.GetObject("iconProfile.Image")));
            this.iconProfile.Location = new System.Drawing.Point(11, 145);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Size = new System.Drawing.Size(85, 49);
            this.iconProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconProfile.TabIndex = 14;
            this.iconProfile.TabStop = false;
            // 
            // iconHome
            // 
            this.iconHome.Image = ((System.Drawing.Image)(resources.GetObject("iconHome.Image")));
            this.iconHome.Location = new System.Drawing.Point(19, 109);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(70, 32);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconHome.TabIndex = 14;
            this.iconHome.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(859, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox2.Icon = ((System.Drawing.Image)(resources.GetObject("textBox2.Icon")));
            this.textBox2.Lines = new string[0];
            this.textBox2.Location = new System.Drawing.Point(896, 11);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.PromptText = "Search Twitter";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.Size = new System.Drawing.Size(247, 35);
            this.textBox2.TabIndex = 11;
            this.textBox2.UseSelectable = true;
            this.textBox2.WaterMark = "Search Twitter";
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // analytics1
            // 
            this.analytics1.AutoScroll = true;
            this.analytics1.Location = new System.Drawing.Point(254, 15);
            this.analytics1.Name = "analytics1";
            this.analytics1.Size = new System.Drawing.Size(599, 734);
            this.analytics1.TabIndex = 17;
            this.analytics1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1198, 749);
            this.Controls.Add(this.analytics1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAnalytics);
            this.Controls.Add(this.txtRetweets);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.iconAnalytics);
            this.Controls.Add(this.iconRetweets);
            this.Controls.Add(this.iconProfile);
            this.Controls.Add(this.iconHome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchResultsPanel);
            this.Controls.Add(this.retweetPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.trendingPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.postsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelAddPost.ResumeLayout(false);
            this.panelAddPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAnalytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRetweets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel postsPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.FlowLayoutPanel searchResultsPanel;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Panel panelAddPost;
        private System.Windows.Forms.FlowLayoutPanel trendingPanel;
        private System.Windows.Forms.FlowLayoutPanel panelProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel retweetPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtHome;
        private System.Windows.Forms.Label txtProfile;
        private System.Windows.Forms.PictureBox iconHome;
        private System.Windows.Forms.PictureBox iconProfile;
        private System.Windows.Forms.Label txtRetweets;
        private System.Windows.Forms.PictureBox iconRetweets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private controls.analytics analytics1;
        private System.Windows.Forms.PictureBox iconAnalytics;
        private System.Windows.Forms.Label lblAnalytics;
    }
}

