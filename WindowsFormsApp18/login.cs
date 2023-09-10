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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string u, p;
            u = this.username.Text;
            p = this.password.Text;

            //connecting with database
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "SELECT*FROM sign WHERE username='" + u + "'AND password='" + p + "'";
            SqlCommand cm = new SqlCommand(j, con);

            //access data using Data reader method
            SqlDataReader dr = cm.ExecuteReader();

           
             if (this.username.Text == "" || this.password.Text == "" )
            {
                errorProvider1.SetError(username, "Name is required");
                errorProvider1.SetError(password, "Password required");
                MessageBox.Show("Mandatory fields are empty ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           else if (dr.Read())
            {
                MessageBox.Show("You have successfully logged into your account", "Login",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                BM m = new BM();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invailed Username or password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            //close connection
            con.Dispose();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
