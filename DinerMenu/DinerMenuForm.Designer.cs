namespace DinerMenu
{
    partial class DinerMenuForm
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
            SaladButton = new Button();
            SoupButton = new Button();
            FishButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(205, 344);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(130, 70);
            SaladButton.TabIndex = 1;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(69, 344);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(130, 70);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(341, 344);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(130, 70);
            FishButton.TabIndex = 2;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(603, 344);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 70);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 90);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // DinerMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SoupButton);
            Controls.Add(SaladButton);
            Name = "DinerMenuForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaladButton;
        private Button SoupButton;
        private Button FishButton;
        private Button ExitButton;
        private Label label1;
    }
}
