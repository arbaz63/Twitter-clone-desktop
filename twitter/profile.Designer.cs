namespace twitter
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFollow = new System.Windows.Forms.Button();
            this.retweetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTweets = new System.Windows.Forms.Button();
            this.btnRetweets = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bio = new System.Windows.Forms.Label();
            this.following = new System.Windows.Forms.Label();
            this.followers = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 600);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnFollow
            // 
            this.btnFollow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFollow.FlatAppearance.BorderSize = 2;
            this.btnFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFollow.Location = new System.Drawing.Point(372, 43);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(72, 30);
            this.btnFollow.TabIndex = 5;
            this.btnFollow.Text = "Follow";
            this.btnFollow.UseVisualStyleBackColor = false;
            this.btnFollow.Click += new System.EventHandler(this.button1_Click);
            // 
            // retweetPanel
            // 
            this.retweetPanel.AutoScroll = true;
            this.retweetPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.retweetPanel.Location = new System.Drawing.Point(14, 175);
            this.retweetPanel.Name = "retweetPanel";
            this.retweetPanel.Size = new System.Drawing.Size(552, 600);
            this.retweetPanel.TabIndex = 5;
            this.retweetPanel.Visible = false;
            this.retweetPanel.WrapContents = false;
            // 
            // btnTweets
            // 
            this.btnTweets.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTweets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweets.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTweets.Location = new System.Drawing.Point(154, 133);
            this.btnTweets.Name = "btnTweets";
            this.btnTweets.Size = new System.Drawing.Size(138, 27);
            this.btnTweets.TabIndex = 6;
            this.btnTweets.Text = "Tweets";
            this.btnTweets.UseVisualStyleBackColor = false;
            this.btnTweets.Click += new System.EventHandler(this.btnTweets_Click);
            // 
            // btnRetweets
            // 
            this.btnRetweets.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetweets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetweets.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRetweets.Location = new System.Drawing.Point(298, 133);
            this.btnRetweets.Name = "btnRetweets";
            this.btnRetweets.Size = new System.Drawing.Size(138, 27);
            this.btnRetweets.TabIndex = 7;
            this.btnRetweets.Text = "Retweets";
            this.btnRetweets.UseVisualStyleBackColor = false;
            this.btnRetweets.Click += new System.EventHandler(this.btnRetweets_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(118, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Joined";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblJoinDate.Location = new System.Drawing.Point(154, 69);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(35, 13);
            this.lblJoinDate.TabIndex = 28;
            this.lblJoinDate.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(396, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Followers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(268, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Followings";
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bio.Location = new System.Drawing.Point(118, 30);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(35, 13);
            this.bio.TabIndex = 26;
            this.bio.Text = "label4";
            // 
            // following
            // 
            this.following.AutoSize = true;
            this.following.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.following.Location = new System.Drawing.Point(242, 18);
            this.following.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.following.Name = "following";
            this.following.Size = new System.Drawing.Size(41, 13);
            this.following.TabIndex = 23;
            this.following.Text = "label3";
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followers.Location = new System.Drawing.Point(369, 18);
            this.followers.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(41, 13);
            this.followers.TabIndex = 22;
            this.followers.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(115, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 21;
            this.name.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFollow);
            this.panel1.Controls.Add(this.lblJoinDate);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.followers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.following);
            this.panel1.Controls.Add(this.bio);
            this.panel1.Location = new System.Drawing.Point(11, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 100);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(155, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(546, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 788);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetweets);
            this.Controls.Add(this.btnTweets);
            this.Controls.Add(this.retweetPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.FlowLayoutPanel retweetPanel;
        private System.Windows.Forms.Button btnTweets;
        private System.Windows.Forms.Button btnRetweets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bio;
        private System.Windows.Forms.Label following;
        private System.Windows.Forms.Label followers;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}