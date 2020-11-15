namespace JeopardyApp.Forms
{
    partial class QandAForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtBxAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSelectPlayer = new System.Windows.Forms.Label();
            this.cmbBxPlayers = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Blue;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuestion.Location = new System.Drawing.Point(36, 37);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(177, 31);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "The Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBxAnswer
            // 
            this.txtBxAnswer.BackColor = System.Drawing.Color.MediumBlue;
            this.txtBxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.txtBxAnswer.Location = new System.Drawing.Point(566, 283);
            this.txtBxAnswer.Name = "txtBxAnswer";
            this.txtBxAnswer.Size = new System.Drawing.Size(171, 38);
            this.txtBxAnswer.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(447, 286);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(113, 31);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblSelectPlayer
            // 
            this.lblSelectPlayer.AutoSize = true;
            this.lblSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPlayer.ForeColor = System.Drawing.Color.White;
            this.lblSelectPlayer.Location = new System.Drawing.Point(447, 208);
            this.lblSelectPlayer.Name = "lblSelectPlayer";
            this.lblSelectPlayer.Size = new System.Drawing.Size(182, 31);
            this.lblSelectPlayer.TabIndex = 3;
            this.lblSelectPlayer.Text = "Select Player:";
            // 
            // cmbBxPlayers
            // 
            this.cmbBxPlayers.BackColor = System.Drawing.Color.MediumBlue;
            this.cmbBxPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxPlayers.ForeColor = System.Drawing.Color.White;
            this.cmbBxPlayers.FormattingEnabled = true;
            this.cmbBxPlayers.Location = new System.Drawing.Point(635, 205);
            this.cmbBxPlayers.Name = "cmbBxPlayers";
            this.cmbBxPlayers.Size = new System.Drawing.Size(133, 39);
            this.cmbBxPlayers.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnSubmit.Location = new System.Drawing.Point(453, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(208, 48);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // QandAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbBxPlayers);
            this.Controls.Add(this.lblSelectPlayer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtBxAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "QandAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QandA";
            this.Load += new System.EventHandler(this.QandAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSelectPlayer;
        private System.Windows.Forms.ComboBox cmbBxPlayers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBxAnswer;
    }
}