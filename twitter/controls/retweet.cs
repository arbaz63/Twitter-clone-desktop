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

namespace twitter.controls
{
    public partial class retweet : UserControl
    {
        public retweet()
        {
            InitializeComponent();
        }
        public string uid;
        //got id from parent (post)
        public string id;
        //getting number of retweets for a post
        private void populateRetweets()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from retweets where pid=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //button1.Text += " " + ds.Tables[0].Rows[0].ItemArray[0].ToString() + ""; 
            label1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        //checking if current user has already retweet or not
        private bool checkRetweeted()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from retweets where pid=@a and uid1=@b and uid2=@c", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.Parameters.AddWithValue("@b", uid);//owner id
            cmd.Parameters.AddWithValue("@c", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                pictureBox1.Image = Properties.Resources.blue_retweet;
                return true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.empty_retweet;
                return false;
            }
        }
        //retweet a post
        private void retweetPost()
        {
            if (!checkRetweeted())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into retweets values(@a,@b,@c,getDate())", con);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", uid);//owner id
                cmd.Parameters.AddWithValue("@c", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.blue_retweet;
                populateRetweets();

            }
            else if (checkRetweeted())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from retweets where pid=@a and uid1=@b and uid2=@c", con);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", uid);//owner id
                cmd.Parameters.AddWithValue("@c", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.empty_retweet;
                populateRetweets();
            }
        }

        private void retweet_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = checkRetweeted() ? Properties.Resources.blue_retweet : Properties.Resources.empty_retweet;
            populateRetweets();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            retweetPost();
        }
    }
}
