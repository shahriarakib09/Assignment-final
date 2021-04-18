
namespace PhotoDairy
{
    partial class SignUp
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
            this.agreementCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLebel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.dateOFBirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.userNameLebel = new System.Windows.Forms.Label();
            this.confirmPasswordLebel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLebel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLebel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agreementCheckBox
            // 
            this.agreementCheckBox.AutoSize = true;
            this.agreementCheckBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreementCheckBox.ForeColor = System.Drawing.Color.Red;
            this.agreementCheckBox.Location = new System.Drawing.Point(101, 335);
            this.agreementCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.agreementCheckBox.Name = "agreementCheckBox";
            this.agreementCheckBox.Size = new System.Drawing.Size(350, 20);
            this.agreementCheckBox.TabIndex = 50;
            this.agreementCheckBox.Text = "I agree to the License Terms & Services as well as Privacy Policy";
            this.agreementCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(169, 109);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(282, 20);
            this.emailTextBox.TabIndex = 49;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(27, 109);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 19);
            this.emailLabel.TabIndex = 48;
            this.emailLabel.Text = "Email : ";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(143, 370);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 26);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(291, 370);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(105, 26);
            this.signUpButton.TabIndex = 46;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(169, 301);
            this.bloodGroupComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(282, 21);
            this.bloodGroupComboBox.TabIndex = 45;
            // 
            // bloodGroupLebel
            // 
            this.bloodGroupLebel.AutoSize = true;
            this.bloodGroupLebel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupLebel.Location = new System.Drawing.Point(27, 303);
            this.bloodGroupLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodGroupLebel.Name = "bloodGroupLebel";
            this.bloodGroupLebel.Size = new System.Drawing.Size(102, 19);
            this.bloodGroupLebel.TabIndex = 44;
            this.bloodGroupLebel.Text = "Blood Group:";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(236, 269);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(61, 18);
            this.femaleRadioButton.TabIndex = 42;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(169, 269);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(50, 18);
            this.maleRadioButton.TabIndex = 41;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Location = new System.Drawing.Point(169, 224);
            this.dOBDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dOBDateTimePicker.MaxDate = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(282, 20);
            this.dOBDateTimePicker.TabIndex = 40;
            this.dOBDateTimePicker.Value = new System.DateTime(2021, 4, 16, 0, 0, 0, 0);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(169, 76);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.userNameTextBox.TabIndex = 39;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(169, 184);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(282, 20);
            this.confirmPasswordTextBox.TabIndex = 38;
            // 
            // dateOFBirthLabel
            // 
            this.dateOFBirthLabel.AutoSize = true;
            this.dateOFBirthLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOFBirthLabel.Location = new System.Drawing.Point(27, 224);
            this.dateOFBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOFBirthLabel.Name = "dateOFBirthLabel";
            this.dateOFBirthLabel.Size = new System.Drawing.Size(108, 19);
            this.dateOFBirthLabel.TabIndex = 37;
            this.dateOFBirthLabel.Text = "Date of Birth :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(-66, 322);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(61, 18);
            this.genderLabel.TabIndex = 36;
            this.genderLabel.Text = "Gender:";
            // 
            // userNameLebel
            // 
            this.userNameLebel.AutoSize = true;
            this.userNameLebel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLebel.Location = new System.Drawing.Point(27, 77);
            this.userNameLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLebel.Name = "userNameLebel";
            this.userNameLebel.Size = new System.Drawing.Size(99, 19);
            this.userNameLebel.TabIndex = 35;
            this.userNameLebel.Text = "User Name : ";
            // 
            // confirmPasswordLebel
            // 
            this.confirmPasswordLebel.AutoSize = true;
            this.confirmPasswordLebel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLebel.Location = new System.Drawing.Point(27, 184);
            this.confirmPasswordLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPasswordLebel.Name = "confirmPasswordLebel";
            this.confirmPasswordLebel.Size = new System.Drawing.Size(149, 19);
            this.confirmPasswordLebel.TabIndex = 34;
            this.confirmPasswordLebel.Text = "Confirm Password : ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(169, 43);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTextBox.TabIndex = 33;
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.Location = new System.Drawing.Point(27, 43);
            this.nameLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(63, 19);
            this.nameLebel.TabIndex = 32;
            this.nameLebel.Text = "Name : ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(169, 143);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(282, 20);
            this.passwordTextBox.TabIndex = 31;
            // 
            // passwordLebel
            // 
            this.passwordLebel.AutoSize = true;
            this.passwordLebel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLebel.Location = new System.Drawing.Point(27, 144);
            this.passwordLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLebel.Name = "passwordLebel";
            this.passwordLebel.Size = new System.Drawing.Size(88, 19);
            this.passwordLebel.TabIndex = 30;
            this.passwordLebel.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Gender :";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agreementCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.bloodGroupLebel);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.dateOFBirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.userNameLebel);
            this.Controls.Add(this.confirmPasswordLebel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLebel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLebel);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox agreementCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroupLebel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label dateOFBirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label userNameLebel;
        private System.Windows.Forms.Label confirmPasswordLebel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLebel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLebel;
        private System.Windows.Forms.Label label1;
    }
}