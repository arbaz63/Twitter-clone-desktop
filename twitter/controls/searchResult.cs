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
    public partial class searchResult : UserControl
    {
        public searchResult()
        {
            InitializeComponent();
        }
        //getting data from parent
        public string name;
        public string bio;
        public string uid;
        private void populate()
        {
            nameLabel.Text = name;
            bioLabel.Text = bio;
        }
        private void searchResult_Load(object sender, EventArgs e)
        {
            if(uid==Properties.Settings.Default.profileUid)//user id
            {
                flowLayoutPanel1.Visible = false;
            }
            else
            {
                flowLayoutPanel1.Visible = true;
            }
            populate();
            populateFollow();
            populateProfilePic();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.uid = uid;
            p.Show();
        }
        //passing data to another child
        public void populateFollow()
        {
            follow l = new follow();
            l.uid = uid; //assign id of user
            flowLayoutPanel1.Controls.Add(l);
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
    }
}
