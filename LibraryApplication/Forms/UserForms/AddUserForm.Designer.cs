namespace LibraryApplication
{
    partial class AddUserForm
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
            label1 = new Label();
            UserNameText = new TextBox();
            label2 = new Label();
            UserPasswordBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(12, 47);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(233, 41);
            UserNameText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(233, 35);
            label2.TabIndex = 2;
            label2.Text = "Имя пользователя:";
            // 
            // UserPasswordBox
            // 
            UserPasswordBox.Location = new Point(12, 129);
            UserPasswordBox.Name = "UserPasswordBox";
            UserPasswordBox.Size = new Size(233, 41);
            UserPasswordBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(107, 35);
            label3.TabIndex = 4;
            label3.Text = "Пароль:";
            // 
            // button1
            // 
            button1.Location = new Point(84, 192);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 192);
            button2.Name = "button2";
            button2.Size = new Size(66, 46);
            button2.TabIndex = 7;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(261, 250);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserPasswordBox);
            Controls.Add(label3);
            Controls.Add(UserNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить пользователя";
            Load += AddUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserNameText;
        private Label label2;
        private TextBox UserPasswordBox;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}