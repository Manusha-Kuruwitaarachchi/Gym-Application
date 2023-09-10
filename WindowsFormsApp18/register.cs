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
namespace WindowsFormsApp18
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?",
               "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
                Form1 v = new Form1();
                v.Show();
            }
            else
            {

            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            //connecting with database
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "INSERT into sign(UserID,Name,Age,Username,Password,Country)VALUES('" + this.User.Text + "','" + this.name.Text + "'," + this.age.Text + ",'" + this.username.Text + "','" + this.password.Text + "','" + this.country.Text + "')";
            SqlCommand cm = new SqlCommand(j, con);

            //excute command to insert data
            
            if (this.User.Text==""||this.name.Text==""||this.password.Text==""||this.username.Text=="")
            {
                errorProvider1.SetError(User, "User ID is required");
                errorProvider1.SetError(name, "Name required");
                errorProvider1.SetError(username, "Username is required");
                errorProvider1.SetError(password, "Password required");
                MessageBox.Show("Mandatory fields are empty ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int ret = cm.ExecuteNonQuery();
                MessageBox.Show("You Have Successfully created your account",
                "Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Dispose();

                Cost c = new Cost();
                c.Show();

                this.Hide();

                
            }
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
