using Quiet.Locations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quiet
{
    public partial class GameScreen : Form
    {
        Timer t1 = new Timer();

        private PlayerChar playerChar;

        Location newLocation = new Location(1, "home", "this is your home");

        //private Image file;

        public GameScreen()
        {
            InitializeComponent();

            // Initializes and creates the player and player attributes.
            playerChar = new PlayerChar(10, 10, 20, 0, 1);
                       
            playerChar.CurrentEssence = 10;
            playerChar.MaxEssence = 10;
            
            // Gets values and assigns them to labels.
            lblHitPoints.Text = playerChar.CurrentHealth.ToString();
            lblEssence.Text = playerChar.CurrentEssence.ToString();
            lblGold.Text = playerChar.Gold.ToString();
            lblExperience.Text = playerChar.ExpPoints.ToString();
            lblLevel.Text = playerChar.CurrentLevel.ToString();

            // Set opacity and fade in of window.
            Opacity = 0;

            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();
            else
                Opacity += 0.05;
        }

        private void startDialogue(object sender, EventArgs e)
        {
            Bitmap bitmap1 = new Bitmap(@"C:\Users\FireWhisper\source\repos\Quiet\Properties\Assets\DialogueBox.bmp");

            //gets rid of any duplicate picture boxes.
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bitmap1.Clone(
                new Rectangle(0, 0, bitmap1.Width, bitmap1.Height),
                System.Drawing.Imaging.PixelFormat.DontCare);
        }        
    }
}
