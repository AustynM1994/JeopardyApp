namespace JeopardyApp
{
    partial class ResultsForm
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
            this.lstBxLeaderboard = new System.Windows.Forms.ListBox();
            this.lblLeaderboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBxLeaderboard
            // 
            this.lstBxLeaderboard.BackColor = System.Drawing.Color.MediumBlue;
            this.lstBxLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lstBxLeaderboard.FormattingEnabled = true;
            this.lstBxLeaderboard.ItemHeight = 31;
            this.lstBxLeaderboard.Location = new System.Drawing.Point(124, 93);
            this.lstBxLeaderboard.Name = "lstBxLeaderboard";
            this.lstBxLeaderboard.Size = new System.Drawing.Size(588, 345);
            this.lstBxLeaderboard.TabIndex = 0;
            // 
            // lblLeaderboard
            // 
            this.lblLeaderboard.AutoSize = true;
            this.lblLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboard.ForeColor = System.Drawing.Color.White;
            this.lblLeaderboard.Location = new System.Drawing.Point(340, 35);
            this.lblLeaderboard.Name = "lblLeaderboard";
            this.lblLeaderboard.Size = new System.Drawing.Size(167, 31);
            this.lblLeaderboard.TabIndex = 1;
            this.lblLeaderboard.Text = "Leaderboard";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLeaderboard);
            this.Controls.Add(this.lstBxLeaderboard);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Results";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxLeaderboard;
        private System.Windows.Forms.Label lblLeaderboard;
    }
}