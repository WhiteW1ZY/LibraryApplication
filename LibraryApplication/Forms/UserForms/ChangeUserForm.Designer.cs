namespace LibraryApplication
{
    partial class ChangeUserForm
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
            UserPasswordBox = new TextBox();
            label3 = new Label();
            UserNameText = new TextBox();
            label2 = new Label();
            label1 = new Label();
            IdBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 270);
            button2.Name = "button2";
            button2.Size = new Size(66, 46);
            button2.TabIndex = 14;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 270);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 13;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserPasswordBox
            // 
            UserPasswordBox.Location = new Point(12, 207);
            UserPasswordBox.Name = "UserPasswordBox";
            UserPasswordBox.Size = new Size(233, 41);
            UserPasswordBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(107, 35);
            label3.TabIndex = 11;
            label3.Text = "Пароль:";
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(12, 125);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(233, 41);
            UserNameText.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(233, 35);
            label2.TabIndex = 9;
            label2.Text = "Имя пользователя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // IdBox
            // 
            IdBox.Enabled = false;
            IdBox.Location = new Point(12, 43);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(233, 41);
            IdBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 5);
            label4.Name = "label4";
            label4.Size = new Size(40, 35);
            label4.TabIndex = 16;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 5);
            label5.Name = "label5";
            label5.Size = new Size(81, 35);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // ChangeUserForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(257, 332);
            Controls.Add(IdBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserPasswordBox);
            Controls.Add(label3);
            Controls.Add(UserNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "ChangeUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать пользователя";
            Load += ChangeUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox UserPasswordBox;
        private Label label3;
        private TextBox UserNameText;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        public TextBox IdBox;
    }
}