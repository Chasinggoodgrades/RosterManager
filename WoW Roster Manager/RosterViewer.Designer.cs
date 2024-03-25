namespace WoW_Roster_Manager
{
    partial class RosterViewer
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.createRosterButton = new System.Windows.Forms.Button();
            this.removeRosterButton = new System.Windows.Forms.Button();
            this.renameRosterButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeGuildLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(241, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(916, 646);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // createRosterButton
            // 
            this.createRosterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRosterButton.ForeColor = System.Drawing.Color.Gold;
            this.createRosterButton.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.createRosterButton.Location = new System.Drawing.Point(39, 205);
            this.createRosterButton.Name = "createRosterButton";
            this.createRosterButton.Size = new System.Drawing.Size(144, 69);
            this.createRosterButton.TabIndex = 1;
            this.createRosterButton.Text = "Create Roster";
            this.createRosterButton.UseVisualStyleBackColor = true;
            this.createRosterButton.Click += new System.EventHandler(this.createRosterButton_Click);
            // 
            // removeRosterButton
            // 
            this.removeRosterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeRosterButton.ForeColor = System.Drawing.Color.Gold;
            this.removeRosterButton.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.removeRosterButton.Location = new System.Drawing.Point(39, 385);
            this.removeRosterButton.Name = "removeRosterButton";
            this.removeRosterButton.Size = new System.Drawing.Size(144, 69);
            this.removeRosterButton.TabIndex = 2;
            this.removeRosterButton.Text = "Remove Roster";
            this.removeRosterButton.UseVisualStyleBackColor = true;
            this.removeRosterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // renameRosterButton
            // 
            this.renameRosterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameRosterButton.ForeColor = System.Drawing.Color.Gold;
            this.renameRosterButton.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.renameRosterButton.Location = new System.Drawing.Point(39, 570);
            this.renameRosterButton.Name = "renameRosterButton";
            this.renameRosterButton.Size = new System.Drawing.Size(144, 69);
            this.renameRosterButton.TabIndex = 3;
            this.renameRosterButton.Text = "Rename Roster";
            this.renameRosterButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Gold;
            this.logoutButton.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.logoutButton.Location = new System.Drawing.Point(1013, 18);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(144, 69);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // welcomeGuildLabel
            // 
            this.welcomeGuildLabel.AutoSize = true;
            this.welcomeGuildLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeGuildLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeGuildLabel.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.welcomeGuildLabel.Location = new System.Drawing.Point(235, 33);
            this.welcomeGuildLabel.Name = "welcomeGuildLabel";
            this.welcomeGuildLabel.Size = new System.Drawing.Size(144, 33);
            this.welcomeGuildLabel.TabIndex = 5;
            this.welcomeGuildLabel.Text = "Welcome";
            // 
            // RosterViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WoW_Roster_Manager.Properties.Resources.backGroundRoster;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.welcomeGuildLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.renameRosterButton);
            this.Controls.Add(this.removeRosterButton);
            this.Controls.Add(this.createRosterButton);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Name = "RosterViewer";
            this.Text = "Roster Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button createRosterButton;
        private System.Windows.Forms.Button removeRosterButton;
        private System.Windows.Forms.Button renameRosterButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label welcomeGuildLabel;
    }
}