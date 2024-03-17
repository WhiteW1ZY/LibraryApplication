namespace LibraryApplication.Forms.GenreForms
{
    partial class GenresForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F);
            button6.Location = new Point(397, 232);
            button6.Name = "button6";
            button6.Size = new Size(200, 55);
            button6.TabIndex = 13;
            button6.Text = "Excel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(12, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 41);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(397, 12);
            button4.Name = "button4";
            button4.Size = new Size(202, 55);
            button4.TabIndex = 11;
            button4.Text = "Редактировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(397, 134);
            button3.Name = "button3";
            button3.Size = new Size(200, 55);
            button3.TabIndex = 10;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(397, 73);
            button2.Name = "button2";
            button2.Size = new Size(202, 55);
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
            dataGridView1.Size = new Size(370, 282);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(397, 293);
            button1.Name = "button1";
            button1.Size = new Size(200, 55);
            button1.TabIndex = 7;
            button1.Text = "Меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GenresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(606, 358);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "GenresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Жанры";
            Load += GenresForm_Load;
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
    }
}