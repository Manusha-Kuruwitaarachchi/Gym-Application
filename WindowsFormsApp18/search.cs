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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ID.Text== "") 
            {
                    
                    errorProvider1.SetError(ID, "Name is required");
                MessageBox.Show("Search ID field is empty", "Error", MessageBoxButtons.OK,
             MessageBoxIcon.Warning);
            }
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "SELECT *FROM sign WHERE userId='" + this.ID.Text + "' ";
            SqlCommand cm = new SqlCommand(j, con);

            //access data
            SqlDataReader dr = cm.ExecuteReader();


            if (dr.Read())
            {
               
                this.name.Text = dr.GetValue(1).ToString();
                this.age.Text = dr.GetValue(2).ToString();
                this.username.Text = dr.GetValue(3).ToString();
                this.password.Text = dr.GetValue(4).ToString();
                this.country.Text = dr.GetValue(5).ToString();


            }
            else
            {
                MessageBox.Show("No records found", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        
    }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            BM b = new BM();
            b.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
