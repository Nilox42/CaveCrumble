using System;
using System.Windows.Forms;

namespace CaveGame
{
    public partial class MainMenu : Form
    {
        MasterForm mf;

        public bool StoryOffen = false;

        public MainMenu(MasterForm mf0)
        {
            InitializeComponent();
            mf = mf0;

            pStory.Hide();
            pStory.Left = 547;
            pStory.Top = 170;
            pStory.Height = 340;
            pStory.Width = 215;
        }

        #region Buttons

        #region Start Knopf
        private void pbStart_Click(object sender, EventArgs e)
        {
            mf.startGame();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }
        //change button if mouse is above it
        private void pbStartHover(object sender, EventArgs e)
        {
            pbStart.Image = Properties.Resources.buttonstartclick;


        }
        //change button of mouse is no longer over it
        private void pbStartLeave(object sender, EventArgs e)
        {
            pbStart.Image = Properties.Resources.Start_animation;
        }
        #endregion

        #region close programm
        private void pbExit_Click(object sender, EventArgs e)
        {
            mf.closeprogramm();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }
        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.buttonExitclickgross;
        }
        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Properties.Resources.buttonExitgross;
        }
        #endregion

        #region Highscore Knopf
        private void pbHighscore_Click(object sender, EventArgs e)
        {
            mf.showhighscore();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }
        private void pbHighscore_MouseHover(object sender, EventArgs e)
        {
            pbHighscore.Image = Properties.Resources.buttonhighscoreclick1;
        }
        private void pbHighscore_MouseLeave(object sender, EventArgs e)
        {
            pbHighscore.Image = Properties.Resources.buttonhighscore;
        }
        #endregion

        #endregion

        #region Tasten Events
        private void MainMenuKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (StoryOffen == false)
                {
                    mf.closeprogramm();
                }
                if (StoryOffen == true)
                {
                    pStory.Hide();
                    StoryOffen = false;
                }
            }
        }
        #endregion

        #region Story Panel
        // -------- Story Panel ----------
        private void pbStory_Click(object sender, EventArgs e)
        {
            pStory.Show();
            StoryOffen = true;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }

        private void pbStoryBeenden_Click(object sender, EventArgs e)
        {
            pStory.Hide();
            StoryOffen = false;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }

        #region Story Knöpfe Hover effekt
        private void pbStory_MouseHover(object sender, EventArgs e)
        {
            pbStory.Image = Properties.Resources.buttonfragezeichenclick;
        }
        private void pbStoryBeenden_MouseHover(object sender, EventArgs e)
        {
            pbStoryBeenden.Image = Properties.Resources.buttonschliessenclick;
        }
        private void pbStory_MouseLeave(object sender, EventArgs e)
        {
            pbStory.Image = Properties.Resources.buttonfragezeichen;
        }
        private void pbStoryBeenden_MouseLeave(object sender, EventArgs e)
        {
            pbStoryBeenden.Image = Properties.Resources.buttonschliessenn;
        }
        #endregion

        #endregion

    }
}
