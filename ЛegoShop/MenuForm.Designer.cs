namespace ЛegoShop
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.шоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додаванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видаленняоновленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вмістТаблицьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершенняРоботиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шоToolStripMenuItem,
            this.запитиToolStripMenuItem,
            this.додаванняToolStripMenuItem,
            this.видаленняоновленняToolStripMenuItem,
            this.вмістТаблицьToolStripMenuItem,
            this.завершенняРоботиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // шоToolStripMenuItem
            // 
            this.шоToolStripMenuItem.Name = "шоToolStripMenuItem";
            this.шоToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.шоToolStripMenuItem.Text = "Програма";
            this.шоToolStripMenuItem.Click += new System.EventHandler(this.шоToolStripMenuItem_Click);
            // 
            // запитиToolStripMenuItem
            // 
            this.запитиToolStripMenuItem.Name = "запитиToolStripMenuItem";
            this.запитиToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.запитиToolStripMenuItem.Text = "Запити";
            this.запитиToolStripMenuItem.Click += new System.EventHandler(this.запитиToolStripMenuItem_Click);
            // 
            // додаванняToolStripMenuItem
            // 
            this.додаванняToolStripMenuItem.Name = "додаванняToolStripMenuItem";
            this.додаванняToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.додаванняToolStripMenuItem.Text = "Додавання";
            this.додаванняToolStripMenuItem.Click += new System.EventHandler(this.додаванняToolStripMenuItem_Click);
            // 
            // видаленняоновленняToolStripMenuItem
            // 
            this.видаленняоновленняToolStripMenuItem.Name = "видаленняоновленняToolStripMenuItem";
            this.видаленняоновленняToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.видаленняоновленняToolStripMenuItem.Text = "Видалення/оновлення";
            this.видаленняоновленняToolStripMenuItem.Click += new System.EventHandler(this.видаленняоновленняToolStripMenuItem_Click);
            // 
            // вмістТаблицьToolStripMenuItem
            // 
            this.вмістТаблицьToolStripMenuItem.Name = "вмістТаблицьToolStripMenuItem";
            this.вмістТаблицьToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.вмістТаблицьToolStripMenuItem.Text = "Вміст таблиць";
            this.вмістТаблицьToolStripMenuItem.Click += new System.EventHandler(this.вмістТаблицьToolStripMenuItem_Click);
            // 
            // завершенняРоботиToolStripMenuItem
            // 
            this.завершенняРоботиToolStripMenuItem.Name = "завершенняРоботиToolStripMenuItem";
            this.завершенняРоботиToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.завершенняРоботиToolStripMenuItem.Text = "Завершення роботи";
            this.завершенняРоботиToolStripMenuItem.Click += new System.EventHandler(this.завершенняРоботиToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 27);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem шоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додаванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видаленняоновленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вмістТаблицьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершенняРоботиToolStripMenuItem;
    }
}

