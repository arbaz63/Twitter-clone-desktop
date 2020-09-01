using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitter.controls
{
    public partial class trending : UserControl
    {
        public trending()
        {
            InitializeComponent();
        }
        public string uid;
        public string name;
        public string followers;
        private void populate()
        {
            lblName.Text = name;
            label1.Text = followers;
        }
        //follow button
        public void populateFollow()
        {
            follow l = new follow();
            l.uid = uid; //assign id of user
            flowLayoutPanel1.Controls.Add(l);
        }
        private void trending_Load(object sender, EventArgs e)
        {
            populate();
            populateFollow();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.uid = uid;
            p.Show();
            Form parent = this.FindForm();
            parent.Close();
        }
    }
}
