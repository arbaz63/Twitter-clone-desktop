using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using twitter.controls;

namespace twitter
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }
        public string uid;
        //getting posts of user having id
        private void populatePost()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select p.pid,u.name,p.description,p.uid,CONVERT(VARCHAR(10), date, 111),CONVERT(VARCHAR(5), date, 108) + (CASE WHEN DATEPART(HOUR, date) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join users u on p.uid=u.uid where p.uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            post pp = new post();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                pp = new post();
                pp.id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                pp.friend = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                pp.description1 = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                pp.uid = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                pp.date = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                pp.time = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                flowLayoutPanel1.Controls.Add(pp);

            }

        }
        private void populateRetweet()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select p.pid,p.description,u1.name,u1.uid,CONVERT(VARCHAR(10), date, 111),CONVERT(VARCHAR(5), date, 108) + (CASE WHEN DATEPART(HOUR, date) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join retweets r on r.pid=p.pid join users u1 on r.uid1=u1.uid join users u2 on u2.uid=r.uid2 where u2.uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid); //whose post
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            post pp = new post();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                pp = new post();
                pp.id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                pp.description1 = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                pp.friend = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                pp.uid = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                pp.date = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                pp.time = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                retweetPanel.Controls.Add(pp);

            }

        }
        //getting user details of user
        private void populateUser()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select name,bio,CONVERT(VARCHAR(10), joinDate, 111) from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            name.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bio.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            lblJoinDate.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if(uid==Properties.Settings.Default.profileUid)//user id
            {
                btnFollow.Visible = false;
            }
            else
            {
                btnFollow.Visible = true;
            }
        }
        //getting followers
        private void populateFollowers()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from followers f join users u on f.uid1=u.uid where u.uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            followers.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        //getting following
        private void populateFollowing()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from followers f join users u on f.uid2=u.uid where u.uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            following.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        private void profile_Load(object sender, EventArgs e)
        {
            populateUser();
            populateFollowers();
            populateFollowing();
            populatePost();
            populateRetweet();
            populateProfilePic();
            btnFollow.Text = checkFollowed() ? "Following" : "Follow";
        }
        //here starts the follow part

        //checking if current user has already liked or not
        private bool checkFollowed()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from followers where uid1=@a and uid2=@b", con);
            cmd.Parameters.AddWithValue("@a", uid);
            cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnFollow.Text = "Following";
                return true;
            }
            else
            {
                btnFollow.Text = "Follow";
                return false;
            }
        }
        //follow a post
        private void followPost()
        {
            if (!checkFollowed())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into followers values(@a,@b)", con);
                cmd.Parameters.AddWithValue("@a", uid);
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update users set followers+=1 where uid=@a", con);
                cmd.Parameters.AddWithValue("@a", uid);
                cmd.ExecuteNonQuery();
                btnFollow.Text = "Following";
                populateFollowers();
                //MessageBox.Show("Liked successfully");
            }
            else if (checkFollowed())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from followers where uid1=@a and uid2=@b", con);
                cmd.Parameters.AddWithValue("@a", uid);
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update users set followers-=1 where uid=@a", con);
                cmd.Parameters.AddWithValue("@a", uid);
                cmd.ExecuteNonQuery();
                btnFollow.Text = "Follow";
                populateFollowers();
                //MessageBox.Show("Unliked successfully");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            followPost();
        }

        private void btnRetweets_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            retweetPanel.Visible = true ;
        }

        private void btnTweets_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            retweetPanel.Visible = false;
        }
        //getting profile pic
        private void populateProfilePic()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select avatar from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                byte[] image = ((byte[])dr[0]);
                if (image == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
