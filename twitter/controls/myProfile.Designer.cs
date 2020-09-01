namespace twitter.controls
{
    partial class myProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tweetsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bio = new System.Windows.Forms.Label();
            this.following = new System.Windows.Forms.Label();
            this.followers = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.retweetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTweet = new System.Windows.Forms.Button();
            this.btnRetweet = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnEditBio = new System.Windows.Forms.Button();
            this.btnSaveBio = new System.Windows.Forms.Button();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bioTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tweetsPanel
            // 
            this.tweetsPanel.AutoScroll = true;
            this.tweetsPanel.AutoSize = true;
            this.tweetsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tweetsPanel.Location = new System.Drawing.Point(2, 209);
            this.tweetsPanel.Name = "tweetsPanel";
            this.tweetsPanel.Size = new System.Drawing.Size(548, 23);
            this.tweetsPanel.TabIndex = 10;
            this.tweetsPanel.WrapContents = false;
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bio.Location = new System.Drawing.Point(140, 53);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(35, 13);
            this.bio.TabIndex = 9;
            this.bio.Text = "label4";
            // 
            // following
            // 
            this.following.AutoSize = true;
            this.following.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.following.Location = new System.Drawing.Point(221, 21);
            this.following.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.following.Name = "following";
            this.following.Size = new System.Drawing.Size(41, 13);
            this.following.TabIndex = 8;
            this.following.Text = "label3";
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followers.Location = new System.Drawing.Point(348, 21);
            this.followers.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(41, 13);
            this.followers.TabIndex = 7;
            this.followers.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(137, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 6;
            this.name.Text = "label1";
            // 
            // retweetPanel
            // 
            this.retweetPanel.AutoScroll = true;
            this.retweetPanel.AutoSize = true;
            this.retweetPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.retweetPanel.Location = new System.Drawing.Point(2, 211);
            this.retweetPanel.Name = "retweetPanel";
            this.retweetPanel.Size = new System.Drawing.Size(548, 23);
            this.retweetPanel.TabIndex = 11;
            this.retweetPanel.Visible = false;
            this.retweetPanel.WrapContents = false;
            // 
            // btnTweet
            // 
            this.btnTweet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTweet.Location = new System.Drawing.Point(131, 160);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(140, 31);
            this.btnTweet.TabIndex = 12;
            this.btnTweet.Text = "Tweets";
            this.btnTweet.UseVisualStyleBackColor = false;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // btnRetweet
            // 
            this.btnRetweet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetweet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRetweet.Location = new System.Drawing.Point(277, 160);
            this.btnRetweet.Name = "btnRetweet";
            this.btnRetweet.Size = new System.Drawing.Size(134, 31);
            this.btnRetweet.TabIndex = 13;
            this.btnRetweet.Text = "Retweets";
            this.btnRetweet.UseVisualStyleBackColor = false;
            this.btnRetweet.Click += new System.EventHandler(this.btnRetweet_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(12, 126);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpload.Location = new System.Drawing.Point(75, 126);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(61, 23);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnEditBio
            // 
            this.btnEditBio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditBio.Location = new System.Drawing.Point(190, 126);
            this.btnEditBio.Name = "btnEditBio";
            this.btnEditBio.Size = new System.Drawing.Size(62, 23);
            this.btnEditBio.TabIndex = 17;
            this.btnEditBio.Text = "Edit Bio";
            this.btnEditBio.UseVisualStyleBackColor = false;
            this.btnEditBio.Click += new System.EventHandler(this.btnEditBio_Click);
            // 
            // btnSaveBio
            // 
            this.btnSaveBio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBio.Location = new System.Drawing.Point(258, 126);
            this.btnSaveBio.Name = "btnSaveBio";
            this.btnSaveBio.Size = new System.Drawing.Size(56, 23);
            this.btnSaveBio.TabIndex = 18;
            this.btnSaveBio.Text = "Save";
            this.btnSaveBio.UseVisualStyleBackColor = false;
            this.btnSaveBio.Visible = false;
            this.btnSaveBio.Click += new System.EventHandler(this.btnSaveBio_Click);
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJoinDate.Location = new System.Drawing.Point(176, 100);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(35, 13);
            this.lblJoinDate.TabIndex = 20;
            this.lblJoinDate.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::twitter.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Followings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(375, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Followers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(140, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Joined";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(131, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bioTxt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.followers);
            this.panel1.Controls.Add(this.lblJoinDate);
            this.panel1.Controls.Add(this.following);
            this.panel1.Controls.Add(this.bio);
            this.panel1.Controls.Add(this.btnSaveBio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEditBio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 154);
            this.panel1.TabIndex = 32;
            // 
            // bioTxt
            // 
            this.bioTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bioTxt.Enabled = false;
            this.bioTxt.Location = new System.Drawing.Point(143, 48);
            this.bioTxt.Multiline = true;
            this.bioTxt.Name = "bioTxt";
            this.bioTxt.ReadOnly = true;
            this.bioTxt.Size = new System.Drawing.Size(205, 49);
            this.bioTxt.TabIndex = 21;
            // 
            // myProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRetweet);
            this.Controls.Add(this.btnTweet);
            this.Controls.Add(this.retweetPanel);
            this.Controls.Add(this.tweetsPanel);
            this.Name = "myProfile";
            this.Size = new System.Drawing.Size(553, 485);
            this.Load += new System.EventHandler(this.myProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tweetsPanel;
        private System.Windows.Forms.Label bio;
        private System.Windows.Forms.Label following;
        private System.Windows.Forms.Label followers;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.FlowLayoutPanel retweetPanel;
        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.Button btnRetweet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnEditBio;
        private System.Windows.Forms.Button btnSaveBio;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bioTxt;
    }
}
