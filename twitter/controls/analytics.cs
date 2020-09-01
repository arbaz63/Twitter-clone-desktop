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
    public partial class analytics : UserControl
    {
        public analytics()
        {
            InitializeComponent();
        }
        Graphics g;
        string uid = Properties.Settings.Default.profileUid;
        private void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*),CONVERT(VARCHAR(10), dateLiked, 111) from likes l join posts p on l.pid=p.pid where p.uid=@a group by CONVERT(VARCHAR(10), dateLiked, 111) ", con);
            cmd.Parameters.AddWithValue("@a", Properties.Settings.Default.profileUid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                int likes = Int32.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                //chart1.Series["analytics"].Points.AddXY(ds.Tables[0].Rows[i].ItemArray[0].ToString(), ds.Tables[0].Rows[i].ItemArray[1].ToString());
                chart1.Series["Likes"].Points.AddXY(ds.Tables[0].Rows[i].ItemArray[1].ToString(),likes);
                analyticsItem at = new analyticsItem();
                at.likes = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                at.date = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                panelItems.Controls.Add(at);
            }
            //total likes
            cmd = new SqlCommand("select sum(likes) from posts where uid=@a ", con);
            cmd.Parameters.AddWithValue("@a", uid);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            lblLikes.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            //total posts
            cmd = new SqlCommand("select count(*) from posts where uid=@a ", con);
            cmd.Parameters.AddWithValue("@a", uid);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            lblPosts.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        private void analytics_Load(object sender, EventArgs e)
        {
            populate();
            //flipping graph
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelItems.Visible = true;
        }
    }
}
