using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Lib
{
    public partial class addStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jo\Documents\Lib.mdf;Integrated Security=True;Connect Timeout=30");
        string imgLocation = "";
        public addStudent()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Png Files(*.png)|*.png|Jpg Files(*.jpg)|*.jpg|All Files(*.*)|*.* ";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    bunifuPictureBox1.ImageLocation = imgLocation;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] image = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                image = br.ReadBytes((int)stream.Length);
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into student (name,SID,department,image) values('" + txtName.Text + "','" + txtId.Text + "','" + txtDepartment.Text + "',@image)", con);
                cmd.Parameters.Add(new SqlParameter("image", @image));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Done");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
