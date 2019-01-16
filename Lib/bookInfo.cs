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
    public partial class bookInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jo\Documents\Lib.mdf;Integrated Security=True;Connect Timeout=30");

        public bookInfo()
        {
            InitializeComponent();
        }

        private void bookInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from book", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search(object sender, KeyEventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("select * from book where name like'%" + srch.Text + "%' ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Enter(object sender, EventArgs e)
        {
            if(srch.Text=="type here..")
            {
                srch.Text = "";
                srch.ForeColor = Color.Blue;
            }
        }

        private void Leave(object sender, EventArgs e)
        {
            if (srch.Text == "")
            {
                srch.Text = "type here..";
                srch.ForeColor = Color.Gray;
            }
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                
            try
            {
                bunifuCustomDataGrid2.Visible = true;
            int i;
            i = Convert.ToInt32(bunifuCustomDataGrid1.SelectedCells[0].Value.ToString());
               
            
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from book where id='" + i + "'",con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.Close();
                foreach(DataRow dr in dt.Rows)
                {
                    name.Text = dr["name"].ToString();
                    author.Text = dr["author"].ToString();
                    quantity.Text = dr["quantity"].ToString();
                    date.Text = dr["pdate"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid2.Visible = true;
            int i;
            i = Convert.ToInt32(bunifuCustomDataGrid1.SelectedCells[0].Value.ToString());

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update book set name='" + name.Text + "',author='" + author.Text + "',quantity='" + quantity.Text + "',pdate='" + date.Text + "' where id='"+i+"' ",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
