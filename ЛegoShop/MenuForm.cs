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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void шоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лego Shop. База містить 5 таблиць: користувачі, набори, вікові групи, тематики конструкторів, куплені набори по користувачам", "Інформація");
        }

        private void запитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm form = new QueryForm();
            form.Show();
        }

        private void додаванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertForm form = new InsertForm();
            form.Show();
        }

        private void видаленняоновленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm();
            form.Show();
        }

        private void вмістТаблицьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchFullForm form = new WatchFullForm();
            form.Show();
        }

        private void завершенняРоботиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви справді хочете закрити програму?", "Dialog Title", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
