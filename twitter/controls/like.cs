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
    public partial class like : UserControl
    {
        public like()
        {
            InitializeComponent();
        }
        //got id from parent (post)
        public string id;
        //getting number of likes for a post
        private void populateLikes()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from likes where pid=@a", con);
                cmd.Parameters.AddWithValue("@a", id);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataSet ds=new DataSet();
                da.Fill(ds);
                //button1.Text += " " + ds.Tables[0].Rows[0].ItemArray[0].ToString() + ""; 
                label1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            
        }
        //checking if current user has already liked or not
        private bool checkLiked()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from likes where pid=@a and uid=@b", con);
            cmd.Parameters.AddWithValue("@a", id);
            cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                pictureBox1.Image = Properties.Resources.red_heart;                
                return true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.empty_heart;
                return false;
            }    
        }
        //like a post
        private void likePost()
        {
            if(!checkLiked())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into likes values(@a,@b,getdate())", con);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update posts set likes+=1 where pid=@a", con);
                cmd.Parameters.AddWithValue("@a", id);//post id
                cmd.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.red_heart;
                populateLikes();
                //MessageBox.Show("Liked successfully");
            }
            else if(checkLiked())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from likes where pid=@a and uid=@b", con);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update posts set likes-=1 where pid=@a", con);
                cmd.Parameters.AddWithValue("@a", id);//post id
                cmd.ExecuteNonQuery();
                pictureBox1.Image = Properties.Resources.empty_heart;
                populateLikes();
                //MessageBox.Show("Unliked successfully");
            }
        }
        private void like_Load(object sender, EventArgs e)
        {
            populateLikes();
            //checkLiked();
            pictureBox1.Image = checkLiked() ? Properties.Resources.red_heart : Properties.Resources.empty_heart;
            //button1.Image = (Image)(new Bitmap(Properties.Resources.like, new Size(32, 32)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            likePost();
        }
    }
}
