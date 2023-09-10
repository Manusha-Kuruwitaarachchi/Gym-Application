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
    public partial class userregistar : Form
    {
        DataSet ds;
        int i = 0;
        public userregistar()
        {
            InitializeComponent();
        }

        private void Data_Click(object sender, EventArgs e)
        {
            //connecting with database
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "SELECT *FROM sign";
            SqlCommand cm = new SqlCommand(j, con);

            //access data
            SqlDataAdapter da = new SqlDataAdapter(cm);
            ds = new DataSet();
            da.Fill(ds);

            //bind data with controls
            this.User.Text = ds.Tables[0].Rows[0][0].ToString();
            this.name.Text = ds.Tables[0].Rows[0][1].ToString();
            this.age.Text = ds.Tables[0].Rows[0][2].ToString();
            this.username.Text = ds.Tables[0].Rows[0][3].ToString();
            this.password.Text = ds.Tables[0].Rows[0][4].ToString();
            this.country.Text = ds.Tables[0].Rows[0][5].ToString();

            //data grid
            this.dataGridView1.DataSource = ds.Tables[0];

            //close the connection
            con.Dispose();
        }

        private void prevoius_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i = i - 1;
                this.User.Text = ds.Tables[0].Rows[i][0].ToString();
                this.name.Text = ds.Tables[0].Rows[i][1].ToString();
                this.age.Text = ds.Tables[0].Rows[i][2].ToString();
                this.username.Text = ds.Tables[0].Rows[i][3].ToString();
                this.password.Text = ds.Tables[0].Rows[i][4].ToString();
                this.country.Text = ds.Tables[0].Rows[i][5].ToString();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            int rc = ds.Tables[0].Rows.Count;
            if (i < rc - 1)
            {
                i = i + 1;
                this.User.Text = ds.Tables[0].Rows[i][0].ToString();
                this.name.Text = ds.Tables[0].Rows[i][1].ToString();
                this.age.Text = ds.Tables[0].Rows[i][2].ToString();
                this.username.Text = ds.Tables[0].Rows[i][3].ToString();
                this.password.Text = ds.Tables[0].Rows[i][4].ToString();
                this.country.Text = ds.Tables[0].Rows[i][5].ToString();
            }
        }

        private void First_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i = 0;
                this.User.Text = ds.Tables[0].Rows[i][0].ToString();
                this.name.Text = ds.Tables[0].Rows[i][1].ToString();
                this.age.Text = ds.Tables[0].Rows[i][2].ToString();
                this.username.Text = ds.Tables[0].Rows[i][3].ToString();
                this.password.Text = ds.Tables[0].Rows[i][4].ToString();
                this.country.Text = ds.Tables[0].Rows[i][5].ToString();

            }
        }

        private void last_Click(object sender, EventArgs e)
        {
            i = ds.Tables[0].Rows.Count - 1;

            this.User.Text = ds.Tables[0].Rows[i][0].ToString();
            this.name.Text = ds.Tables[0].Rows[i][1].ToString();
            this.age.Text = ds.Tables[0].Rows[i][2].ToString();
            this.username.Text = ds.Tables[0].Rows[i][3].ToString();
            this.password.Text = ds.Tables[0].Rows[i][4].ToString();
            this.country.Text = ds.Tables[0].Rows[i][5].ToString();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            //connecting with database
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "INSERT into sign(UserID,Name,Age,Username,Password,Country)VALUES('" + this.User.Text + "','" + this.name.Text + "'," + this.age.Text + ",'" + this.username.Text + "','" + this.password.Text + "','" + this.country.Text + "')";
            SqlCommand cm = new SqlCommand(j, con);

            //excute command to insert data
            int ret = cm.ExecuteNonQuery();
            MessageBox.Show("No of records inserted " + ret, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            con.Dispose();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            //connecting with database
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "UPDATE sign SET userID='" + this.User.Text + "',name='" + this.name.Text + "',age=" + this.age.Text + ",username='" + this.username.Text + "',password='" + this.password.Text + "',country='" + this.country.Text + "'WHERE userID='" + this.User.Text + "' ";
            SqlCommand cm = new SqlCommand(j, con);

            //excute command to insert data
            int ret = cm.ExecuteNonQuery();
            MessageBox.Show("No of records updated " + ret, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);


            con.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "SELECT *FROM sign WHERE userId='" + this.User.Text + "' ";
            SqlCommand cm = new SqlCommand(j, con);

            //access data
            SqlDataReader dr = cm.ExecuteReader();


            if (dr.Read())
            {
                this.User.Text = dr.GetValue(0).ToString();
                this.name.Text = dr.GetValue(1).ToString();
                this.age.Text = dr.GetValue(2).ToString();
                this.username.Text = dr.GetValue(3).ToString();
                this.password.Text = dr.GetValue(4).ToString();
                this.country.Text = dr.GetValue(5).ToString();


            }
            else
            {
                MessageBox.Show("No records found", "Error");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string d = "Data Source=DESKTOP-5EF5D8V;Initial Catalog=fitness;Integrated Security=True";
            SqlConnection con = new SqlConnection(d);
            con.Open();

            //define command
            string j = "DELETE FROM sign WHERE userId='" + this.User.Text + "' ";
            SqlCommand cm = new SqlCommand(j, con);


            DialogResult dialog = MessageBox.Show("Do you really want to delete data?",
               "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int ret = cm.ExecuteNonQuery();
                MessageBox.Show("No of records Deleted " + ret, "Information");


                con.Close();
            }
            else
            {

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void userregistar_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            BM b = new BM();
            b.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
