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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }
        DataBase connector = new DataBase();

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знайти  назви лего, які купили користувачі з доменом пошти X. Відсортувати в алфавітному порядком", "Інструкція до запиту 1", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Обрати назву та кількість покупок лего набору, відсортувати за спаданням, друге поле назвати 'Кількість'. " +
                    "Обрати Х результатів", "Інструкція до запиту 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вивести назву, тематику та ціну лего набору ціною менше Х. Відсортувати за зростанням ціни", 
                "Інструкція до запиту 3", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обрати назву та ціну наборів, які не купив користувач Х",
                "Інструкція до запиту 4", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знайти назви наборів, які мають аудиторію 'дорослий', та його купив користувач Х",
                "Інструкція до запиту 5", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знайти назви наборів та їх ціни, які купив лише користувач Х",
                "Інструкція до запиту 6", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ніки та пошти тих користувачів, що купили набори серед тих, що і Х",
                "Інструкція до запиту 7", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знайти назви аудиторій, набори лего яких не купляв Х",
                "Інструкція до запиту 7", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
                dgv.DataSource = null;
            else
                dgv.Rows.Clear();
            textBox1.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(!text.Contains("gmail") && !text.Contains("ukr") && !text.Contains("yahoo"))
                MessageBox.Show("База не містить такого домену", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT DISTINCT c.name FROM Constructor AS c JOIN UserBoughtЛego AS b ON b.constructorid = c.id " +
                    "JOIN Users AS u ON b.userid = u.id WHERE u.email LIKE '%@X%' ORDER BY c.name";
                dgv.DataSource = connector.QuerryString(command, text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            int temp;
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!int.TryParse(text, out temp) || temp <= 0)
                MessageBox.Show("Введено нечислове значення параметру або ж не вірний діапазон(менше нуля)", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT TOP @X c.name, COUNT(b.userid) AS Кількість FROM Constructor AS c " +
                    "JOIN UserBoughtЛego AS b ON c.id = b.constructorid GROUP BY c.name ORDER BY 2 DESC";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            int temp;
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!int.TryParse(text, out temp) || temp <= 0)
                MessageBox.Show("Введено нечислове значення параметру або ж не вірний діапазон(менше нуля або більше 100'000)", 
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT name, collection_name, price FROM Constructor AS con " +
                    "JOIN Collection AS col ON con.collection_id = col.id WHERE price < @X ORDER BY price";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT name, price FROM Constructor WHERE id NOT IN" +
                    "( SELECT constructorid FROM UserBoughtЛego WHERE userid = ( SELECT id FROM Users WHERE name = '@X'))";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT c.name FROM UserBoughtЛego AS b JOIN Constructor AS c ON b.constructorid = c.id " +
                    "WHERE c.target_id = 3 AND b.userid = (SELECT id FROM Users WHERE name = '@X')";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT c.name, c.price FROM Constructor AS c WHERE NOT EXISTS " +
                    "(SELECT * FROM Users JOIN UserBoughtЛego ON Users.id = UserBoughtЛego.userid " +
                    "WHERE UserBoughtЛego.constructorid = c.id AND Users.name != '@X')";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT u.name, u.email FROM Users AS u WHERE NOT EXISTS " +
                    "(SELECT b.constructorid FROM UserBoughtЛego AS b WHERE u.id = b.userid AND NOT EXISTS " +
                    "(SELECT * FROM Users JOIN UserBoughtЛego ON Users.id = UserBoughtЛego.userid " +
                    "WHERE UserBoughtЛego.constructorid = b.constructorid AND Users.name = '@X'))";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.ToString();
            if (text.Length == 0)
                MessageBox.Show("Ви забули ввести значення параметру", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string command = "SELECT target_name FROM Target WHERE id NOT IN" +
                    "(SELECT DISTINCT(target_id) FROM Constructor WHERE id IN " +
                    "(SELECT constructorid FROM UserBoughtЛego AS b JOIN Users AS u ON u.id = b.userid " +
                    "WHERE u.id = (SELECT id FROM Users WHERE name = '@X')))";
                dgv.DataSource = connector.QuerryString(command, text);
            }
        }
    }
}
