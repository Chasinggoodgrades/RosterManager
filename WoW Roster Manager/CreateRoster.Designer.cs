namespace WoW_Roster_Manager
{
    partial class CreateRoster
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
            this.RosterListView = new System.Windows.Forms.ListView();
            this.CharactersListView = new System.Windows.Forms.ListView();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.saveRosterButton = new System.Windows.Forms.Button();
            this.resetRosterButton = new System.Windows.Forms.Button();
            this.exitRosterCreationButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RosterListView
            // 
            this.RosterListView.HideSelection = false;
            this.RosterListView.Location = new System.Drawing.Point(12, 3);
            this.RosterListView.Name = "RosterListView";
            this.RosterListView.Size = new System.Drawing.Size(1160, 511);
            this.RosterListView.TabIndex = 0;
            this.RosterListView.UseCompatibleStateImageBehavior = false;
            // 
            // CharactersListView
            // 
            this.CharactersListView.HideSelection = false;
            this.CharactersListView.Location = new System.Drawing.Point(12, 520);
            this.CharactersListView.Name = "CharactersListView";
            this.CharactersListView.Size = new System.Drawing.Size(1160, 161);
            this.CharactersListView.TabIndex = 1;
            this.CharactersListView.UseCompatibleStateImageBehavior = false;
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.BackgroundImage = global::WoW_Roster_Manager.Properties.Resources.whiteButton;
            this.createPlayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.Location = new System.Drawing.Point(34, 702);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(133, 37);
            this.createPlayerButton.TabIndex = 2;
            this.createPlayerButton.Text = "Create Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            // 
            // saveRosterButton
            // 
            this.saveRosterButton.BackgroundImage = global::WoW_Roster_Manager.Properties.Resources.whiteButton;
            this.saveRosterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRosterButton.Location = new System.Drawing.Point(195, 702);
            this.saveRosterButton.Name = "saveRosterButton";
            this.saveRosterButton.Size = new System.Drawing.Size(133, 37);
            this.saveRosterButton.TabIndex = 3;
            this.saveRosterButton.Text = "Save Roster";
            this.saveRosterButton.UseVisualStyleBackColor = true;
            this.saveRosterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resetRosterButton
            // 
            this.resetRosterButton.BackgroundImage = global::WoW_Roster_Manager.Properties.Resources.whiteButton;
            this.resetRosterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetRosterButton.Location = new System.Drawing.Point(890, 702);
            this.resetRosterButton.Name = "resetRosterButton";
            this.resetRosterButton.Size = new System.Drawing.Size(133, 37);
            this.resetRosterButton.TabIndex = 4;
            this.resetRosterButton.Text = "Reset Roster";
            this.resetRosterButton.UseVisualStyleBackColor = true;
            // 
            // exitRosterCreationButton
            // 
            this.exitRosterCreationButton.BackgroundImage = global::WoW_Roster_Manager.Properties.Resources.whiteButton;
            this.exitRosterCreationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitRosterCreationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitRosterCreationButton.Location = new System.Drawing.Point(1039, 702);
            this.exitRosterCreationButton.Name = "exitRosterCreationButton";
            this.exitRosterCreationButton.Size = new System.Drawing.Size(133, 37);
            this.exitRosterCreationButton.TabIndex = 5;
            this.exitRosterCreationButton.Text = "Exit";
            this.exitRosterCreationButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 718);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Image = global::WoW_Roster_Manager.Properties.Resources.blackButton;
            this.label1.Location = new System.Drawing.Point(531, 693);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Groups:";
            // 
            // CreateRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exitRosterCreationButton);
            this.Controls.Add(this.resetRosterButton);
            this.Controls.Add(this.saveRosterButton);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.CharactersListView);
            this.Controls.Add(this.RosterListView);
            this.Name = "CreateRoster";
            this.Text = "Create Roster";
            this.Load += new System.EventHandler(this.CreateRoster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView RosterListView;
        private System.Windows.Forms.ListView CharactersListView;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.Button saveRosterButton;
        private System.Windows.Forms.Button resetRosterButton;
        private System.Windows.Forms.Button exitRosterCreationButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}