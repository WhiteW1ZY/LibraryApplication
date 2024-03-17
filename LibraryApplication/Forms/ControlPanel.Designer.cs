namespace LibraryApplication
{
    partial class ControlPanel
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(12, 169);
            button1.Name = "button1";
            button1.Size = new Size(211, 46);
            button1.TabIndex = 0;
            button1.Text = "Выйти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(211, 46);
            button2.TabIndex = 1;
            button2.Text = "Пользователи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(229, 12);
            button3.Name = "button3";
            button3.Size = new Size(211, 46);
            button3.TabIndex = 2;
            button3.Text = "Издатели";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F);
            button4.Location = new Point(229, 64);
            button4.Name = "button4";
            button4.Size = new Size(211, 46);
            button4.TabIndex = 3;
            button4.Text = "Жанры";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13F);
            button5.Location = new Point(12, 64);
            button5.Name = "button5";
            button5.Size = new Size(211, 46);
            button5.TabIndex = 4;
            button5.Text = "Книги";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13F);
            button6.Location = new Point(229, 116);
            button6.Name = "button6";
            button6.Size = new Size(211, 46);
            button6.TabIndex = 5;
            button6.Text = "Читатели";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(448, 223);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ControlPanel";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            Load += ControlPanel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}