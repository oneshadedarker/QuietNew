using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet
{
    public partial class TitleScreen : Form
    {        
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            this.Hide();
            var gameScreen = new GameScreen();
            gameScreen.FormClosed += (s, args) => this.Close();
            gameScreen.Show();
        }

        private void Options(object sender, EventArgs e)
        {
            var optionsTitle = new OptionsTitle();
            optionsTitle.Show();
        }

        private void Quit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void escButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
