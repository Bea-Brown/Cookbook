namespace CookBook
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Register2 = new Button();
            Cancel = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            email = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Register2
            // 
            Register2.BackColor = Color.FromArgb(255, 192, 128);
            Register2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register2.Location = new Point(947, 809);
            Register2.Name = "Register2";
            Register2.Size = new Size(228, 59);
            Register2.TabIndex = 1;
            Register2.Text = "Register";
            Register2.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(255, 192, 128);
            Cancel.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(947, 906);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(228, 59);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(993, 577);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(352, 50);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(993, 455);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(352, 50);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(993, 323);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(352, 50);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ActiveCaptionText;
            email.Location = new Point(833, 457);
            email.Name = "email";
            email.Size = new Size(121, 48);
            email.TabIndex = 12;
            email.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(825, 325);
            label1.Name = "label1";
            label1.Size = new Size(129, 48);
            label1.TabIndex = 13;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(765, 579);
            label2.Name = "label2";
            label2.Size = new Size(189, 48);
            label2.TabIndex = 14;
            label2.Text = "Password:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2083, 1106);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(email);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(Cancel);
            Controls.Add(Register2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Register2;
        private Button Cancel;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label email;
        private Label label1;
        private Label label2;
    }
}