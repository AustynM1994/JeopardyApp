using JeopardyApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace JeopardyApp
{
    public partial class GameBoardForm : Form
    {
        public GameBoardForm()
        {
            InitializeComponent();
        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
            Label[] categoryLabels = CreateCategoryLabelArray();
            Button[] dollarButtons = CreateDollarButtonArray();
            GameMaster.dollarButtons = dollarButtons;
            GameMaster.categoryLabels = categoryLabels;

            DisplayPlayerInfo();

            var xml = XDocument.Load("Jeopardy.xml");

            var categoryQuery = from c in xml.Root.Descendants("category") select c.Attribute("name");
            int index = 0;
            foreach (string name in categoryQuery)
            {
                categoryLabels[index].Text = name;
                index++;
            }

            var oneHundredDollarQuery = from c in xml.Root.Descendants("first") select c.Attribute("points");
            DisplayBoard(0, oneHundredDollarQuery, dollarButtons);

            var twoHundredDollarQuery = from c in xml.Root.Descendants("second") select c.Attribute("points");
            DisplayBoard(1, twoHundredDollarQuery, dollarButtons);

            var threeHundredDollarQuery = from c in xml.Root.Descendants("third") select c.Attribute("points");
            DisplayBoard(2, threeHundredDollarQuery, dollarButtons);

            var fourHundredDollarQuery = from c in xml.Root.Descendants("fourth") select c.Attribute("points");
            DisplayBoard(3, fourHundredDollarQuery, dollarButtons);

            var fiveHundredDollarQuery = from c in xml.Root.Descendants("fifth") select c.Attribute("points");
            DisplayBoard(4, fiveHundredDollarQuery, dollarButtons);
        }
        
        public void DisplayPlayerInfo()
        {
            for(int i = 0; i < GameMaster.PlayerList.Count; i++)
            {
                if(i == 0)
                {
                    lblPlayerOne.Text = $"{GameMaster.PlayerList[0].Name}\nScore: {GameMaster.PlayerList[0].Score}";
                }else if(i == 1)
                {
                    lblPlayerTwo.Text = $"{GameMaster.PlayerList[1].Name}\nScore: {GameMaster.PlayerList[1].Score}";
                }else if (i == 2)
                {
                    lblPlayerThree.Text = $"{GameMaster.PlayerList[2].Name}\nScore: {GameMaster.PlayerList[2].Score}";
                }
            }
        }

        public void DisplayBoard(int index, IEnumerable<XAttribute> query, Button[] btnArray)
        {
            foreach (string amnt in query)
            {
                btnArray[index].Text += amnt;
                index += 5;
            }
        }

        public Label[] CreateCategoryLabelArray()
        {
            Label[] categoryLabels = new Label[5];
            categoryLabels[0] = this.lblCategoryOne;
            categoryLabels[1] = this.lblCategoryTwo;
            categoryLabels[2] = this.lblCategoryThree;
            categoryLabels[3] = this.lblCategoryFour;
            categoryLabels[4] = this.lblCategoryFive;

            return categoryLabels;
        }

        public Button[] CreateDollarButtonArray()
        {
            Button[] dollarButtons = new Button[25];
            dollarButtons[0] = this.btnDollarOneOne;
            dollarButtons[1] = this.btnDollarOneTwo;
            dollarButtons[2] = this.btnDollarOneThree;
            dollarButtons[3] = this.btnDollarOneFour;
            dollarButtons[4] = this.btnDollarOneFive;
            dollarButtons[5] = this.btnDollarTwoOne;
            dollarButtons[6] = this.btnDollarTwoTwo;
            dollarButtons[7] = this.btnDollarTwoThree;
            dollarButtons[8] = this.btnDollarTwoFour;
            dollarButtons[9] = this.btnDollarTwoFive;
            dollarButtons[10] = this.btnDollarThreeOne;
            dollarButtons[11] = this.btnDollarThreeTwo;
            dollarButtons[12] = this.btnDollarThreeThree;
            dollarButtons[13] = this.btnDollarThreeFour;
            dollarButtons[14] = this.btnDollarThreeFive;
            dollarButtons[15] = this.btnDollarFourOne;
            dollarButtons[16] = this.btnDollarFourTwo;
            dollarButtons[17] = this.btnDollarFourThree;
            dollarButtons[18] = this.btnDollarFourFour;
            dollarButtons[19] = this.btnDollarFourFive;
            dollarButtons[20] = this.btnDollarFiveOne;
            dollarButtons[21] = this.btnDollarFiveTwo;
            dollarButtons[22] = this.btnDollarFiveThree;
            dollarButtons[23] = this.btnDollarFiveFour;
            dollarButtons[24] = this.btnDollarFiveFive;
            return dollarButtons;
        }
        private void GoToQandA(string questionNumberInCategory, string points, int arrayPosition)
        {
            XDocument xml = XDocument.Load("Jeopardy.xml");
            string[] answers = new string[5];
            string[] questions = new string[5];
            int count = 0;

            IEnumerable<XElement> list1 =
                from el in xml.Descendants(questionNumberInCategory)
                where (string)el.Attribute("points") == points
                select el;

            foreach (XElement el in list1)
            {
                answers[count] = el.Attribute("answer").Value;
                questions[count] = el.Value;
                count++;
            }

            GameMaster.SetQuestionAndAnswer(questions[arrayPosition], answers[arrayPosition], Int32.Parse(points));

            GameMaster.CreateQandAForm(); this.Hide();
        }
        #region Dollar Buttons
        private void btnDollarOneOne_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[0].Enabled = false;
            GoToQandA("first", "100", 0);
        }
        private void btnDollarOneTwo_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[1].Enabled = false;
            GoToQandA("second", "200", 0);
        }
        private void btnDollarOneThree_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[2].Enabled = false;
            GoToQandA("third", "300", 0);
        }
        private void btnDollarOneFour_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[3].Enabled = false;
            GoToQandA("fourth", "400", 0);
        }
        private void btnDollarOneFive_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[4].Enabled = false;
            GoToQandA("fifth", "500", 0);
        }
        private void btnDollarTwoOne_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[5].Enabled = false;
            GoToQandA("first", "100", 1);
        }
        private void btnDollarTwoTwo_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[6].Enabled = false;
            GoToQandA("second", "200", 1);
        }
        private void btnDollarTwoThree_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[7].Enabled = false;
            GoToQandA("third", "300", 1);
        }
        private void btnDollarTwoFour_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[8].Enabled = false;
            GoToQandA("fourth", "400", 1);
        }
        private void btnDollarTwoFive_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[9].Enabled = false;
            GoToQandA("fifth", "500", 1);
        }
        private void btnDollarThreeOne_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[10].Enabled = false;
            GoToQandA("first", "100", 2);
        }
        private void btnDollarThreeTwo_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[11].Enabled = false;
            GoToQandA("second", "200", 2);
        }
        private void btnDollarThreeThree_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[12].Enabled = false;
            GoToQandA("third", "300", 2);
        }
        private void btnDollarThreeFour_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[13].Enabled = false;
            GoToQandA("fourth", "400", 2);
        }
        private void btnDollarThreeFive_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[14].Enabled = false;
            GoToQandA("fifth", "500", 2);
        }
        private void btnDollarFourOne_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[15].Enabled = false;
            GoToQandA("first", "100", 3);
        }
        private void btnDollarFourTwo_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[16].Enabled = false;
            GoToQandA("second", "200", 3);
        }
        private void btnDollarFourThree_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[17].Enabled = false;
            GoToQandA("third", "300", 3);
        }
        private void btnDollarFourFour_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[18].Enabled = false;
            GoToQandA("fourth", "400", 3);
        }
        private void btnDollarFourFive_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[19].Enabled = false;
            GoToQandA("fifth", "500", 3);
        }
        private void btnDollarFiveOne_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[20].Enabled = false;
            GoToQandA("first", "100", 4);
        }
        private void btnDollarFiveTwo_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[21].Enabled = false;
            GoToQandA("second", "200", 4);
        }
        private void btnDollarFiveThree_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[22].Enabled = false;
            GoToQandA("third", "300", 4);
        }
        private void btnDollarFiveFour_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[23].Enabled = false;
            GoToQandA("fourth", "400", 4);
        }
        private void btnDollarFiveFive_Click(object sender, EventArgs e)
        {
            GameMaster.dollarButtons[24].Enabled = false;
            GoToQandA("fifth", "500", 4);
        }
        #endregion
    }
}
