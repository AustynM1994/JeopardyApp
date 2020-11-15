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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void btnGoToOptions_Click(object sender, EventArgs e)
        {
            GameMaster.CreateOptionsForm();this.Hide();
        }
    }
}
