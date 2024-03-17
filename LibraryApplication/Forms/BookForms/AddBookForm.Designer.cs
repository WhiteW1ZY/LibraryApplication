namespace LibraryApplication.Forms.BookForms
{
    partial class AddBookForm
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
            button2 = new Button();
            button1 = new Button();
            NameText = new TextBox();
            label2 = new Label();
            authorText = new TextBox();
            label1 = new Label();
            yearText = new TextBox();
            label3 = new Label();
            countText = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            listBox2 = new ListBox();
            label7 = new Label();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(20, 405);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(324, 64);
            button2.TabIndex = 23;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 405);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(714, 64);
            button1.TabIndex = 22;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameText
            // 
            NameText.Location = new Point(20, 54);
            NameText.Margin = new Padding(4);
            NameText.Name = "NameText";
            NameText.Size = new Size(325, 41);
            NameText.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(20, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 35);
            label2.TabIndex = 20;
            label2.Text = "Название книги";
            // 
            // authorText
            // 
            authorText.Location = new Point(20, 151);
            authorText.Margin = new Padding(4);
            authorText.Name = "authorText";
            authorText.Size = new Size(325, 41);
            authorText.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(20, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 35);
            label1.TabIndex = 24;
            label1.Text = "Автор книги";
            // 
            // yearText
            // 
            yearText.Location = new Point(20, 347);
            yearText.Margin = new Padding(4);
            yearText.Name = "yearText";
            yearText.Size = new Size(325, 41);
            yearText.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(20, 301);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 35);
            label3.TabIndex = 28;
            label3.Text = "Дата публикации";
            // 
            // countText
            // 
            countText.Location = new Point(20, 247);
            countText.Margin = new Padding(4);
            countText.Name = "countText";
            countText.Size = new Size(325, 41);
            countText.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(20, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(208, 35);
            label4.TabIndex = 26;
            label4.Text = "Количество книг";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(352, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(233, 344);
            listBox1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(352, 8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 35);
            label5.TabIndex = 31;
            label5.Text = "Жанры";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(591, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 35);
            label6.TabIndex = 33;
            label6.Text = "Издатели";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 9F);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(591, 54);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(233, 344);
            listBox2.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(830, 8);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 35);
            label7.TabIndex = 35;
            label7.Text = "Читатели";
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 9F);
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(830, 54);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(233, 344);
            listBox3.TabIndex = 34;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1079, 479);
            Controls.Add(label7);
            Controls.Add(listBox3);
            Controls.Add(label6);
            Controls.Add(listBox2);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(yearText);
            Controls.Add(label3);
            Controls.Add(countText);
            Controls.Add(label4);
            Controls.Add(authorText);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NameText);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить книгу";
            Load += AddBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox NameText;
        private Label label2;
        private TextBox authorText;
        private Label label1;
        private TextBox yearText;
        private Label label3;
        private TextBox countText;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private ListBox listBox2;
        private Label label7;
        private ListBox listBox3;
    }
}