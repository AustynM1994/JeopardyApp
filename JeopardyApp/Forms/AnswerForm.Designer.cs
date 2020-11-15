namespace JeopardyApp.Forms
{
    partial class AnswerForm
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
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblPlayerAnswer = new System.Windows.Forms.Label();
            this.btnCorrectAnswer = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(500, 27);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(256, 31);
            this.lblCorrectAnswer.TabIndex = 0;
            this.lblCorrectAnswer.Text = "The Correct Answer";
            // 
            // lblPlayerAnswer
            // 
            this.lblPlayerAnswer.AutoSize = true;
            this.lblPlayerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerAnswer.Location = new System.Drawing.Point(500, 89);
            this.lblPlayerAnswer.Name = "lblPlayerAnswer";
            this.lblPlayerAnswer.Size = new System.Drawing.Size(257, 31);
            this.lblPlayerAnswer.TabIndex = 1;
            this.lblPlayerAnswer.Text = "The Players Answer";
            // 
            // btnCorrectAnswer
            // 
            this.btnCorrectAnswer.BackColor = System.Drawing.Color.Blue;
            this.btnCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrectAnswer.ForeColor = System.Drawing.Color.Yellow;
            this.btnCorrectAnswer.Location = new System.Drawing.Point(285, 159);
            this.btnCorrectAnswer.Name = "btnCorrectAnswer";
            this.btnCorrectAnswer.Size = new System.Drawing.Size(177, 63);
            this.btnCorrectAnswer.TabIndex = 2;
            this.btnCorrectAnswer.Text = "Correct";
            this.btnCorrectAnswer.UseVisualStyleBackColor = false;
            this.btnCorrectAnswer.Click += new System.EventHandler(this.btnCorrectAnswer_Click);
            // 
            // btnWrong
            // 
            this.btnWrong.BackColor = System.Drawing.Color.Blue;
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrong.ForeColor = System.Drawing.Color.Yellow;
            this.btnWrong.Location = new System.Drawing.Point(740, 159);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(177, 63);
            this.btnWrong.TabIndex = 3;
            this.btnWrong.Text = "Wrong";
            this.btnWrong.UseVisualStyleBackColor = false;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1198, 264);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnCorrectAnswer);
            this.Controls.Add(this.lblPlayerAnswer);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Name = "AnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Answers";
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblPlayerAnswer;
        private System.Windows.Forms.Button btnCorrectAnswer;
        private System.Windows.Forms.Button btnWrong;
    }
}