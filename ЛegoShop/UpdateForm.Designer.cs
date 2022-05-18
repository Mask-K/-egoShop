namespace ЛegoShop
{
    partial class UpdateForm
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
            this.Clear = new System.Windows.Forms.Button();
            this.Complete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Таблиця = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(593, 118);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(179, 46);
            this.Clear.TabIndex = 25;
            this.Clear.Text = "Очистити";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Complete
            // 
            this.Complete.Enabled = false;
            this.Complete.Location = new System.Drawing.Point(593, 50);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(179, 46);
            this.Complete.TabIndex = 24;
            this.Complete.Text = "Затвердити";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Оберіть таблицю";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Айді";
            this.label1.Visible = false;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(15, 118);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(179, 46);
            this.Close.TabIndex = 14;
            this.Close.Text = "Повернутися до меню";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            this.Таблиця.Location = new System.Drawing.Point(15, 62);
            this.Таблиця.Name = "Таблиця";
            this.Таблиця.Size = new System.Drawing.Size(182, 24);
            this.Таблиця.TabIndex = 13;
            this.Таблиця.SelectedIndexChanged += new System.EventHandler(this.Таблиця_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(18, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Оновити";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(110, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 20);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Видалити";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(250, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(250, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(250, 123);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 20);
            this.radioButton5.TabIndex = 30;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(250, 149);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(103, 20);
            this.radioButton6.TabIndex = 31;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 32;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(575, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Таблиця);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox Таблиця;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}