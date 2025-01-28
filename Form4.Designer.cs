namespace CookBook
{
    partial class Myrecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myrecipes));
            label1 = new Label();
            Recipelist = new ListBox();
            Back = new Button();
            View = new Button();
            NewRecipe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Freestyle Script", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(521, 170);
            label1.TabIndex = 0;
            label1.Text = "My Recipes";
            // 
            // Recipelist
            // 
            Recipelist.BackColor = Color.Tan;
            Recipelist.FormattingEnabled = true;
            Recipelist.ItemHeight = 25;
            Recipelist.Location = new Point(251, 207);
            Recipelist.Name = "Recipelist";
            Recipelist.Size = new Size(1525, 704);
            Recipelist.TabIndex = 1;
            Recipelist.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 192, 128);
            Back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(12, 501);
            Back.Name = "Back";
            Back.Size = new Size(228, 59);
            Back.TabIndex = 2;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            View.BackColor = Color.Transparent;
            View.BackgroundImage = (Image)resources.GetObject("View.BackgroundImage");
            View.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            View.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View.Location = new Point(1068, 957);
            View.Name = "View";
            View.Size = new Size(256, 75);
            View.TabIndex = 8;
            View.Text = "View";
            View.UseVisualStyleBackColor = false;
            // 
            // NewRecipe
            // 
            NewRecipe.BackColor = Color.Transparent;
            NewRecipe.BackgroundImage = (Image)resources.GetObject("NewRecipe.BackgroundImage");
            NewRecipe.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            NewRecipe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewRecipe.Location = new Point(646, 957);
            NewRecipe.Name = "NewRecipe";
            NewRecipe.Size = new Size(256, 75);
            NewRecipe.TabIndex = 9;
            NewRecipe.Text = "New Recipe";
            NewRecipe.UseVisualStyleBackColor = false;
            // 
            // Myrecipes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.board;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(NewRecipe);
            Controls.Add(View);
            Controls.Add(Back);
            Controls.Add(Recipelist);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Myrecipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Myrecipes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Recipelist;
        private Button Back;
        private Button View;
        private Button NewRecipe;
    }
}