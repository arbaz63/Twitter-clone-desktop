using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitter
{
    public partial class landing_page : MetroFramework.Forms.MetroForm
    {
        public landing_page()
        {
            InitializeComponent();
        }

        private void landing_page_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.rem=="yes")
            {
                loginName.Text = Properties.Settings.Default.username;
                loginPassword.Text = Properties.Settings.Default.password;
                checkBox1.Checked = true;
                
            }
        }

        private void btnPanelLogin_Click(object sender, EventArgs e)
        {
            if(loginName.Text==""||loginPassword.Text=="")
            {
                MessageBox.Show("Please input username and password");
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select uid from users where name=@a and password=@b", con);
                cmd.Parameters.AddWithValue("@a", loginName.Text);
                cmd.Parameters.AddWithValue("@b", loginPassword.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                if(dr.HasRows)
                {
                    Properties.Settings.Default.profileUid = dr[0].ToString();
                    if(checkBox1.Checked)
                    {
                        Properties.Settings.Default.username = loginName.Text;
                        Properties.Settings.Default.password = loginPassword.Text;
                        Properties.Settings.Default.rem = "yes";
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.rem = "no";
                        Properties.Settings.Default.Save();
                    }
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your username or password");
                }
            }
        }

        private void btnSignupPanel_Click(object sender, EventArgs e)
        {
            if(signupName.Text==""||signupPassword.Text==""||signupConfirmPassword.Text=="")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BQL02B\\SQLEXPRESS;Initial Catalog=twiter;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                    cmd=new SqlCommand("select uid,name from users where name=@a",con);
                    cmd.Parameters.AddWithValue("@a", signupName.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows)
                    {
                        MessageBox.Show("Username already exist");
                    }
                    else
                    {
                        if(signupPassword.Text==signupConfirmPassword.Text)
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into users (name,followers,password,dob) values(@a,0,@b,@c)",con);
                            cmd.Parameters.AddWithValue("@a", signupName.Text);
                            cmd.Parameters.AddWithValue("@b", signupPassword.Text);
                            string date = day.selectedValue + month.selectedValue + year.selectedIndex;
                            cmd.Parameters.AddWithValue("@c", date);
                            cmd.ExecuteNonQuery();
                            byte[] image = null;
                            string location = "C:\\Users\\Muhammad Arbaz\\Desktop\\twitter\\profile.png";
                            FileStream s = new FileStream(location, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(s);
                            image = br.ReadBytes((int)s.Length);
                            cmd = new SqlCommand("update users set avatar=@a where name=@b", con);
                            cmd.Parameters.AddWithValue("@a", image);
                            cmd.Parameters.AddWithValue("@b", signupName.Text);
                            // cmd.Parameters.AddWithValue("@b", Properties.Settings.Default.profileUid);//user id
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Signup successfully");
                            signupName.Text = signupPassword.Text = signupConfirmPassword.Text = "";
                            panelLogin.Visible = false;
                            signupPanel.Visible = false;
                            panelLoginSignup.Visible = true;
                            panel2.Visible = true;
                            button1.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Password don't match");
                        }
                    }
            }




        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelLoginSignup.Visible = false;
            signupPanel.Visible = false;
            panel2.Visible = false;
            button1.Visible = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLoginSignup.Visible = false;
            signupPanel.Visible = true;
            panel2.Visible = false;
            button1.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelLoginSignup.Visible = false;
            signupPanel.Visible = true;
            panel2.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            signupPanel.Visible = false;
            panelLoginSignup.Visible = true;
            panel2.Visible = true;
            button1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
