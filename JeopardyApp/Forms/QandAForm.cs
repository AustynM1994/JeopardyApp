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
    public partial class QandAForm : Form
    {

        public QandAForm()
        {
            InitializeComponent();
        }

        private void QandAForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < GameMaster.PlayerList.Count; i++)
            {
                cmbBxPlayers.Items.Add(GameMaster.PlayerList[i].Name);
            }

            lblQuestion.Text = GameMaster.question;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cmbBxPlayers.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Select the player that is answering the question");
            }else if(txtBxAnswer.Text == "")
            {
                MessageBox.Show("Enter an answer.");
            }else
            {
                GameMaster.playerAnswer = txtBxAnswer.Text;
                GameMaster.currentPlayer = cmbBxPlayers.SelectedItem.ToString();
                GameMaster.CreateAnswerForm();
            }
        }
    }
}