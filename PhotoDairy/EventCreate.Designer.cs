
namespace PhotoDairy
{
    partial class EventCreate
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
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.eventTitleTextBox = new System.Windows.Forms.TextBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.eventDescriptionlabel = new System.Windows.Forms.Label();
            this.eventDecriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTitleLabel
            // 
            this.eventTitleLabel.AutoSize = true;
            this.eventTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitleLabel.Location = new System.Drawing.Point(21, 20);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Size = new System.Drawing.Size(82, 16);
            this.eventTitleLabel.TabIndex = 0;
            this.eventTitleLabel.Text = "Event Title :";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(21, 64);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(62, 16);
            this.priorityLabel.TabIndex = 1;
            this.priorityLabel.Text = "Priority :";
            // 
            // eventTitleTextBox
            // 
            this.eventTitleTextBox.Location = new System.Drawing.Point(109, 18);
            this.eventTitleTextBox.Name = "eventTitleTextBox";
            this.eventTitleTextBox.Size = new System.Drawing.Size(364, 20);
            this.eventTitleTextBox.TabIndex = 2;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Low"});
            this.priorityComboBox.Location = new System.Drawing.Point(109, 59);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(364, 21);
            this.priorityComboBox.TabIndex = 3;
            // 
            // eventDescriptionlabel
            // 
            this.eventDescriptionlabel.AutoSize = true;
            this.eventDescriptionlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescriptionlabel.Location = new System.Drawing.Point(21, 203);
            this.eventDescriptionlabel.Name = "eventDescriptionlabel";
            this.eventDescriptionlabel.Size = new System.Drawing.Size(125, 16);
            this.eventDescriptionlabel.TabIndex = 4;
            this.eventDescriptionlabel.Text = "Event Description :";
            // 
            // eventDecriptionTextBox
            // 
            this.eventDecriptionTextBox.Location = new System.Drawing.Point(24, 237);
            this.eventDecriptionTextBox.Multiline = true;
            this.eventDecriptionTextBox.Name = "eventDecriptionTextBox";
            this.eventDecriptionTextBox.Size = new System.Drawing.Size(670, 211);
            this.eventDecriptionTextBox.TabIndex = 5;
            // 
            // eventPictureBox
            // 
            this.eventPictureBox.Location = new System.Drawing.Point(479, 20);
            this.eventPictureBox.Name = "eventPictureBox";
            this.eventPictureBox.Size = new System.Drawing.Size(215, 199);
            this.eventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.eventPictureBox.TabIndex = 6;
            this.eventPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(479, 455);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 34);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(594, 455);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 34);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(362, 455);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 34);
            this.insertButton.TabIndex = 9;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // EventCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 512);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventPictureBox);
            this.Controls.Add(this.eventDecriptionTextBox);
            this.Controls.Add(this.eventDescriptionlabel);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.eventTitleTextBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.eventTitleLabel);
            this.Name = "EventCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventCreate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventCreate_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTitleLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.TextBox eventTitleTextBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label eventDescriptionlabel;
        private System.Windows.Forms.TextBox eventDecriptionTextBox;
        private System.Windows.Forms.PictureBox eventPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button insertButton;
    }
}