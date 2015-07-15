namespace WindowCassier
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MONITOR = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Choise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.Entry = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MONITOR
            // 
            this.MONITOR.BackColor = System.Drawing.Color.DarkGray;
            this.MONITOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MONITOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MONITOR.ForeColor = System.Drawing.Color.DarkBlue;
            this.MONITOR.FormattingEnabled = true;
            this.MONITOR.ItemHeight = 16;
            this.MONITOR.Location = new System.Drawing.Point(353, 9);
            this.MONITOR.Name = "MONITOR";
            this.MONITOR.Size = new System.Drawing.Size(192, 256);
            this.MONITOR.TabIndex = 0;
            this.MONITOR.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(151, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD ITEM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchasing Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choise
            // 
            this.Choise.BackColor = System.Drawing.SystemColors.Control;
            this.Choise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Choise.ForeColor = System.Drawing.Color.DarkBlue;
            this.Choise.Location = new System.Drawing.Point(15, 50);
            this.Choise.Multiline = true;
            this.Choise.Name = "Choise";
            this.Choise.Size = new System.Drawing.Size(119, 23);
            this.Choise.TabIndex = 3;
            this.Choise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(353, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 50);
            this.label2.TabIndex = 4;
            // 
            // Bonus
            // 
            this.Bonus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bonus.ForeColor = System.Drawing.Color.DarkBlue;
            this.Bonus.Location = new System.Drawing.Point(15, 79);
            this.Bonus.Multiline = true;
            this.Bonus.Name = "Bonus";
            this.Bonus.PasswordChar = '*';
            this.Bonus.Size = new System.Drawing.Size(119, 27);
            this.Bonus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(140, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount ActivateKey";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.Color.DarkBlue;
            this.Login.Location = new System.Drawing.Point(72, 279);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.Color.DarkBlue;
            this.Password.Location = new System.Drawing.Point(72, 305);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Login";
            // 
            // Buy
            // 
            this.Buy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Buy.ForeColor = System.Drawing.Color.DarkBlue;
            this.Buy.Location = new System.Drawing.Point(12, 129);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(75, 28);
            this.Buy.TabIndex = 12;
            this.Buy.Text = "BUY";
            this.Buy.UseVisualStyleBackColor = false;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Entry.ForeColor = System.Drawing.Color.DarkBlue;
            this.Entry.Location = new System.Drawing.Point(178, 303);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(75, 23);
            this.Entry.TabIndex = 13;
            this.Entry.Text = "LOG_ON";
            this.Entry.UseMnemonic = false;
            this.Entry.UseVisualStyleBackColor = false;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Acces in System";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Print.ForeColor = System.Drawing.Color.DarkBlue;
            this.Print.Location = new System.Drawing.Point(162, 129);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 28);
            this.Print.TabIndex = 15;
            this.Print.Text = "PRINT";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.DarkBlue;
            this.Exit.Location = new System.Drawing.Point(519, 346);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 21);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 369);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MONITOR);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CassierWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MONITOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Choise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Exit;

    }
}

