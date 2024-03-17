namespace LibraryApplication.Forms.PublisherForms
{
    partial class ChangePublisherForm
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
            IdBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            UserNameText = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // IdBox
            // 
            IdBox.Enabled = false;
            IdBox.Location = new Point(12, 42);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(233, 41);
            IdBox.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 4);
            label4.Name = "label4";
            label4.Size = new Size(40, 35);
            label4.TabIndex = 34;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 4);
            label5.Name = "label5";
            label5.Size = new Size(81, 35);
            label5.TabIndex = 33;
            label5.Text = "label5";
            // 
            // button2
            // 
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(66, 46);
            button2.TabIndex = 32;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 162);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 31;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserNameText
            // 
            UserNameText.Location = new Point(12, 115);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(233, 41);
            UserNameText.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(206, 35);
            label2.TabIndex = 29;
            label2.Text = "Название жанра";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 28;
            label1.Text = "label1";
            // 
            // ChangePublisherForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(257, 218);
            Controls.Add(IdBox);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "ChangePublisherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить издателя";
            Load += ChangePublisherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox IdBox;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox UserNameText;
        private Label label2;
        private Label label1;
    }
}