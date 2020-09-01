namespace twitter.controls
{
    partial class post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(post));
            this.friend_name = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.retweetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPost = new System.Windows.Forms.Panel();
            this.iconDelPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconDel = new System.Windows.Forms.PictureBox();
            this.iconPic = new System.Windows.Forms.PictureBox();
            this.iconUpdate = new System.Windows.Forms.PictureBox();
            this.iconSave = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.description = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.commentIcon = new System.Windows.Forms.PictureBox();
            this.commentsCount = new System.Windows.Forms.Label();
            this.dateAndTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSave)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // friend_name
            // 
            this.friend_name.AutoSize = true;
            this.friend_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friend_name.ForeColor = System.Drawing.Color.Blue;
            this.friend_name.Location = new System.Drawing.Point(50, 11);
            this.friend_name.Name = "friend_name";
            this.friend_name.Size = new System.Drawing.Size(73, 13);
            this.friend_name.TabIndex = 0;
            this.friend_name.Text = "friend name";
            this.friend_name.Click += new System.EventHandler(this.friend_name_Click);
            this.friend_name.MouseLeave += new System.EventHandler(this.friend_name_MouseLeave);
            this.friend_name.MouseHover += new System.EventHandler(this.friend_name_MouseHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(427, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(29, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(279, 10);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(53, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 76);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // retweetPanel
            // 
            this.retweetPanel.Location = new System.Drawing.Point(203, 17);
            this.retweetPanel.Name = "retweetPanel";
            this.retweetPanel.Size = new System.Drawing.Size(103, 29);
            this.retweetPanel.TabIndex = 7;
            // 
            // panelPost
            // 
            this.panelPost.AutoScroll = true;
            this.panelPost.AutoSize = true;
            this.panelPost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPost.Controls.Add(this.panel1);
            this.panelPost.Controls.Add(this.iconDelPic);
            this.panelPost.Controls.Add(this.panel2);
            this.panelPost.Controls.Add(this.iconDel);
            this.panelPost.Controls.Add(this.iconPic);
            this.panelPost.Controls.Add(this.iconUpdate);
            this.panelPost.Controls.Add(this.iconSave);
            this.panelPost.Controls.Add(this.flowLayoutPanel3);
            this.panelPost.Controls.Add(this.dateAndTime);
            this.panelPost.Controls.Add(this.pictureBox1);
            this.panelPost.Controls.Add(this.friend_name);
            this.panelPost.Location = new System.Drawing.Point(3, 3);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(547, 206);
            this.panelPost.TabIndex = 10;
            // 
            // iconDelPic
            // 
            this.iconDelPic.Image = global::twitter.Properties.Resources.delete_red;
            this.iconDelPic.Location = new System.Drawing.Point(417, 6);
            this.iconDelPic.Name = "iconDelPic";
            this.iconDelPic.Size = new System.Drawing.Size(37, 30);
            this.iconDelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconDelPic.TabIndex = 20;
            this.iconDelPic.TabStop = false;
            this.iconDelPic.Visible = false;
            this.iconDelPic.Click += new System.EventHandler(this.btnDelPic_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(52, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 1);
            this.panel2.TabIndex = 12;
            // 
            // iconDel
            // 
            this.iconDel.Image = global::twitter.Properties.Resources.delete_blue;
            this.iconDel.Location = new System.Drawing.Point(502, 6);
            this.iconDel.Name = "iconDel";
            this.iconDel.Size = new System.Drawing.Size(37, 30);
            this.iconDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconDel.TabIndex = 18;
            this.iconDel.TabStop = false;
            this.iconDel.Visible = false;
            this.iconDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // iconPic
            // 
            this.iconPic.Image = global::twitter.Properties.Resources.picture;
            this.iconPic.Location = new System.Drawing.Point(374, 6);
            this.iconPic.Name = "iconPic";
            this.iconPic.Size = new System.Drawing.Size(37, 30);
            this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPic.TabIndex = 21;
            this.iconPic.TabStop = false;
            this.iconPic.Visible = false;
            this.iconPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // iconUpdate
            // 
            this.iconUpdate.Image = global::twitter.Properties.Resources.pencil;
            this.iconUpdate.Location = new System.Drawing.Point(435, -6);
            this.iconUpdate.Name = "iconUpdate";
            this.iconUpdate.Size = new System.Drawing.Size(83, 56);
            this.iconUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUpdate.TabIndex = 19;
            this.iconUpdate.TabStop = false;
            this.iconUpdate.Visible = false;
            this.iconUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // iconSave
            // 
            this.iconSave.Image = global::twitter.Properties.Resources.save;
            this.iconSave.Location = new System.Drawing.Point(333, 6);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(37, 30);
            this.iconSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSave.TabIndex = 17;
            this.iconSave.TabStop = false;
            this.iconSave.Visible = false;
            this.iconSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel3.Controls.Add(this.description);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel3.Controls.Add(this.panelBtns);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 69);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(530, 129);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Enabled = false;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(3, 3);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(521, 22);
            this.description.TabIndex = 13;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(215, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panelBtns
            // 
            this.panelBtns.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBtns.AutoSize = true;
            this.panelBtns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBtns.Controls.Add(this.retweetPanel);
            this.panelBtns.Controls.Add(this.flowLayoutPanel2);
            this.panelBtns.Controls.Add(this.flowLayoutPanel1);
            this.panelBtns.Controls.Add(this.commentIcon);
            this.panelBtns.Controls.Add(this.commentsCount);
            this.panelBtns.Location = new System.Drawing.Point(3, 47);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(524, 78);
            this.panelBtns.TabIndex = 11;
            // 
            // commentIcon
            // 
            this.commentIcon.Image = ((System.Drawing.Image)(resources.GetObject("commentIcon.Image")));
            this.commentIcon.Location = new System.Drawing.Point(1, 23);
            this.commentIcon.Name = "commentIcon";
            this.commentIcon.Size = new System.Drawing.Size(43, 23);
            this.commentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commentIcon.TabIndex = 11;
            this.commentIcon.TabStop = false;
            this.commentIcon.Click += new System.EventHandler(this.commentIcon_Click);
            // 
            // commentsCount
            // 
            this.commentsCount.AutoSize = true;
            this.commentsCount.Location = new System.Drawing.Point(43, 28);
            this.commentsCount.Name = "commentsCount";
            this.commentsCount.Size = new System.Drawing.Size(13, 13);
            this.commentsCount.TabIndex = 10;
            this.commentsCount.Text = "0";
            // 
            // dateAndTime
            // 
            this.dateAndTime.AutoSize = true;
            this.dateAndTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dateAndTime.Location = new System.Drawing.Point(51, 24);
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.Size = new System.Drawing.Size(35, 13);
            this.dateAndTime.TabIndex = 11;
            this.dateAndTime.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::twitter.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelPost);
            this.Name = "post";
            this.Size = new System.Drawing.Size(556, 212);
            this.Load += new System.EventHandler(this.post_Load);
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSave)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.panelBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label friend_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel retweetPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Label commentsCount;
        private System.Windows.Forms.Label dateAndTime;
        private System.Windows.Forms.PictureBox commentIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox iconDel;
        private System.Windows.Forms.PictureBox iconPic;
        private System.Windows.Forms.PictureBox iconDelPic;
        private System.Windows.Forms.PictureBox iconUpdate;
        private System.Windows.Forms.PictureBox iconSave;
    }
}
