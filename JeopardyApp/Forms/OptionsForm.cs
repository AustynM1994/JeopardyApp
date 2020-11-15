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
    public partial class OptionsForm : Form
    {

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(lstBxDisplayNames.Items.Count == 0)
            {
                MessageBox.Show("You must have at least one player.");
            }else
            {
                string[] playerNames = lstBxDisplayNames.Items.OfType<string>().ToArray();
                GameMaster.CreatePlayerList(playerNames);

                GameMaster.CreateGameBoard(); this.Hide();
            }            
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if(lstBxDisplayNames.Items.Count < 3 && txtBxPlayerName.Text != "")
            {
                lstBxDisplayNames.Items.Add(txtBxPlayerName.Text);
            }else
            {
                MessageBox.Show("Player must have a name and you can only create 3 players.");
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxDisplayNames.Items.RemoveAt(lstBxDisplayNames.SelectedIndex);
            }catch
            {
                MessageBox.Show("You must select a player to remove.");
            }
        }
    }
}
