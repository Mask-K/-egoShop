using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ЛegoShop
{
    public partial class WatchFullForm : Form
    {
        public WatchFullForm()
        {
            InitializeComponent();
        }
        DataBase connector = new DataBase();
        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = connector.GetInfo("Users");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = connector.GetInfo("Constructor");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv.DataSource = connector.GetInfo("Target");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv.DataSource = connector.GetInfo("Collection");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv.DataSource = connector.GetInfo("UserBoughtЛego");
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
                dgv.DataSource = null;
            else
                dgv.Rows.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
