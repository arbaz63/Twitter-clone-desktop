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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //populate posts
        private void populate()
        {
            SqlConnection con=new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            postsPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select p.pid,u.name,p.description,u.uid, CONVERT(VARCHAR(10), date, 111),CONVERT(VARCHAR(5), date, 108) + (CASE WHEN DATEPART(HOUR, date) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join users u on p.uid=u.uid where p.uid in (select f.uid1 from users u join followers f on u.uid=f.uid2 where f.uid2=@a) or p.uid=@b order by date desc", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id ------> posts of followers of user
            cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id ------> posts of user
            /*
             select CONVERT(date, date) from posts
                SELECT  CONVERT(VARCHAR(5), date, 108) + 
                (CASE WHEN DATEPART(HOUR, date) > 12 THEN ' PM'
                    ELSE ' AM'
                END) 'Hour:Minutes' from posts
             */
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            post pp=new post();
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                 pp = new post();
                 pp.id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                 pp.friend = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                 pp.description1 = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                 pp.uid = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                 pp.date = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                 pp.time = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                 postsPanel.Controls.Add(pp);

            }

        }
        //populate retweets
        private void populateRetweet()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            retweetPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select p.pid,u1.name as 'owner',p.description,u1.uid,u2.name as 'retweeter',u2.uid,CONVERT(VARCHAR(10), r.retweetDate, 111),CONVERT(VARCHAR(5), r.retweetDate, 108) + (CASE WHEN DATEPART(HOUR, r.retweetDate) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join retweets r on r.pid=p.pid join users u1 on r.uid1=u1.uid join users u2 on u2.uid=r.uid2 where u2.uid in (select f.uid1 from users u join followers f on u.uid=f.uid2 where f.uid2=@a) or u2.uid=@b order by r.retweetDate desc", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id ------> posts of followers of user
            cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id ------> posts of user
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            post pp = new post();
            Label l = new Label();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                pp = new post();
                l = new Label();
                l.Text = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                l.Font = new Font("Arial", 9, FontStyle.Bold);
                retweetPanel.Controls.Add(l);
                l = new Label();
                l.Text = "Retweeted";
                l.Font = new Font("Arial", 9, FontStyle.Bold);
                l.ForeColor = Color.CornflowerBlue;
                pp.id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                pp.friend = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                pp.description1 = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                pp.uid = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                pp.date = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                pp.time = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                retweetPanel.Controls.Add(l);
                retweetPanel.Controls.Add(pp);

            }

        }
        //populate trending
        private void populateTrending()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            trendingPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select top 5 uid,name,followers from users where uid <>@a order by followers desc", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            trending pp = new trending();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                pp = new trending();
                pp.uid = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                pp.name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                pp.followers = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                trendingPanel.Controls.Add(pp);

            }

        }
        //getting user details of user searched
        private void populateUser()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            searchResultsPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select uid,name,bio from users where name like  @a ", con);
            cmd.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            searchResult sr = new searchResult();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                sr = new searchResult();
                sr.uid = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                sr.name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                sr.bio = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                searchResultsPanel.Controls.Add(sr);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
            populateTrending();
            populateRetweet();
            populatePic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchResultsPanel.Visible = true;
            populateUser();
            postsPanel.Visible = false;
            panelAddPost.Visible = false;
            panelProfile.Visible = false;
        }


        
        //getting profile pic of current user
        private void populatePic()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select avatar from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if(!Convert.IsDBNull(dr[0]))
                {
                    byte[] image = ((byte[])dr[0]);
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                
            }
        }
      
        

     

        private void txtPost_Enter(object sender, EventArgs e)
        {
            
            if(txtPost.Text=="What's happening?")
            {
                txtPost.Text = "";
                txtPost.ForeColor = Color.Black;
                txtPost.Font = new Font("Arial", 10);
            }
        }

        private void txtPost_Leave(object sender, EventArgs e)
        {
            if (txtPost.Text == "")
            {
                txtPost.Text = "What's happening?";
                txtPost.ForeColor = Color.Silver;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void txtHome_Click(object sender, EventArgs e)
        {
            disablePanels();
            postsPanel.Visible = true;
            txtRetweets.Visible = true;
            panelAddPost.Visible = true;
            iconRetweets.Visible = true;
            headerPanel.Visible = true ;
            panel5.Visible = true;
            label1.Text = "Home";
            disableButtons();
            iconHome.Image = Properties.Resources.home_blue;
            populateTrending();
            populate();
            populatePic();
        }

        private void txtProfile_Click(object sender, EventArgs e)
        {
            panelProfile.Controls.Clear();
            myProfile p = new myProfile();
            panelProfile.Controls.Add(p);
            disablePanels();
            panelProfile.Visible = true;
            txtRetweets.Visible = false;
            iconRetweets.Visible = false;
            disableButtons();
            iconProfile.Image = Properties.Resources.profile_blue;

        }

        private void txtRetweets_Click(object sender, EventArgs e)
        {
            disablePanels();
            retweetPanel.Visible = true;
            disableButtons();
            iconRetweets.Image = Properties.Resources.blue_retweet;
            populateRetweet();
        }
        //logout
        private void label3_Click(object sender, EventArgs e)
        {
            landing_page l = new landing_page();
            l.Show();
            this.Close();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            disablePanels();
            searchResultsPanel.Visible = true;
            populateUser();
            label1.Text = "Search Results";
        }

        private void txtPost_TextChanged(object sender, EventArgs e)
        {
            if (txtPost.Text == "What's happening?" || txtPost.Text == "")
            {
                btnPost.Enabled = false;
            }
            else
            {
                btnPost.Enabled = true;
            }
        }
        //uploading picture
        string location1 = "";
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg";
            if (d.ShowDialog() == DialogResult.OK)
            {
                location1 = d.FileName.ToString();
                btnPost.Enabled = true;
            }
        }
        //add  post
        private void btnPost_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            //converting pic to byte
                byte[] image = null;
            if(location1!="")
            {
                FileStream s = new FileStream(location1, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(s);
                image = br.ReadBytes((int)s.Length);
                SqlCommand cmd = new SqlCommand("insert into posts (description,uid,likes,pic) values(@a,@b,0,@c)", con);
                cmd.Parameters.AddWithValue("@a", txtPost.Text); //description
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.Parameters.AddWithValue("@c", image); //image
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into posts (description,uid,likes,pic) values(@a,@b,0,NULL)", con);
                cmd.Parameters.AddWithValue("@a", txtPost.Text); //description
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
            }
            if(txtPost.Text=="What's happening?")
            {
                txtPost.Text ="";
            }
        
            txtPost.Text = "What's happening?";
            location1 = "";
            populate();
        }
        void disableButtons()
        {
            iconAnalytics.Image = Properties.Resources.analytics_black;
            iconHome.Image = Properties.Resources.home_black;
            iconProfile.Image = Properties.Resources.profile_black;
            iconRetweets.Image = Properties.Resources.empty_retweet;
        }
        void disablePanels()
        {
            analytics1.Visible = false;
            searchResultsPanel.Visible = false;
            headerPanel.Visible = false;
            postsPanel.Visible = false;
            panelProfile.Visible = false;
            retweetPanel.Visible = false;
            panelAddPost.Visible = false;
            panel5.Visible = false;
        }
        private void lblAnalytics_Click(object sender, EventArgs e)
        {
            disableButtons();
            disablePanels();
            analytics1.Visible = true;
            iconAnalytics.Image = Properties.Resources.analytics;
        }

       
    }

}
