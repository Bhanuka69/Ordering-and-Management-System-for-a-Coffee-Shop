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
    { //dragging
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        public Admin()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.adminMain_pnl.Controls.Count > 0)
                this.adminMain_pnl.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.adminMain_pnl.Controls.Add(f);
            this.adminMain_pnl.Tag = f;
            f.Show();

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

        private void addItems_btn_Click(object sender, EventArgs e)
        {
            loadform(new Add_items());
           
        }

        private void dSales_btn_Click(object sender, EventArgs e)
        {
            loadform(new Daily_sales());
        }

        private void btn_ChangePW_Click(object sender, EventArgs e)
        {
            loadform(new Admin_settings());
        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);

        }

        private void guna2CustomGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2CustomGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            loadform(new Add_employee());
        }
    }
}
