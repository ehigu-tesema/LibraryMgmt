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

namespace Lib
{
    public partial class addBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jo\Documents\Lib.mdf;Integrated Security=True;Connect Timeout=30");
        public addBook()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string author = txtAuthor.Text;
            string quantity = txtQuantity.Text;
            string date = dtDate.Text;
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into book values('" + name + "','" + author + "','" + quantity + "','" + date + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("good job");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtName.Text = "";
                txtAuthor.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void dtDate_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
