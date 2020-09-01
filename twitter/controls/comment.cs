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
    public partial class comment : UserControl
    {
        public comment()
        {
            InitializeComponent();
        }
        public string id;//post id
        public string name;
        public string description;
        public string uid;
        private void popuate()
        {
            label1.Text = name;
            label2.Text = description;
        }
        //getting profile pic 
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
        private void comment_Load(object sender, EventArgs e)
        {
            popuate();
            populatePic();
        }
    }
}
