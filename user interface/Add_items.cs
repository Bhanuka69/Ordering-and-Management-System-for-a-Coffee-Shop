using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace user_interface
{
    public partial class Add_items : Form
    {
        public Add_items()
        {
            InitializeComponent();
        }
        string imgLoc = "";//browse
        SqlConnection con;
        SqlCommand com;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //get pic using browse command
        private void btn_browse_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffee_ShopDataSet3.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.coffee_ShopDataSet3.Product);
            // TODO: This line of code loads data into the 'coffee_ShopDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.coffee_ShopDataSet.Product);
            con = new SqlConnection("Data Source=LAPTOP-8BTCQSS2;Initial Catalog=Coffee_Shop;Integrated Security=True");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "insert into product (P_ID,price,description,pimage,pname)VALUES('" + txt_pid.Text + "','" + txt_price.Text + "','" + txt_pdec.Text + "',@img,'" + txt_pname.Text + "')";
                if (con.State != ConnectionState.Open)
                    con.Open();
                com = new SqlCommand(sql, con);
                com.Parameters.Add(new SqlParameter("@img", img));
                int x = com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "record(s) saved");
                txt_pid.Text = "";
                txt_pname.Text = "";
                txt_price.Text = "";
                txt_pdec.Text = "";    
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                productBindingSource.EndEdit();
                productTableAdapter.Update(this.coffee_ShopDataSet.Product);
                MessageBox.Show("you have been successfully saved.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("are you sure want to delete this record?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
