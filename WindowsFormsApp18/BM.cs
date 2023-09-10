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
    public partial class BM : Form
    {
        public BM()
        {
            InitializeComponent();
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            double w, h;
            double o;
            string a;
            if (this.weight.Text == "" && this.height.Text == "")
            {
                MessageBox.Show("Mandatory fields are empty?",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            w = Convert.ToDouble(this.weight.Text);
            h = Convert.ToDouble(this.height.Text);
            a = Convert.ToString(this.answer.Text);
            o = (w * 703) / (h * h);

            if (o < 18.5)
            {
                a = "Underweight " + "Please take some multivitamins to get ideal weight";
                this.answer.BackColor = Color.CadetBlue;
            }

            else if (o > 18.5 && o < 24.9)
            {
                a = "Normal " + "Good and please maintain your ideal weight";
                this.answer.BackColor = Color.Green;
            }
            else if (o > 25 && o < 29.9)
            {
                a = "Overweight " + "Please start to follow a diet plan and do some exercises";
                this.answer.BackColor = Color.Yellow;
            }

            else
            {
                a = "Obese " + "Visit your private doctor";
                this.answer.BackColor = Color.Red;
            }

            this.output.Text = o.ToString();
            this.answer.Text = a;

        }

        private void clear_Click(object sender, EventArgs e)
        {

            this.weight.Text = "";
            this.height.Text = "";
            this.output.Text = "";
            this.answer.Text = "";

            this.answer.BackColor = Color.White;
        }

        private void dumbellCurlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dumbbell n = new dumbbell();
            n.Show();
        }

        private void hammerCurlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hammercurl h = new hammercurl();
            h.Show();
        }

        private void overheadPressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            over o = new over();
            o.Show();
        }

        private void barbellShToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barbell b = new barbell();
            b.Show();
        }

        private void arnoldPressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arnold a = new arnold();
            a.Show();
        }

        private void standingCalfRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standing st = new standing();
            st.Show();
        }

        private void neckBridgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neckbridge n = new neckbridge();
            n.Show();
        }

        private void backExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backextension b = new backextension();
            b.Show();
        }

        private void dumbBellCrunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dumbelcrunch dc = new dumbelcrunch();
            dc.Show();
        }

        private void tuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tuck t = new tuck();
            t.Show();
        }

        private void hangingLegRaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hanging h = new hanging();
            h.Show();
        }

        private void grammerRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grammar g = new grammar();
            g.Show();
        
        }

        private void closeGripBenchPressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close c = new close();
            c.Show();
        }

        private void declineTricepsExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decline d = new decline();
            d.Show();
        }

        private void behindtheBackCableCurlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            behind bh = new behind();
            bh.Show();
        }

        private void eZBarPreacherCurlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ez er = new ez();
            er.Show();
        }

        private void legPressCalfRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leg l = new leg();
            l.Show();
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Logout?",
               "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void dataLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void specificUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userregistar uy = new userregistar();
            uy.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
