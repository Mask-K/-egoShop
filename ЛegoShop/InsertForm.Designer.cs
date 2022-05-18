namespace ЛegoShop
{
    partial class InsertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Таблиця = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Таблиця
            // 
            this.Таблиця.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Таблиця.FormattingEnabled = true;
            this.Таблиця.Items.AddRange(new object[] {
            "Користувач",
            "Лего набір",
            "Тематика лего",
            "Лего за користувачами",
            "Вік"});
            this.Таблиця.Location = new System.Drawing.Point(31, 66);
            this.Таблиця.Name = "Таблиця";
            this.Таблиця.Size = new System.Drawing.Size(182, 24);
            this.Таблиця.TabIndex = 0;
            this.Таблиця.SelectedIndexChanged += new System.EventHandler(this.Таблиця_SelectedIndexChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(31, 122);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(179, 46);
            this.Close.TabIndex = 1;
            this.Close.Text = "Повернутися до меню";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Оберіть таблицю, в яку хочете додавати";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(424, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Visible = false;
            // 
            // AddItem
            // 
            this.AddItem.Enabled = false;
            this.AddItem.Location = new System.Drawing.Point(609, 54);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(179, 46);
            this.AddItem.TabIndex = 11;
            this.AddItem.Text = "Затвердити";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(609, 122);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(179, 46);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Очистити";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 191);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Таблиця);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Таблиця;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button Clear;
    }
}