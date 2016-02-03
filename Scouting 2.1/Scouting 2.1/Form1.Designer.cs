namespace Scouting_2._1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ptScout = new System.Windows.Forms.TabPage();
            this.LBLPitGoals = new System.Windows.Forms.Label();
            this.txtPitTeams = new System.Windows.Forms.TextBox();
            this.chkPitDef = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLPitTeam = new System.Windows.Forms.Label();
            this.ptMatch = new System.Windows.Forms.TabPage();
            this.tbView = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ptScout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ptScout);
            this.tabControl1.Controls.Add(this.ptMatch);
            this.tabControl1.Controls.Add(this.tbView);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // ptScout
            // 
            this.ptScout.Controls.Add(this.LBLPitGoals);
            this.ptScout.Controls.Add(this.txtPitTeams);
            this.ptScout.Controls.Add(this.chkPitDef);
            this.ptScout.Controls.Add(this.label1);
            this.ptScout.Controls.Add(this.LBLPitTeam);
            this.ptScout.Location = new System.Drawing.Point(4, 22);
            this.ptScout.Name = "ptScout";
            this.ptScout.Padding = new System.Windows.Forms.Padding(2);
            this.ptScout.Size = new System.Drawing.Size(767, 504);
            this.ptScout.TabIndex = 0;
            this.ptScout.Text = "Pit Scouting";
            this.ptScout.UseVisualStyleBackColor = true;
            // 
            // LBLPitGoals
            // 
            this.LBLPitGoals.AutoSize = true;
            this.LBLPitGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitGoals.Location = new System.Drawing.Point(34, 346);
            this.LBLPitGoals.Name = "LBLPitGoals";
            this.LBLPitGoals.Size = new System.Drawing.Size(46, 17);
            this.LBLPitGoals.TabIndex = 5;
            this.LBLPitGoals.Text = "label2";
            // 
            // txtPitTeams
            // 
            this.txtPitTeams.Location = new System.Drawing.Point(94, 50);
            this.txtPitTeams.Name = "txtPitTeams";
            this.txtPitTeams.Size = new System.Drawing.Size(100, 20);
            this.txtPitTeams.TabIndex = 4;
            // 
            // chkPitDef
            // 
            this.chkPitDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPitDef.FormattingEnabled = true;
            this.chkPitDef.Items.AddRange(new object[] {
            "Portcullis",
            "Cheval de Frise",
            "Ramparts",
            "Moat",
            "Drawbridge",
            "Sally Port",
            "Rock Wall",
            "Rough Terrain",
            "Low Bar"});
            this.chkPitDef.Location = new System.Drawing.Point(35, 126);
            this.chkPitDef.Name = "chkPitDef";
            this.chkPitDef.Size = new System.Drawing.Size(153, 184);
            this.chkPitDef.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Defenses:";
            // 
            // LBLPitTeam
            // 
            this.LBLPitTeam.AutoSize = true;
            this.LBLPitTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitTeam.Location = new System.Drawing.Point(33, 52);
            this.LBLPitTeam.Name = "LBLPitTeam";
            this.LBLPitTeam.Size = new System.Drawing.Size(48, 17);
            this.LBLPitTeam.TabIndex = 1;
            this.LBLPitTeam.Text = "Team:";
            // 
            // ptMatch
            // 
            this.ptMatch.Location = new System.Drawing.Point(4, 22);
            this.ptMatch.Margin = new System.Windows.Forms.Padding(2);
            this.ptMatch.Name = "ptMatch";
            this.ptMatch.Padding = new System.Windows.Forms.Padding(2);
            this.ptMatch.Size = new System.Drawing.Size(767, 504);
            this.ptMatch.TabIndex = 1;
            this.ptMatch.Text = "Match scouting";
            this.ptMatch.UseVisualStyleBackColor = true;
            // 
            // tbView
            // 
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2);
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(767, 504);
            this.tbView.TabIndex = 2;
            this.tbView.Text = "View Results";
            this.tbView.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(767, 504);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Seach Team";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 531);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Scouting 2.1";
            this.tabControl1.ResumeLayout(false);
            this.ptScout.ResumeLayout(false);
            this.ptScout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ptScout;
        private System.Windows.Forms.TabPage ptMatch;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.CheckedListBox chkPitDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLPitTeam;
        private System.Windows.Forms.Label LBLPitGoals;
        private System.Windows.Forms.TextBox txtPitTeams;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

