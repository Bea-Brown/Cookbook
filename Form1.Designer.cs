namespace CookBook
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Log = new Button();
            Register = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            email = new Label();
            Password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Log
            // 
            Log.BackColor = Color.FromArgb(255, 192, 128);
            Log.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Log.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log.Location = new Point(805, 873);
            Log.Name = "Log";
            Log.Size = new Size(228, 59);
            Log.TabIndex = 0;
            Log.Text = "Login";
            Log.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(255, 192, 128);
            Register.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.Location = new Point(1064, 873);
            Register.Name = "Register";
            Register.Size = new Size(228, 59);
            Register.TabIndex = 7;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(954, 496);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(352, 50);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(954, 595);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(352, 50);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ButtonHighlight;
            email.Location = new Point(836, 496);
            email.Name = "email";
            email.Size = new Size(121, 48);
            email.TabIndex = 10;
            email.Text = "Email:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(768, 595);
            Password.Name = "Password";
            Password.Size = new Size(189, 48);
            Password.TabIndex = 11;
            Password.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(935, 186);
            pictureBox1.Margin = new Padding(3, 3, 0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(Password);
            Controls.Add(email);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(Register);
            Controls.Add(Log);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chef's CookBook Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log;
        private Button Register;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label email;
        private Label Password;
        private PictureBox pictureBox1;
    }
}
