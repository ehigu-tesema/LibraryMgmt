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
    public partial class viewStudentInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jo\Documents\Lib.mdf;Integrated Security=True;Connect Timeout=30");

        public viewStudentInfo()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewStudentInfo_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student",con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)bunifuCustomDataGrid1.Columns[4];
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void EnterText(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from student where name like'%" + txtSearch.Text + "%' ", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)bunifuCustomDataGrid1.Columns[4];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
