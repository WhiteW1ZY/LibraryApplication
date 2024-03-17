namespace LibraryApplication.Forms.PublisherForms
{
    partial class AddPublisherForm
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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(13, 108);
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
            button1.Location = new Point(114, 108);
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
            NameText.Location = new Point(13, 55);
            NameText.Margin = new Padding(4);
            NameText.Name = "NameText";
            NameText.Size = new Size(325, 41);
            NameText.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 35);
            label2.TabIndex = 16;
            label2.Text = "Имя издателя";
            // 
            // AddPublisherForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(355, 183);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NameText);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5);
            Name = "AddPublisherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить издателя";
            Load += AddPublisherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox NameText;
        private Label label2;
    }
}