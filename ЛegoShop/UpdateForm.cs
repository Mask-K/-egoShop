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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Complete.Enabled = true;
                Таблиця.Enabled = false;
                label2.Visible = false;
                label5.Text = "Впишіть необхідну інформацію та поставте галочку";
                textBox1.Visible = true;
                textBox1.Text = "";
                label1.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                textBox2.Text = "";
                textBox2.Visible = true;
                if (Таблиця.SelectedItem == "Користувач")
                {
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton3.Text = "Нікнейм";
                    radioButton4.Text = "Пошта";
                }
                else if(Таблиця.SelectedItem == "Лего набір")
                {

                    radioButton3.Text = "Назва";
                    radioButton4.Text = "Айді аудиторії";
                    radioButton5.Text = "Ціна";
                    radioButton6.Text = "Айді тематики";
                    radioButton3.Visible = true;
                    radioButton4.Visible = true;
                    radioButton5.Visible = true;
                    radioButton6.Visible = true;
                }
                else if(Таблиця.SelectedItem == "Тематика лего")
                {
                    radioButton3.Text = "Назва";
                    radioButton3.Visible = true;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                }
                else if(Таблиця.SelectedItem == "Вік")
                {
                    radioButton3.Text = "Аудиторія";
                    radioButton3.Visible = true;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                }
                else if(Таблиця.SelectedItem == "Лего за користувачами")
                {
                    textBox1.Text = "";
                    Таблиця.SelectedIndex = -1;
                    Таблиця.Enabled = true;
                    Complete.Enabled = false;
                    label1.Visible = false;
                    label2.Visible = false;

                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    label5.Text = "Оберіть таблицю";
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    MessageBox.Show("Для цієї таблиці не можна робити оновлення.", "Сповіщення", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    
                }
            }
            
        }

        private void Таблиця_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Таблиця.SelectedIndex != -1)
            {
                label5.Text = "Оберіть дію";
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Таблиця.Enabled = false;
                Complete.Enabled = true;
                label5.Text = "Впишіть айді об'єкту для видалення";
                label1.Text = "Айді";
                if(Таблиця.SelectedItem == "Лего за користувачами")
                {
                    label1.Text = "Айді користувача";
                    label2.Text = "Айді конструктора";
                    label2.Visible = true;
                    textBox2.Visible = true;
                }
                else
                    textBox2.Visible = false;
                textBox1.Text = "";
                label1.Visible = true;
                textBox1.Visible = true;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
            }
            

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Таблиця.SelectedIndex = -1;
            Таблиця.Enabled = true;
            Complete.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            
            textBox1.Visible = false;
            textBox2.Visible=false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            label5.Text = "Оберіть таблицю";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            try
            {
                var connector = new DataBase();
                if (radioButton2.Checked)
                {
                    switch (Таблиця.SelectedItem)
                    {
                        case "Тематика лего":
                            int collectionId;
                            if (int.TryParse(textBox1.Text.ToString(), out collectionId))
                                connector.DeleteCollection(collectionId);
                            else
                                throw new Exception("Неприйнятний вміст поля.");
                            break;
                        case "Вік":
                            int oldId;
                            if (int.TryParse(textBox1.Text.ToString(), out oldId))
                                connector.DeleteTarget(oldId);
                            else
                                throw new Exception("Неприйнятний вміст поля.");
                            break;
                        case "Користувач":
                            int userId;
                            if (!int.TryParse(textBox1.Text.ToString(), out userId))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.DeleteUser(userId);
                            break;
                        case "Лего набір":
                            int legoId;
                            if(!int.TryParse(textBox1.Text.ToString(), out legoId))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.DeleteConstructor(legoId);
                            break;
                        case "Лего за користувачами":
                            int userId2, legoId2;
                            if(!int.TryParse(textBox1.Text.ToString(), out userId2) || !int.TryParse(textBox2.Text.ToString(), out legoId2))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.DeleteUsersLego(userId2, legoId2);
                            break;
                    }
                }
                else
                {
                    int id;
                    switch (Таблиця.SelectedItem)
                    {
                        case "Тематика лего":
                            var text = textBox2.Text;
                            if(text.Length == 0 || !int.TryParse(textBox1.Text.ToString(), out id))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.UpdateCollection(id, text);
                            break;
                        case "Вік":
                            var text2 = textBox2.Text;
                            if (text2.Length == 0 || !int.TryParse(textBox1.Text.ToString(), out id))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.UpdateTarget(id, text2);
                            break;
                        case "Користувач":
                            var text3 = textBox2.Text;
                            var cs = 0;
                            if (radioButton3.Checked)
                                cs = 0;
                            else if (radioButton4.Checked)
                                cs = 1;
                            else
                                throw new Exception("Можна оновлювати лиш 1 параметр за раз. Виберіть його.");
                            if (text3.Length == 0 || !int.TryParse(textBox1.Text.ToString(), out id))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.UpdateUser(id, text3, cs);
                            break;
                        case "Лего набір":
                            var text4 = textBox2.Text;
                            var cs2 = 0;
                            if (radioButton3.Checked)
                                cs2 = 0;
                            else if (radioButton4.Checked)
                                cs2 = 1;
                            else if (radioButton5.Checked)
                                cs2 = 2;
                            else if (radioButton6.Checked)
                                cs2 = 3;
                            else
                                throw new Exception("Можна оновлювати лиш 1 параметр за раз. Виберіть його.");
                            if (text4.Length == 0 || !int.TryParse(textBox1.Text.ToString(), out id))
                                throw new Exception("Неприйнятний вміст поля");
                            connector.UpdateConstructor(id, text4, cs2);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
