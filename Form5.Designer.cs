namespace CookBook
{
    partial class Form5
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            email = new Label();
            Register2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.AntiqueWhite;
            richTextBox1.Location = new Point(852, 153);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(576, 60);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.AntiqueWhite;
            richTextBox2.Location = new Point(552, 234);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1064, 739);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.FromArgb(64, 0, 0);
            email.Location = new Point(716, 153);
            email.Name = "email";
            email.Size = new Size(130, 60);
            email.TabIndex = 12;
            email.Text = "Title:";
            // 
            // Register2
            // 
            Register2.BackColor = Color.FromArgb(255, 192, 128);
            Register2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register2.Location = new Point(1144, 994);
            Register2.Name = "Register2";
            Register2.Size = new Size(228, 59);
            Register2.TabIndex = 13;
            Register2.Text = "Submit";
            Register2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(791, 994);
            button1.Name = "button1";
            button1.Size = new Size(228, 59);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(button1);
            Controls.Add(Register2);
            Controls.Add(email);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label email;
        private Button Register2;
        private Button button1;
    }
}