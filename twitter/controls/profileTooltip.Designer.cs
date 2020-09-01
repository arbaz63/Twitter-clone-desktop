namespace twitter.controls
{
    partial class profileTooltip
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
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.followers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.following = new System.Windows.Forms.Label();
            this.bio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(64, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(143, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Followers";
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followers.Location = new System.Drawing.Point(116, 88);
            this.followers.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(41, 13);
            this.followers.TabIndex = 28;
            this.followers.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(28, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Followings";
            // 
            // following
            // 
            this.following.AutoSize = true;
            this.following.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.following.Location = new System.Drawing.Point(0, 88);
            this.following.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.following.Name = "following";
            this.following.Size = new System.Drawing.Size(41, 13);
            this.following.TabIndex = 29;
            this.following.Text = "label3";
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bio.Location = new System.Drawing.Point(1, 50);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(35, 13);
            this.bio.TabIndex = 32;
            this.bio.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // profileTooltip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.followers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.following);
            this.Controls.Add(this.bio);
            this.Controls.Add(this.name);
            this.Name = "profileTooltip";
            this.Size = new System.Drawing.Size(208, 112);
            this.Load += new System.EventHandler(this.profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label followers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label following;
        private System.Windows.Forms.Label bio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
