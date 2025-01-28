namespace CookBook
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Register2 = new Button();
            Cancel = new Button();
            password = new RichTextBox();
            email = new RichTextBox();
            name = new RichTextBox();
            labelemail = new Label();
            labelname = new Label();
            labelpass = new Label();
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
            // password
            // 
            password.Location = new Point(993, 577);
            password.Name = "password";
            password.Size = new Size(352, 50);
            password.TabIndex = 9;
            password.Text = "";
            // 
            // email
            // 
            email.Location = new Point(993, 455);
            email.Name = "email";
            email.Size = new Size(352, 50);
            email.TabIndex = 10;
            email.Text = "";
            // 
            // name
            // 
            name.Location = new Point(993, 323);
            name.Name = "name";
            name.Size = new Size(352, 50);
            name.TabIndex = 11;
            name.Text = "";
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.BackColor = Color.Transparent;
            labelemail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelemail.ForeColor = SystemColors.ActiveCaptionText;
            labelemail.Location = new Point(833, 457);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(121, 48);
            labelemail.TabIndex = 12;
            labelemail.Text = "Email:";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.BackColor = Color.Transparent;
            labelname.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelname.ForeColor = SystemColors.ActiveCaptionText;
            labelname.Location = new Point(825, 325);
            labelname.Name = "labelname";
            labelname.Size = new Size(129, 48);
            labelname.TabIndex = 13;
            labelname.Text = "Name:";
            labelname.Click += label1_Click;
            // 
            // labelpass
            // 
            labelpass.AutoSize = true;
            labelpass.BackColor = Color.Transparent;
            labelpass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelpass.ForeColor = SystemColors.ActiveCaptionText;
            labelpass.Location = new Point(765, 579);
            labelpass.Name = "labelpass";
            labelpass.Size = new Size(189, 48);
            labelpass.TabIndex = 14;
            labelpass.Text = "Password:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2083, 1106);
            Controls.Add(labelpass);
            Controls.Add(labelname);
            Controls.Add(labelemail);
            Controls.Add(name);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(Cancel);
            Controls.Add(Register2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Register2;
        private Button Cancel;
        private RichTextBox password;
        private RichTextBox email;
        private RichTextBox name;
        private Label labelemail;
        private Label labelname;
        private Label labelpass;
    }
}