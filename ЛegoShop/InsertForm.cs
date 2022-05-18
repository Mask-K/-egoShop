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
    
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void Таблиця_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Таблиця.SelectedIndex != -1)
            {
                label5.Text = "Впишіть необхідну інформацію для вставки";
                AddItem.Enabled = true;
            }
            if (Таблиця.SelectedItem == "Користувач")
            {
                label1.Text = "Нікнейм";
                label2.Text = "Пошта";
                textBox1.Text = "";
                textBox2.Text = "";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if(Таблиця.SelectedItem == "Лего набір")
            {
                label1.Text = "Назва";
                label2.Text = "Айді аудиторії";
                label3.Text = "Ціна";
                label4.Text = "Айді тематики";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            else if(Таблиця.SelectedItem == "Тематика лего")
            {
                label1.Text = "Назва";
                textBox1.Text = "";
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;

            }
            else if(Таблиця.SelectedItem == "Вік")
            {
                label1.Text = "Аудиторія";
                textBox1.Text = "";
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if(Таблиця.SelectedItem == "Лего за користувачами")
            {
                label1.Text = "Айді користувача";
                label2.Text = "Айді набору";
                textBox1.Text = "";
                textBox2.Text = "";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                var connector = new DataBase();
                switch (Таблиця.SelectedItem)
                {
                    case "Тематика лего":
                        var collectionName = textBox1.Text;
                        if (collectionName.Length > 0)
                            connector.InsertCollection(collectionName);
                        else
                            throw new Exception("Поле не було заповнене");
                        break;
                    case "Вік":
                        var text = textBox1.Text;
                        if (text.Length > 0)
                            connector.InsertTarget(text);
                        else
                            throw new Exception("Поле не було заповнене");
                        break;
                    case "Користувач":
                        var userName = textBox1.Text;
                        var email = textBox2.Text;
                        if(userName.Length * email.Length == 0)
                            throw new Exception("Не всі поля були заповнені");
                        connector.InsertUser(userName, email);
                        break;
                    case "Лего набір":
                        var legoName = textBox1.Text;
                        int targetId, collectionId;
                        double price;
                        if(!int.TryParse(textBox2.Text.ToString(), out targetId) ||
                            !double.TryParse(textBox3.Text.ToString(), out price) ||
                            !int.TryParse(textBox4.Text.ToString(), out collectionId) || legoName.Length == 0 || 
                            price >= 100000 || price <= 0)
                        {
                            throw new Exception("Некоректний тип даних, якесь з полів було пустим або неприйнятна ціна");
                        }
                        connector.InsertLego(legoName, targetId, price, collectionId);

                        break;
                    case "Лего за користувачами":
                        int legoId, userId;
                        if(!int.TryParse(textBox1.Text.ToString(), out userId) || !int.TryParse(textBox2.Text.ToString(), out legoId))
                            throw new Exception("Некоректний тип даних або якесь з полів було пустим");
                        connector.InsertUsersLego(userId, legoId);
                        break;
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
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            Таблиця.SelectedIndex = -1;
            AddItem.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label5.Text = "Впишіть необхідну інформацію для вставки";

        }
    }
}
