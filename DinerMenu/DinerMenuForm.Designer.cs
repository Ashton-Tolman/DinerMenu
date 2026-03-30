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
            DinerTopLabel = new Label();
            DinerSpecialsLabel = new Label();
            SuspendLayout();
            // 
            // SaladButton
            // 
            SaladButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaladButton.Location = new Point(205, 344);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(130, 70);
            SaladButton.TabIndex = 1;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            SaladButton.Click += SaladButton_Click;
            // 
            // SoupButton
            // 
            SoupButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoupButton.Location = new Point(69, 344);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(130, 70);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // FishButton
            // 
            FishButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FishButton.Location = new Point(341, 344);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(130, 70);
            FishButton.TabIndex = 2;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(603, 344);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(130, 70);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DinerTopLabel
            // 
            DinerTopLabel.AutoSize = true;
            DinerTopLabel.Font = new Font("Stencil", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            DinerTopLabel.Location = new Point(175, 9);
            DinerTopLabel.Name = "DinerTopLabel";
            DinerTopLabel.Size = new Size(379, 38);
            DinerTopLabel.TabIndex = 4;
            DinerTopLabel.Text = "RoboCop's Robo Stop";
            // 
            // DinerSpecialsLabel
            // 
            DinerSpecialsLabel.AutoSize = true;
            DinerSpecialsLabel.Location = new Point(305, 66);
            DinerSpecialsLabel.Name = "DinerSpecialsLabel";
            DinerSpecialsLabel.Size = new Size(117, 25);
            DinerSpecialsLabel.TabIndex = 5;
            DinerSpecialsLabel.Text = "DinerSpecials";
            // 
            // DinerMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DinerSpecialsLabel);
            Controls.Add(DinerTopLabel);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SoupButton);
            Controls.Add(SaladButton);
            Name = "DinerMenuForm";
            Text = "Robo cop's Diner Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaladButton;
        private Button SoupButton;
        private Button FishButton;
        private Button ExitButton;
        private Label DinerTopLabel;
        private Label DinerSpecialsLabel;
    }
}
