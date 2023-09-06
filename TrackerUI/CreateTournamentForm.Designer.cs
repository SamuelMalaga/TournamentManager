namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createTeamLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            teamsLabel = new Label();
            tournamentTeamsListBox = new ListBox();
            deleteSelectedTeamButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesListBoxLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(28, 31);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(317, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(37, 145);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(267, 35);
            tournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentNameLabel.Location = new Point(28, 96);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(236, 37);
            TournamentNameLabel.TabIndex = 9;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(166, 208);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(138, 35);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(28, 206);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(28, 365);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(276, 38);
            selectTeamDropdown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(28, 325);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Location = new Point(190, 332);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(114, 30);
            createTeamLabel.TabIndex = 15;
            createTeamLabel.TabStop = true;
            createTeamLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(89, 409);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(156, 46);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(89, 461);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(156, 46);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // teamsLabel
            // 
            teamsLabel.AutoSize = true;
            teamsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamsLabel.ForeColor = SystemColors.MenuHighlight;
            teamsLabel.Location = new Point(427, 96);
            teamsLabel.Name = "teamsLabel";
            teamsLabel.Size = new Size(184, 37);
            teamsLabel.TabIndex = 19;
            teamsLabel.Text = "Teams/Players";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new Point(427, 145);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(268, 152);
            tournamentTeamsListBox.TabIndex = 18;
            // 
            // deleteSelectedTeamButton
            // 
            deleteSelectedTeamButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedTeamButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedTeamButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedTeamButton.Location = new Point(718, 188);
            deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            deleteSelectedTeamButton.Size = new Size(156, 77);
            deleteSelectedTeamButton.TabIndex = 20;
            deleteSelectedTeamButton.Text = "Delete Selected";
            deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            deleteSelectedTeamButton.Click += deleteSelectedTeamButton_Click;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrizeButton.Location = new Point(718, 409);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(156, 74);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBoxLabel
            // 
            prizesListBoxLabel.AutoSize = true;
            prizesListBoxLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesListBoxLabel.ForeColor = SystemColors.MenuHighlight;
            prizesListBoxLabel.Location = new Point(427, 325);
            prizesListBoxLabel.Name = "prizesListBoxLabel";
            prizesListBoxLabel.Size = new Size(85, 37);
            prizesListBoxLabel.TabIndex = 22;
            prizesListBoxLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(427, 374);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(268, 152);
            prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(276, 554);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(284, 46);
            createTournamentButton.TabIndex = 24;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 633);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesListBoxLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedTeamButton);
            Controls.Add(teamsLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createTeamLabel);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label TournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createTeamLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label teamsLabel;
        private ListBox tournamentTeamsListBox;
        private Button deleteSelectedTeamButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesListBoxLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}