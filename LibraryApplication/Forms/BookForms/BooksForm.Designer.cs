namespace LibraryApplication.Forms.BookForms
{
    partial class BooksForm
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
            button6 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F);
            button6.Location = new Point(430, 405);
            button6.Name = "button6";
            button6.Size = new Size(200, 44);
            button6.TabIndex = 13;
            button6.Text = "Excel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 405);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 41);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(428, 452);
            button4.Name = "button4";
            button4.Size = new Size(202, 44);
            button4.TabIndex = 11;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(144, 452);
            button3.Name = "button3";
            button3.Size = new Size(128, 44);
            button3.TabIndex = 10;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(278, 452);
            button2.Name = "button2";
            button2.Size = new Size(144, 44);
            button2.TabIndex = 9;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1167, 372);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 452);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 7;
            button1.Text = "Меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(650, 405);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 14;
            label1.Text = "Сортировать";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F);
            button5.Location = new Point(1127, 405);
            button5.Name = "button5";
            button5.Size = new Size(50, 41);
            button5.TabIndex = 15;
            button5.Text = "id";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10F);
            button7.Location = new Point(1044, 405);
            button7.Name = "button7";
            button7.Size = new Size(77, 41);
            button7.TabIndex = 16;
            button7.Text = "Автор";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10F);
            button8.Location = new Point(933, 405);
            button8.Name = "button8";
            button8.Size = new Size(105, 41);
            button8.TabIndex = 17;
            button8.Text = "Название";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10F);
            button9.Location = new Point(1010, 452);
            button9.Name = "button9";
            button9.Size = new Size(167, 43);
            button9.TabIndex = 18;
            button9.Text = "Дата публикации";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 10F);
            button10.Location = new Point(851, 452);
            button10.Name = "button10";
            button10.Size = new Size(153, 43);
            button10.TabIndex = 19;
            button10.Text = "Количество книг";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 10F);
            button11.Location = new Point(769, 452);
            button11.Name = "button11";
            button11.Size = new Size(76, 43);
            button11.TabIndex = 20;
            button11.Text = "Жанры";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 10F);
            button12.Location = new Point(661, 452);
            button12.Name = "button12";
            button12.Size = new Size(102, 43);
            button12.TabIndex = 21;
            button12.Text = "Издатели";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 10F);
            button13.Location = new Point(820, 405);
            button13.Name = "button13";
            button13.Size = new Size(107, 41);
            button13.TabIndex = 22;
            button13.Text = "Читатели";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1189, 507);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "BooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Книги";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}