namespace CookBook
{
    partial class Recipepage
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
            RecipeDisplay = new RichTextBox();
            back = new Button();
            Delete = new Button();
            edit = new Button();
            SuspendLayout();
            // 
            // RecipeDisplay
            // 
            RecipeDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecipeDisplay.Location = new Point(278, 12);
            RecipeDisplay.Name = "RecipeDisplay";
            RecipeDisplay.Size = new Size(1530, 1057);
            RecipeDisplay.TabIndex = 0;
            RecipeDisplay.Text = "";
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 128);
            back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(12, 488);
            back.Name = "back";
            back.Size = new Size(228, 59);
            back.TabIndex = 3;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(255, 192, 128);
            Delete.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(1843, 488);
            Delete.Name = "Delete";
            Delete.Size = new Size(228, 59);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 192, 128);
            edit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit.Location = new Point(1843, 599);
            edit.Name = "edit";
            edit.Size = new Size(228, 59);
            edit.TabIndex = 5;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            // 
            // Recipepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(edit);
            Controls.Add(Delete);
            Controls.Add(back);
            Controls.Add(RecipeDisplay);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Recipepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RecipeDisplay;
        private Button back;
        private Button Delete;
        private Button edit;
    }
}