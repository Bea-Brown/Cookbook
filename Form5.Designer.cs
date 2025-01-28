namespace CookBook
{
    partial class Newrecipe
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
            Title = new RichTextBox();
            Content = new RichTextBox();
            labeltitle = new Label();
            submit = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BackColor = Color.AntiqueWhite;
            Title.Location = new Point(852, 153);
            Title.Name = "Title";
            Title.Size = new Size(576, 60);
            Title.TabIndex = 9;
            Title.Text = "";
            // 
            // Content
            // 
            Content.BackColor = Color.AntiqueWhite;
            Content.Location = new Point(552, 234);
            Content.Name = "Content";
            Content.Size = new Size(1064, 739);
            Content.TabIndex = 10;
            Content.Text = "";
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.BackColor = Color.Transparent;
            labeltitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitle.ForeColor = Color.FromArgb(64, 0, 0);
            labeltitle.Location = new Point(716, 153);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(130, 60);
            labeltitle.TabIndex = 12;
            labeltitle.Text = "Title:";
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(255, 192, 128);
            submit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit.Location = new Point(1144, 994);
            submit.Name = "submit";
            submit.Size = new Size(228, 59);
            submit.TabIndex = 13;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 128);
            back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(791, 994);
            back.Name = "back";
            back.Size = new Size(228, 59);
            back.TabIndex = 14;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            // 
            // Newrecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(back);
            Controls.Add(submit);
            Controls.Add(labeltitle);
            Controls.Add(Content);
            Controls.Add(Title);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Newrecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Title;
        private RichTextBox Content;
        private Label labeltitle;
        private Button submit;
        private Button back;
    }
}