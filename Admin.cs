using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_interface
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 204;
            adminTransition.ShowSync(guna2Panel1);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Panel1.Width = 41;
            adminTransition.ShowSync(guna2Panel1);
        }
    }
}
