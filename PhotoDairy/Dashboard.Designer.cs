
namespace PhotoDairy
{
    partial class Dashboard
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
            this.createEventButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.highdataGridView = new System.Windows.Forms.DataGridView();
            this.moderatedataGridView = new System.Windows.Forms.DataGridView();
            this.lowdataGridView = new System.Windows.Forms.DataGridView();
            this.profileButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.highdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderatedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(557, 138);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(147, 40);
            this.createEventButton.TabIndex = 0;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(557, 184);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(147, 40);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // updateEventButton
            // 
            this.updateEventButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventButton.Location = new System.Drawing.Point(557, 266);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(147, 40);
            this.updateEventButton.TabIndex = 2;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(557, 312);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Event";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event :";
            // 
            // highdataGridView
            // 
            this.highdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highdataGridView.Location = new System.Drawing.Point(12, 116);
            this.highdataGridView.Name = "highdataGridView";
            this.highdataGridView.Size = new System.Drawing.Size(347, 108);
            this.highdataGridView.TabIndex = 5;
            // 
            // moderatedataGridView
            // 
            this.moderatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moderatedataGridView.Location = new System.Drawing.Point(12, 230);
            this.moderatedataGridView.Name = "moderatedataGridView";
            this.moderatedataGridView.Size = new System.Drawing.Size(347, 108);
            this.moderatedataGridView.TabIndex = 6;
            // 
            // lowdataGridView
            // 
            this.lowdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowdataGridView.Location = new System.Drawing.Point(12, 344);
            this.lowdataGridView.Name = "lowdataGridView";
            this.lowdataGridView.Size = new System.Drawing.Size(347, 108);
            this.lowdataGridView.TabIndex = 7;
            // 
            // profileButton
            // 
            this.profileButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.Location = new System.Drawing.Point(419, 44);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(147, 40);
            this.profileButton.TabIndex = 8;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(572, 44);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(147, 40);
            this.logOutButton.TabIndex = 9;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 484);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.lowdataGridView);
            this.Controls.Add(this.moderatedataGridView);
            this.Controls.Add(this.highdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateEventButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.createEventButton);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.highdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderatedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView highdataGridView;
        private System.Windows.Forms.DataGridView moderatedataGridView;
        private System.Windows.Forms.DataGridView lowdataGridView;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button logOutButton;
    }
}

