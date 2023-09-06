namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberButton = new Label();
            selectTeamMemberDropdown = new ComboBox();
            addTeamMemberButton = new Button();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellPhoneValue = new TextBox();
            cellPhoneLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(12, 95);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(350, 35);
            teamNameValue.TabIndex = 27;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(12, 55);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 26;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(3, 5);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(213, 50);
            createTeamLabel.TabIndex = 25;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamMemberButton
            // 
            selectTeamMemberButton.AutoSize = true;
            selectTeamMemberButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberButton.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberButton.Location = new Point(12, 145);
            selectTeamMemberButton.Name = "selectTeamMemberButton";
            selectTeamMemberButton.Size = new Size(263, 37);
            selectTeamMemberButton.TabIndex = 28;
            selectTeamMemberButton.Text = "Select Team Member";
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(12, 185);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(350, 38);
            selectTeamMemberDropdown.TabIndex = 29;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamMemberButton.ForeColor = SystemColors.MenuHighlight;
            addTeamMemberButton.Location = new Point(60, 229);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(156, 46);
            addTeamMemberButton.TabIndex = 30;
            addTeamMemberButton.Text = "Add Member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            addTeamMemberButton.Click += addTeamMemberButton_Click;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(cellPhoneValue);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            addNewMemberGroupBox.Location = new Point(12, 281);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(350, 356);
            addNewMemberGroupBox.TabIndex = 31;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(86, 276);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(212, 46);
            createMemberButton.TabIndex = 31;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // emailValue
            // 
            emailValue.Location = new Point(156, 209);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(159, 43);
            emailValue.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(6, 206);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 37);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "E-mail";
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new Point(156, 155);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new Size(159, 43);
            cellPhoneValue.TabIndex = 14;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellPhoneLabel.Location = new Point(6, 152);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(138, 37);
            cellPhoneLabel.TabIndex = 13;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(156, 100);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(159, 43);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 97);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(156, 43);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(159, 43);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(6, 40);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(418, 95);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(268, 542);
            teamMembersListBox.TabIndex = 32;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedMemberButton.Location = new Point(692, 310);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(156, 77);
            removeSelectedMemberButton.TabIndex = 33;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(276, 657);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(284, 46);
            createTeamButton.TabIndex = 34;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 730);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(selectTeamMemberButton);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Label selectTeamMemberButton;
        private ComboBox selectTeamMemberDropdown;
        private Button addTeamMemberButton;
        private GroupBox addNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
    }
}