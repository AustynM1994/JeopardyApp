namespace JeopardyApp
{
    partial class OptionsForm
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.lstBxDisplayNames = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtBxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerNameList = new System.Windows.Forms.Label();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(79, 39);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(178, 31);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.BackColor = System.Drawing.Color.Blue;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.ForeColor = System.Drawing.Color.Yellow;
            this.btnCreatePlayer.Location = new System.Drawing.Point(513, 35);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(226, 39);
            this.btnCreatePlayer.TabIndex = 3;
            this.btnCreatePlayer.Text = "Create";
            this.btnCreatePlayer.UseVisualStyleBackColor = false;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // lstBxDisplayNames
            // 
            this.lstBxDisplayNames.BackColor = System.Drawing.Color.MediumBlue;
            this.lstBxDisplayNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxDisplayNames.ForeColor = System.Drawing.Color.White;
            this.lstBxDisplayNames.FormattingEnabled = true;
            this.lstBxDisplayNames.ItemHeight = 29;
            this.lstBxDisplayNames.Location = new System.Drawing.Point(293, 132);
            this.lstBxDisplayNames.Name = "lstBxDisplayNames";
            this.lstBxDisplayNames.Size = new System.Drawing.Size(183, 91);
            this.lstBxDisplayNames.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Blue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Yellow;
            this.btnNext.Location = new System.Drawing.Point(568, 391);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(220, 47);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtBxPlayerName
            // 
            this.txtBxPlayerName.BackColor = System.Drawing.Color.MediumBlue;
            this.txtBxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPlayerName.ForeColor = System.Drawing.Color.White;
            this.txtBxPlayerName.Location = new System.Drawing.Point(293, 36);
            this.txtBxPlayerName.Name = "txtBxPlayerName";
            this.txtBxPlayerName.Size = new System.Drawing.Size(183, 38);
            this.txtBxPlayerName.TabIndex = 5;
            // 
            // lblPlayerNameList
            // 
            this.lblPlayerNameList.AutoSize = true;
            this.lblPlayerNameList.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameList.ForeColor = System.Drawing.Color.White;
            this.lblPlayerNameList.Location = new System.Drawing.Point(79, 132);
            this.lblPlayerNameList.Name = "lblPlayerNameList";
            this.lblPlayerNameList.Size = new System.Drawing.Size(156, 31);
            this.lblPlayerNameList.TabIndex = 6;
            this.lblPlayerNameList.Text = "Player List: ";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.BackColor = System.Drawing.Color.Blue;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.Yellow;
            this.btnDeletePlayer.Location = new System.Drawing.Point(513, 132);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(226, 39);
            this.btnDeletePlayer.TabIndex = 7;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.lblPlayerNameList);
            this.Controls.Add(this.txtBxPlayerName);
            this.Controls.Add(this.lstBxDisplayNames);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.ListBox lstBxDisplayNames;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtBxPlayerName;
        private System.Windows.Forms.Label lblPlayerNameList;
        private System.Windows.Forms.Button btnDeletePlayer;
    }
}