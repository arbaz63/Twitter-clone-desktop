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
    public partial class analyticsItem : UserControl
    {
        public analyticsItem()
        {
            InitializeComponent();
        }
        public string likes;
        public string date;

        private void analyticsItem_Load(object sender, EventArgs e)
        {
            lblLikes.Text = likes;
            lblDate.Text = date;
        }
    }
}
