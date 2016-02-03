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
            this.ptMatch = new System.Windows.Forms.TabPage();
            this.tbView = new System.Windows.Forms.TabPage();
            this.lbMatchTeam = new System.Windows.Forms.ListBox();
            this.LBLMatchTeam = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ptMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ptScout);
            this.tabControl1.Controls.Add(this.ptMatch);
            this.tabControl1.Controls.Add(this.tbView);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // ptScout
            // 
            this.ptScout.Location = new System.Drawing.Point(4, 22);
            this.ptScout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptScout.Name = "ptScout";
            this.ptScout.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptScout.Size = new System.Drawing.Size(767, 504);
            this.ptScout.TabIndex = 0;
            this.ptScout.Text = "Pit Scouting";
            this.ptScout.UseVisualStyleBackColor = true;
            // 
            // ptMatch
            // 
            this.ptMatch.Controls.Add(this.LBLMatchTeam);
            this.ptMatch.Controls.Add(this.lbMatchTeam);
            this.ptMatch.Location = new System.Drawing.Point(4, 22);
            this.ptMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptMatch.Name = "ptMatch";
            this.ptMatch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptMatch.Size = new System.Drawing.Size(767, 504);
            this.ptMatch.TabIndex = 1;
            this.ptMatch.Text = "Match scouting";
            this.ptMatch.UseVisualStyleBackColor = true;
            // 
            // tbView
            // 
            this.tbView.Location = new System.Drawing.Point(4, 22);
            this.tbView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(767, 504);
            this.tbView.TabIndex = 2;
            this.tbView.Text = "View Results";
            this.tbView.UseVisualStyleBackColor = true;
            // 
            // lbMatchTeam
            // 
            this.lbMatchTeam.FormattingEnabled = true;
            this.lbMatchTeam.Location = new System.Drawing.Point(9, 27);
            this.lbMatchTeam.Name = "lbMatchTeam";
            this.lbMatchTeam.Size = new System.Drawing.Size(60, 95);
            this.lbMatchTeam.TabIndex = 0;
            // 
            // LBLMatchTeam
            // 
            this.LBLMatchTeam.AutoSize = true;
            this.LBLMatchTeam.Location = new System.Drawing.Point(10, 11);
            this.LBLMatchTeam.Name = "LBLMatchTeam";
            this.LBLMatchTeam.Size = new System.Drawing.Size(37, 13);
            this.LBLMatchTeam.TabIndex = 1;
            this.LBLMatchTeam.Text = "Team:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 531);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Scouting 2.1";
            this.tabControl1.ResumeLayout(false);
            this.ptMatch.ResumeLayout(false);
            this.ptMatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ptScout;
        private System.Windows.Forms.TabPage ptMatch;
        private System.Windows.Forms.TabPage tbView;
        private System.Windows.Forms.Label LBLMatchTeam;
        private System.Windows.Forms.ListBox lbMatchTeam;
    }
}

