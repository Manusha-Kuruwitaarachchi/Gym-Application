using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Cost : Form
    {
        public Cost()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                double cw, t=0.0, ct;
                double m;
              
                m = 3000;

                if (this.yes.Checked == true)
                {
                    m = m + 500;
                }
                if (this.radioButton1.Checked == true)
                {
                    m = m + 100;
                }
                if (this.comboBox1.Text == "Anabolic")
                {
                    m = m + 1000;
                }
                else
                {
                    m = m + 200;
                }

                cw = m - t;

                t = m + 100;

                ct = cw + t;

                this.without.Text = cw.ToString();
                this.textBox6.Text = t.ToString();
                this.total.Text = ct.ToString();



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Cost_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void fee_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (this.total.Text == this.amount.Text)
            {
                MessageBox.Show("Payment has been made successfully",
                     "Payment", MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Hide();
                BM b = new BM();
                b.Show();
            }
            else
            {

                MessageBox.Show("Amounts do not get tally",
                        "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (this.Cardno.Text == "" || this.amount.Text == "")
            {
                MessageBox.Show("Mandotary Fields are empty",
                "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
           
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) 
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            register r = new register();
            r.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
