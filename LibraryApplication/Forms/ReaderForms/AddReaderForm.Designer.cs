namespace LibraryApplication.Forms.ReaderForms
{
    partial class AddReaderForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(11, 327);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(92, 64);
            button2.TabIndex = 19;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 327);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(225, 64);
            button1.TabIndex = 18;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameText
            // 
            NameText.Location = new Point(13, 60);
            NameText.Margin = new Padding(4);
            NameText.Name = "NameText";
            NameText.Size = new Size(325, 41);
            NameText.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 35);
            label2.TabIndex = 16;
            label2.Text = "Имя читателя:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 154);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 41);
            textBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 35);
            label1.TabIndex = 20;
            label1.Text = "Фамилия читателя:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 254);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 41);
            textBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(13, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 35);
            label3.TabIndex = 22;
            label3.Text = "Номер паспорта:";
            // 
            // AddReaderForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(360, 411);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NameText);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6);
            Name = "AddReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить читателя";
            Load += AddReaderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox NameText;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
    }
}