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
    public partial class profileTooltip : UserControl
    {
        public string uid = Properties.Settings.Default.profileUid;
        public profileTooltip()
        {
            InitializeComponent();
        }
        //getting user details of user
        private void populateUser()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select name,bio from users where uid=@a", con);
            cmd.Parameters.AddWithValue("@a", uid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            name.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            bio.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        }
        //getting profile pic of current user
        private void populatePic()
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
            populateFollowers();
            populateFollowing();
            populateUser();
            populatePic();
        }
    }
}
