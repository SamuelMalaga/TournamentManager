namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            priceAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = SystemColors.MenuHighlight;
            createPrizeLabel.Location = new Point(12, 18);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(209, 50);
            createPrizeLabel.TabIndex = 26;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(230, 83);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(159, 35);
            placeNumberValue.TabIndex = 28;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(12, 129);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(157, 37);
            placeNumberLabel.TabIndex = 27;
            placeNumberLabel.Text = "Place Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(230, 132);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(159, 35);
            placeNameValue.TabIndex = 30;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(12, 182);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(176, 37);
            placeNameLabel.TabIndex = 29;
            placeNameLabel.Text = "Prize Amount";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(230, 185);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(159, 35);
            prizeAmountValue.TabIndex = 32;
            prizeAmountValue.Text = "0";
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceAmountLabel.ForeColor = SystemColors.MenuHighlight;
            priceAmountLabel.Location = new Point(12, 80);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(183, 37);
            priceAmountLabel.TabIndex = 31;
            priceAmountLabel.Text = "Place Number";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(230, 274);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(159, 35);
            prizePercentageValue.TabIndex = 34;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(12, 271);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 33;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(153, 234);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(68, 37);
            orLabel.TabIndex = 35;
            orLabel.Text = "-Or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(78, 347);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(284, 46);
            createPrizeButton.TabIndex = 36;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 452);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label priceAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}