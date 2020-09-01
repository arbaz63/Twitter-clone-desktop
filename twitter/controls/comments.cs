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
    public partial class comments : UserControl
    {
        public comments()
        {
            InitializeComponent();
        }
       //getting id from parent (post)
        public string id;
        private void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd=new SqlCommand("select c.description,u.name,u.uid from comments c join users u on u.uid=c.uid and c.pid=@a",con);
            cmd.Parameters.AddWithValue("@a",id);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            comment c = new comment();
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                c = new comment();
                c.description=ds.Tables[0].Rows[i].ItemArray[0].ToString();
                c.name=ds.Tables[0].Rows[i].ItemArray[1].ToString();
                c.uid = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                flowLayoutPanel1.Controls.Add(c);
            }
            //c.name = "arbaz";
            //c.description = "nice post";
            //c.id = id;
            //flowLayoutPanel1.Controls.Add(c);
            //c = new comment();
            //c.name = "haroon";
            //c.description = "wow";
        }
        private void comments_Load(object sender, EventArgs e)
        {
            populate();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into comments values(@a,@b,@c)", con);
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", id);
            cmd.Parameters.AddWithValue("@c", Properties.Settings.Default.profileUid);//user id
            cmd.ExecuteNonQuery();
            MessageBox.Show("Comment added successfully");
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
