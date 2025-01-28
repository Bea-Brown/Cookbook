namespace CookBook
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Login = new Button();
            Register = new Button();
            email = new RichTextBox();
            Password = new RichTextBox();
            LabelEmail = new Label();
            LabelPass = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(255, 192, 128);
            Login.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(805, 873);
            Login.Name = "Login";
            Login.Size = new Size(228, 59);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
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
            // email
            // 
            email.Location = new Point(954, 496);
            email.Name = "email";
            email.Size = new Size(352, 50);
            email.TabIndex = 8;
            email.Text = "";
            // 
            // Password
            // 
            Password.Location = new Point(954, 595);
            Password.Name = "Password";
            Password.Size = new Size(352, 50);
            Password.TabIndex = 9;
            Password.Text = "";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.BackColor = Color.Transparent;
            LabelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEmail.ForeColor = SystemColors.ButtonHighlight;
            LabelEmail.Location = new Point(836, 496);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(121, 48);
            LabelEmail.TabIndex = 10;
            LabelEmail.Text = "Email:";
            // 
            // LabelPass
            // 
            LabelPass.AutoSize = true;
            LabelPass.BackColor = Color.Transparent;
            LabelPass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPass.ForeColor = SystemColors.ButtonHighlight;
            LabelPass.Location = new Point(768, 595);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(189, 48);
            LabelPass.TabIndex = 11;
            LabelPass.Text = "Password:";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(LabelPass);
            Controls.Add(LabelEmail);
            Controls.Add(Password);
            Controls.Add(email);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chef's CookBook Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Button Register;
        private RichTextBox email;
        private RichTextBox Password;
        private Label LabelEmail;
        private Label LabelPass;
        private PictureBox pictureBox1;
    }
}
