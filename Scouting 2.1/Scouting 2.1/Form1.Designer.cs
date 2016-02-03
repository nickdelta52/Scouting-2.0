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
            this.chkPitHPS = new System.Windows.Forms.CheckBox();
            this.chkPitClimb = new System.Windows.Forms.CheckBox();
            this.chkPitGoals = new System.Windows.Forms.CheckedListBox();
            this.LBLPitGoals = new System.Windows.Forms.Label();
            this.txtPitTeams = new System.Windows.Forms.TextBox();
            this.chkPitDef = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLPitTeam = new System.Windows.Forms.Label();
            this.ptMatch = new System.Windows.Forms.TabPage();
            this.tbSort = new System.Windows.Forms.TabPage();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.LBLPitStart = new System.Windows.Forms.Label();
            this.chkPitStartPos = new System.Windows.Forms.CheckedListBox();
            this.LBLPitDT = new System.Windows.Forms.Label();
            this.txtPitDT = new System.Windows.Forms.RichTextBox();
            this.txtPitIntake = new System.Windows.Forms.RichTextBox();
            this.LBLPitIntake = new System.Windows.Forms.Label();
            this.txtPitSB = new System.Windows.Forms.RichTextBox();
            this.LBLPitSB = new System.Windows.Forms.Label();
            this.txtPitNote = new System.Windows.Forms.RichTextBox();
            this.LBLPitNote = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ptScout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ptScout);
            this.tabControl1.Controls.Add(this.ptMatch);
            this.tabControl1.Controls.Add(this.tbSort);
            this.tabControl1.Controls.Add(this.tbSearch);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // ptScout
            // 
            this.ptScout.Controls.Add(this.txtPitNote);
            this.ptScout.Controls.Add(this.LBLPitNote);
            this.ptScout.Controls.Add(this.txtPitSB);
            this.ptScout.Controls.Add(this.LBLPitSB);
            this.ptScout.Controls.Add(this.txtPitIntake);
            this.ptScout.Controls.Add(this.LBLPitIntake);
            this.ptScout.Controls.Add(this.txtPitDT);
            this.ptScout.Controls.Add(this.LBLPitDT);
            this.ptScout.Controls.Add(this.chkPitStartPos);
            this.ptScout.Controls.Add(this.LBLPitStart);
            this.ptScout.Controls.Add(this.chkPitHPS);
            this.ptScout.Controls.Add(this.chkPitClimb);
            this.ptScout.Controls.Add(this.chkPitGoals);
            this.ptScout.Controls.Add(this.LBLPitGoals);
            this.ptScout.Controls.Add(this.txtPitTeams);
            this.ptScout.Controls.Add(this.chkPitDef);
            this.ptScout.Controls.Add(this.label1);
            this.ptScout.Controls.Add(this.LBLPitTeam);
            this.ptScout.Location = new System.Drawing.Point(4, 25);
            this.ptScout.Name = "ptScout";
            this.ptScout.Padding = new System.Windows.Forms.Padding(3);
            this.ptScout.Size = new System.Drawing.Size(1025, 623);
            this.ptScout.TabIndex = 0;
            this.ptScout.Text = "Pit Scouting";
            this.ptScout.UseVisualStyleBackColor = true;
            // 
            // chkPitHPS
            // 
            this.chkPitHPS.AutoSize = true;
            this.chkPitHPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPitHPS.Location = new System.Drawing.Point(242, 295);
            this.chkPitHPS.Name = "chkPitHPS";
            this.chkPitHPS.Size = new System.Drawing.Size(249, 24);
            this.chkPitHPS.TabIndex = 8;
            this.chkPitHPS.Text = "Require human player station";
            this.chkPitHPS.UseVisualStyleBackColor = true;
            this.chkPitHPS.CheckedChanged += new System.EventHandler(this.chkPitHPS_CheckedChanged);
            // 
            // chkPitClimb
            // 
            this.chkPitClimb.AutoSize = true;
            this.chkPitClimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPitClimb.Location = new System.Drawing.Point(241, 265);
            this.chkPitClimb.Name = "chkPitClimb";
            this.chkPitClimb.Size = new System.Drawing.Size(109, 24);
            this.chkPitClimb.TabIndex = 7;
            this.chkPitClimb.Text = "Can Climb";
            this.chkPitClimb.UseVisualStyleBackColor = true;
            this.chkPitClimb.CheckedChanged += new System.EventHandler(this.chkPitClimb_CheckedChanged);
            // 
            // chkPitGoals
            // 
            this.chkPitGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPitGoals.FormattingEnabled = true;
            this.chkPitGoals.Items.AddRange(new object[] {
            "High",
            "Goal"});
            this.chkPitGoals.Location = new System.Drawing.Point(241, 126);
            this.chkPitGoals.Name = "chkPitGoals";
            this.chkPitGoals.Size = new System.Drawing.Size(152, 46);
            this.chkPitGoals.TabIndex = 6;
            // 
            // LBLPitGoals
            // 
            this.LBLPitGoals.AutoSize = true;
            this.LBLPitGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitGoals.Location = new System.Drawing.Point(238, 103);
            this.LBLPitGoals.Name = "LBLPitGoals";
            this.LBLPitGoals.Size = new System.Drawing.Size(58, 20);
            this.LBLPitGoals.TabIndex = 5;
            this.LBLPitGoals.Text = "Goals:";
            // 
            // txtPitTeams
            // 
            this.txtPitTeams.Location = new System.Drawing.Point(94, 50);
            this.txtPitTeams.Name = "txtPitTeams";
            this.txtPitTeams.Size = new System.Drawing.Size(100, 22);
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
            this.chkPitDef.Size = new System.Drawing.Size(153, 193);
            this.chkPitDef.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Defences:";
            // 
            // LBLPitTeam
            // 
            this.LBLPitTeam.AutoSize = true;
            this.LBLPitTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitTeam.Location = new System.Drawing.Point(31, 50);
            this.LBLPitTeam.Name = "LBLPitTeam";
            this.LBLPitTeam.Size = new System.Drawing.Size(56, 20);
            this.LBLPitTeam.TabIndex = 1;
            this.LBLPitTeam.Text = "Team:";
            // 
            // ptMatch
            // 
            this.ptMatch.Location = new System.Drawing.Point(4, 25);
            this.ptMatch.Name = "ptMatch";
            this.ptMatch.Padding = new System.Windows.Forms.Padding(3);
            this.ptMatch.Size = new System.Drawing.Size(1025, 623);
            this.ptMatch.TabIndex = 1;
            this.ptMatch.Text = "Match scouting";
            this.ptMatch.UseVisualStyleBackColor = true;
            // 
            // tbSort
            // 
            this.tbSort.Location = new System.Drawing.Point(4, 25);
            this.tbSort.Name = "tbSort";
            this.tbSort.Size = new System.Drawing.Size(1025, 623);
            this.tbSort.TabIndex = 2;
            this.tbSort.Text = "Sort Teams";
            this.tbSort.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(4, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1025, 623);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "Seach Team";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // LBLPitStart
            // 
            this.LBLPitStart.AutoSize = true;
            this.LBLPitStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitStart.Location = new System.Drawing.Point(237, 179);
            this.LBLPitStart.Name = "LBLPitStart";
            this.LBLPitStart.Size = new System.Drawing.Size(184, 20);
            this.LBLPitStart.TabIndex = 9;
            this.LBLPitStart.Text = "Prefered Start Position:";
            // 
            // chkPitStartPos
            // 
            this.chkPitStartPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkPitStartPos.FormattingEnabled = true;
            this.chkPitStartPos.Items.AddRange(new object[] {
            "Middle",
            "Spy"});
            this.chkPitStartPos.Location = new System.Drawing.Point(241, 202);
            this.chkPitStartPos.Name = "chkPitStartPos";
            this.chkPitStartPos.Size = new System.Drawing.Size(152, 46);
            this.chkPitStartPos.TabIndex = 10;
            // 
            // LBLPitDT
            // 
            this.LBLPitDT.AutoSize = true;
            this.LBLPitDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitDT.Location = new System.Drawing.Point(494, 394);
            this.LBLPitDT.Name = "LBLPitDT";
            this.LBLPitDT.Size = new System.Drawing.Size(97, 20);
            this.LBLPitDT.TabIndex = 11;
            this.LBLPitDT.Text = "Drive Train:";
            // 
            // txtPitDT
            // 
            this.txtPitDT.Location = new System.Drawing.Point(498, 418);
            this.txtPitDT.Name = "txtPitDT";
            this.txtPitDT.Size = new System.Drawing.Size(486, 113);
            this.txtPitDT.TabIndex = 12;
            this.txtPitDT.Text = "";
            // 
            // txtPitIntake
            // 
            this.txtPitIntake.Location = new System.Drawing.Point(498, 267);
            this.txtPitIntake.Name = "txtPitIntake";
            this.txtPitIntake.Size = new System.Drawing.Size(486, 113);
            this.txtPitIntake.TabIndex = 14;
            this.txtPitIntake.Text = "";
            // 
            // LBLPitIntake
            // 
            this.LBLPitIntake.AutoSize = true;
            this.LBLPitIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitIntake.Location = new System.Drawing.Point(494, 243);
            this.LBLPitIntake.Name = "LBLPitIntake";
            this.LBLPitIntake.Size = new System.Drawing.Size(58, 20);
            this.LBLPitIntake.TabIndex = 13;
            this.LBLPitIntake.Text = "Intake:";
            // 
            // txtPitSB
            // 
            this.txtPitSB.Location = new System.Drawing.Point(498, 126);
            this.txtPitSB.Name = "txtPitSB";
            this.txtPitSB.Size = new System.Drawing.Size(486, 113);
            this.txtPitSB.TabIndex = 16;
            this.txtPitSB.Text = "";
            // 
            // LBLPitSB
            // 
            this.LBLPitSB.AutoSize = true;
            this.LBLPitSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitSB.Location = new System.Drawing.Point(494, 102);
            this.LBLPitSB.Name = "LBLPitSB";
            this.LBLPitSB.Size = new System.Drawing.Size(165, 20);
            this.LBLPitSB.TabIndex = 15;
            this.LBLPitSB.Text = "Spy Bot Capabilities:";
            // 
            // txtPitNote
            // 
            this.txtPitNote.Location = new System.Drawing.Point(35, 370);
            this.txtPitNote.Name = "txtPitNote";
            this.txtPitNote.Size = new System.Drawing.Size(437, 161);
            this.txtPitNote.TabIndex = 18;
            this.txtPitNote.Text = "";
            // 
            // LBLPitNote
            // 
            this.LBLPitNote.AutoSize = true;
            this.LBLPitNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBLPitNote.Location = new System.Drawing.Point(31, 346);
            this.LBLPitNote.Name = "LBLPitNote";
            this.LBLPitNote.Size = new System.Drawing.Size(58, 20);
            this.LBLPitNote.TabIndex = 17;
            this.LBLPitNote.Text = "Notes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.ptScout.ResumeLayout(false);
            this.ptScout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ptScout;
        private System.Windows.Forms.TabPage ptMatch;
        private System.Windows.Forms.TabPage tbSort;
        private System.Windows.Forms.CheckedListBox chkPitDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLPitTeam;
        private System.Windows.Forms.Label LBLPitGoals;
        private System.Windows.Forms.TextBox txtPitTeams;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.CheckedListBox chkPitGoals;
        private System.Windows.Forms.CheckBox chkPitHPS;
        private System.Windows.Forms.CheckBox chkPitClimb;
        private System.Windows.Forms.RichTextBox txtPitNote;
        private System.Windows.Forms.Label LBLPitNote;
        private System.Windows.Forms.RichTextBox txtPitSB;
        private System.Windows.Forms.Label LBLPitSB;
        private System.Windows.Forms.RichTextBox txtPitIntake;
        private System.Windows.Forms.Label LBLPitIntake;
        private System.Windows.Forms.RichTextBox txtPitDT;
        private System.Windows.Forms.Label LBLPitDT;
        private System.Windows.Forms.CheckedListBox chkPitStartPos;
        private System.Windows.Forms.Label LBLPitStart;
    }
}

