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
    public partial class Form1 : Form
    {
        //dragging
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            // guna2CirclePictureBox1.Visible = true;
            //guna2PictureBox1.Visible = true;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 204;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            //guna2CirclePictureBox1.Visible = false;
           // guna2PictureBox1.Visible = true;
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Panel1.Width = 41;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadform(new food_items());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            loadform(new pizza());
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            loadform(new savouries());
        }

        private void btn_cofee_Click(object sender, EventArgs e)
        {
            loadform(new coffee());
            guna2VSeparator1.BackColor = Color.Transparent;
            guna2VSeparator1.Height = btn_cofee.Height;
            guna2VSeparator1.Top = btn_cofee.Top;

        }

        private void btn_Lasagna_Click(object sender, EventArgs e)
        {
            loadform(new lasagna());
            guna2VSeparator1.BackColor = Color.Transparent;
            guna2VSeparator1.Height = btn_Lasagna.Height;
            guna2VSeparator1.Top = btn_Lasagna.Top;
        }

        private void btn_Savouries_Click(object sender, EventArgs e)
        {
            loadform(new savouries());
            guna2VSeparator1.BackColor = Color.Transparent;
            guna2VSeparator1.Height = btn_Savouries.Height;
            guna2VSeparator1.Top = btn_Savouries.Top;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            loadform(new user_settings());
            guna2VSeparator1.BackColor = Color.Transparent;
            guna2VSeparator1.Height = btn_Settings.Height;
            guna2VSeparator1.Top = btn_Settings.Top;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            txt_timer.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void allItems_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
