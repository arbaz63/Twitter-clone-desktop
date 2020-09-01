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
    public partial class follow : UserControl
    {
        public follow()
        {
            InitializeComponent();
        }
        public string uid;
        //getting number of followers
        private void getFollowers()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select followers from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lblFollowers.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
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
                button1.Text = "Following";
                return true;
            }
            else
            {
                button1.Text = "Follow";
                return false;
            }
        }
        //follow a user
        private void followUser()
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
                button1.Text = "Following";
                getFollowers();
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
                button1.Text = "Follow";
                getFollowers();
                //MessageBox.Show("Unliked successfully");
            }
        }
        private void follow_Load(object sender, EventArgs e)
        {
            getFollowers();
            button1.Text = checkFollowed() ? "Following" : "Follow";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            followUser();

        }
    }
}
