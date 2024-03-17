namespace LibraryApplication
{
    partial class Авторизация
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 35);
            label1.TabIndex = 0;
            label1.Text = "Введите логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(202, 35);
            label2.TabIndex = 1;
            label2.Text = "Введите пароль:";
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 12F);
            loginBox.Location = new Point(12, 47);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(243, 34);
            loginBox.TabIndex = 2;
            loginBox.KeyDown += loginBox_KeyDown;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 12F);
            passwordBox.Location = new Point(12, 122);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(243, 34);
            passwordBox.TabIndex = 3;
            passwordBox.KeyDown += passwordBox_KeyDown;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(243, 44);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Авторизация
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(267, 232);
            Controls.Add(button1);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Авторизация";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button button1;
    }
}
