using JeopardyApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyApp
{
    class GameMaster
    {
        public static List<Player> PlayerList = new List<Player>();
        public static Button[] dollarButtons;
        public static Label[] categoryLabels;
        public static string question;
        public static string answer;
        public static int pointValue;
        public static GameBoardForm theGameBoard;
        public static QandAForm theQandAForm;
        public static AnswerForm theAnswerForm;
        public static ResultsForm theResultsForm;
        public static OptionsForm theOptionsForm;
        public static string currentPlayer;
        public static string playerAnswer;

        #region Create Forms
        public static void CreateGameBoard()
        {
            theGameBoard = new GameBoardForm();
            theGameBoard.Show();
        }

        public static void CreateQandAForm()
        {
            theQandAForm = new QandAForm();
            theQandAForm.Show();
        }

        public static void CreateAnswerForm()
        {
            theQandAForm.Close();
            theAnswerForm = new AnswerForm();
            theAnswerForm.Show();
        }

        public static void CreateResultsForm()
        {
            theResultsForm = new ResultsForm();
            theResultsForm.Show();
        }

        public static void CreateOptionsForm()
        {
            theOptionsForm = new OptionsForm();
            theOptionsForm.Show();
        }
        #endregion

        public static void CreatePlayerList(string[] playerNames)
        {
            for(int i = 0; i < playerNames.Length; i++)
            {
                PlayerList.Add(new Player(playerNames[i], 0));
            }
        }

        public static void SetQuestionAndAnswer(string theQuestion, string theAnswer, int thePointValue)
        {
            question = theQuestion;
            answer = theAnswer;
            pointValue = thePointValue;
        }

        public static void CheckGameOver()
        {
            int count = 0;
            for(int i = 0; i < dollarButtons.Length; i++)
            {
                if (dollarButtons[i].Enabled == false)
                {
                    count++;
                }
            }

            if (count == 25)
            {
                theAnswerForm.Close();
                SerializeWinner();
                CreateResultsForm();
            }
            else
            {
                theGameBoard.DisplayPlayerInfo();
                theGameBoard.Show();
                theAnswerForm.Close();
            }
        }

        public static void SerializeWinner()
        {
            Player playerWinner = PlayerList[0];
            foreach(Player thePlayer in PlayerList)
            {
                if(thePlayer.Score > playerWinner.Score)
                {
                    playerWinner = thePlayer;
                }else if(PlayerList.Count == 1)
                {
                    playerWinner = PlayerList[0];
                }
            }

            Serializer.SerializeNow(playerWinner);
        }
    }
}
