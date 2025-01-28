namespace CookBook
{
    partial class Form6
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
            Register2 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(278, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1530, 1057);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Register2
            // 
            Register2.BackColor = Color.FromArgb(255, 192, 128);
            Register2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register2.Location = new Point(12, 488);
            Register2.Name = "Register2";
            Register2.Size = new Size(228, 59);
            Register2.TabIndex = 3;
            Register2.Text = "Back";
            Register2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1843, 488);
            button1.Name = "button1";
            button1.Size = new Size(228, 59);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1843, 599);
            button2.Name = "button2";
            button2.Size = new Size(228, 59);
            button2.TabIndex = 5;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Register2);
            Controls.Add(richTextBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Register2;
        private Button button1;
        private Button button2;
    }
}