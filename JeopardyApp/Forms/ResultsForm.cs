using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            List<Player> myLeaderboard = DataAdapter.GetWinners();

            foreach(Player winner in myLeaderboard)
            {
                lstBxLeaderboard.Items.Add(winner);
            }
        }
    }
}
