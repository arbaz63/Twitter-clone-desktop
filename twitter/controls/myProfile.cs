using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace twitter.controls
{
    public partial class myProfile : UserControl
    {
        public myProfile()
        {
            InitializeComponent();
        }
        public string uid;
        //getting posts of user having id
        private void populatePost()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            tweetsPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select p.pid,u.name,p.description,p.uid,CONVERT(VARCHAR(10), date, 111),CONVERT(VARCHAR(5), date, 108) + (CASE WHEN DATEPART(HOUR, date) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join users u on p.uid=u.uid where p.uid=@a order by date desc", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id
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
                tweetsPanel.Controls.Add(pp);

            }

        }
        //getting retweets
        private void populateRetweet()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            retweetPanel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select p.pid,p.description,u1.name,u1.uid,CONVERT(VARCHAR(10), r.retweetDate, 111),CONVERT(VARCHAR(5), r.retweetDate, 108) + (CASE WHEN DATEPART(HOUR, r.retweetDate) > 12 THEN ' PM' ELSE ' AM' END) 'Hour:Minutes' from posts p join retweets r on r.pid=p.pid join users u1 on r.uid1=u1.uid join users u2 on u2.uid=r.uid2 where u2.uid=@a order by r.retweetDate desc", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid); //user id
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
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            name.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bioTxt.Text = bio.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            lblJoinDate.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if(bio.Text==""||bioTxt.Text=="")
            {
                bioTxt.Text = bio.Text = "Add your bio";
                btnEditBio.Text = "Add Bio";
            }
            else
            {
                btnEditBio.Text = "Edit Bio";
            }
           
        }
        //getting followers
        private void populateFollowers()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from followers f join users u on f.uid1=u.uid where u.uid=@a", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id
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
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            following.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        private void myProfile_Load(object sender, EventArgs e)
        {
            populateUser();
            populateFollowers();
            populateFollowing();
            populatePost();
            populateRetweet();
            populateProfilePic();
            location = pictureBox1.ImageLocation;
        }

        private void btnRetweet_Click(object sender, EventArgs e)
        {
            tweetsPanel.Visible = false;
            retweetPanel.Visible = true;
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            tweetsPanel.Visible = true;
            retweetPanel.Visible = false;
        }
        //uploading profile pic
        string location = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg";
            if(d.ShowDialog()==DialogResult.OK)
            {
                location = d.FileName.ToString();
                pictureBox1.ImageLocation = location;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                byte[] image = null;
                FileStream s = new FileStream(location,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(s);
                image = br.ReadBytes((int)s.Length);
                SqlCommand cmd = new SqlCommand("update users set avatar=@a where uid=@b", con);
                cmd.Parameters.AddWithValue("@a", image);
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uploaded successfully");
                populatePost();
                populateRetweet();
            }
            catch(Exception )
            {
                MessageBox.Show("Please select file first");
            }
        }
        //getting profile pic
        private void populateProfilePic()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select avatar from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);//user id    
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                byte[] image = ((byte[])dr[0]);
                if(image==null)
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

        private void btnEditBio_Click(object sender, EventArgs e)
        {
            
            btnSaveBio.Visible = true;
            //txtBio.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select bio from users  where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            bioTxt.Text = dr[0].ToString();
            bioTxt.ReadOnly = false;
            bioTxt.Enabled = true;
            btnEditBio.Visible = false;
            dr.Close();
            
        }

        private void btnSaveBio_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update users set bio=@a where uid=@b", con);
            cmd.Parameters.AddWithValue("@a", bioTxt.Text);
            cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated successfully");
            populateUser();
            btnSaveBio.Visible = false;
            bioTxt.ReadOnly = true;
            bioTxt.Enabled = false;
            btnEditBio.Visible = true;
            //txtBio.Visible = false;
        }
    }
}
