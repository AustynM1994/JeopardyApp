using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyApp.Forms
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            lblPlayerAnswer.Text = $"{GameMaster.currentPlayer} answered: {GameMaster.playerAnswer}";
            lblCorrectAnswer.Text = $"The correct answer is: {GameMaster.answer}";
        }

        private void btnCorrectAnswer_Click(object sender, EventArgs e)
        {
            foreach(Player player in GameMaster.PlayerList)
            {
                if(player.Name.ToUpper() == GameMaster.currentPlayer.ToUpper())
                {
                    MessageBox.Show($"{player.Name} got the question correct!");
                    player.Score += GameMaster.pointValue;

                    GameMaster.CheckGameOver();
                }
            }
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            foreach (Player player in GameMaster.PlayerList)
            {
                if (player.Name.ToUpper() == GameMaster.currentPlayer.ToUpper())
                {
                    MessageBox.Show($"{player.Name} got the question wrong!");
                    player.Score -= GameMaster.pointValue;

                    GameMaster.CheckGameOver();
                }
            }
        }
    }
}
