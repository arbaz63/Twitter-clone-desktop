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
    public partial class post : UserControl
    {
        public post()
        {
            InitializeComponent();
            populate();
        }
            public string id; //post id
            public string friend; //name of owner
            public string description1; //post description
            public string uid; //whose post
            public string date;
            public string time;
        //getting data from parent
        public void populate()
        {
            friend_name.Text = friend;
            description.Text = description1;
            Size size = TextRenderer.MeasureText(description.Text, description.Font);
            description.Width = size.Width;
            description.Height = size.Height;
            dateAndTime.Text = "On " + date + " At " + time;
        }
        //passing data to another child
        public void populateLike()
        {
            like l = new like();
            l.id = id; //assign id of post
            flowLayoutPanel1.Controls.Add(l);
        }
        //passing data to another child
        public void populateRetweet()
        {
            retweet l = new retweet();
            l.id = id; //assign id of post
            l.uid = uid;//owner id
            retweetPanel.Controls.Add(l);
        }
        public void populateComments()
        {
            comments c = new comments();
            c.id= id;//assign id of post
            flowLayoutPanel2.Controls.Add(c);
        }
        private void post_Load(object sender, EventArgs e)
        {
            populate();
            populateLike();
            populateComments();
            populateCommentsCount();
            populateRetweet();
            populateProfilePic();
            populatePostPic();
            //delete button
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            if(uid==Properties.Settings.Default.profileUid)
            {
                iconDel.Visible = true;
                iconUpdate.Visible = true;
            }
           // populateComment();
        }
        //getting number of likes for a post
        private void populateCommentsCount()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from comments where pid=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //button1.Text += " " + ds.Tables[0].Rows[0].ItemArray[0].ToString() + ""; 
            commentsCount.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        //show tooltip having friend info on hover

        private void friend_name_MouseHover(object sender, EventArgs e)
        {
            profileTooltip p = new profileTooltip();
            p.uid = uid;
            panel1.Visible = true;
            panel1.Controls.Add(p);
        }

        //hide tooltip on leave
        private void friend_name_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
        //open profile
        private void friend_name_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.uid = uid;
            p.Show();
            Form parent = this.FindForm();
            parent.Close();
            //parent.Text = "hello";
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
                if (!Convert.IsDBNull(dr[0]))
                {
                    byte[] image = ((byte[])dr[0]);
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
        //getting post pic
        private void populatePostPic()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select pic from posts where pid=@a", con);
            cmd.Parameters.AddWithValue("@a", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (!Convert.IsDBNull(dr[0]))
                {
                    byte[] image = ((byte[])dr[0]);
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox2.Image = Image.FromStream(ms);
                    Size size = new Size(300, 300);
                    pictureBox2.Size = size;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from posts where uid=@a and pid=@b", con);
            cmd.Parameters.AddWithValue("@a", uid);
            cmd.Parameters.AddWithValue("@b", id);
            cmd.ExecuteNonQuery();    
            panelPost.Visible = false;

        }

        private void commentIcon_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            description.ReadOnly = false;
            description.Enabled = true;
            iconSave.Visible = true;
            iconPic.Visible = true;
            if(pictureBox2.Image!=null)
            {
                iconDelPic.Visible = true;
            }
        }

        //updating picture
        string location1 = "";
        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg";
            if (d.ShowDialog() == DialogResult.OK)
            {
                location1 = d.FileName.ToString();
            }
        }
        //saving updated changes
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            //converting pic to byte
            byte[] image = null;
            if (location1 != "")
            {
                pictureBox2.Visible = true;
                FileStream s = new FileStream(location1, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(s);
                image = br.ReadBytes((int)s.Length);
                SqlCommand cmd = new SqlCommand("update posts set description=@a, pic=@b where pid=@c", con);
                cmd.Parameters.AddWithValue("@a", description.Text); //description
                cmd.Parameters.AddWithValue("@b", image);//image
                cmd.Parameters.AddWithValue("@c", id); //post id
                cmd.ExecuteNonQuery();
                MemoryStream ms = new MemoryStream(image);
                pictureBox2.Image = Image.FromStream(ms);
                Size size = new Size(300, 300);
                pictureBox2.Size = size;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update posts set description=@a where pid=@b", con);
                cmd.Parameters.AddWithValue("@a", description.Text); //description
                cmd.Parameters.AddWithValue("@b",id);// pid
                cmd.ExecuteNonQuery();
            }
            
            description.ReadOnly = true;
            description.Enabled = false;
            iconSave.Visible = false;
            iconPic.Visible = false;
            iconDelPic.Visible = false;
        }

        private void btnDelPic_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update posts set pic=NULL where pid=@a ", con);
            cmd.Parameters.AddWithValue("@a", id);// pid
            cmd.ExecuteNonQuery();
            pictureBox2.Visible = false;
            iconDelPic.Visible = false;
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(description.Text, description.Font);
            description.Width = size.Width;
            description.Height = size.Height;
        }

    }
}
