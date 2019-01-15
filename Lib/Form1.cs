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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jo\Documents\Lib.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterUsername(object sender, EventArgs e)
        {
            if(Username.Text== "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Blue;
            }
        }

        private void LeaveUsername(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Gray;
            }
        }

        private void PasswordEnter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Blue;
            }
        }

        private void PasswordLeave(object sender, EventArgs e)
        {

            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Gray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text == "Username")
                {
                    MessageBox.Show("Please Fill Username field");
                }
                if (Password.Text == "Password")
                {
                    MessageBox.Show("please fill Password Field");
                }

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from staff where name='" + Username.Text + "' AND password='" + Password.Text + "' ", con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("login Success");
                }
                else
                {
                    MessageBox.Show("invalid Username and password combination");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
