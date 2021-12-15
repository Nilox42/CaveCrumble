using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CaveGame
{

    [Serializable]

    public partial class Highscore : Form
    {
        MasterForm mf;

        public Highscore(MasterForm mf0)
        {
            InitializeComponent();
            mf = mf0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        #region ESC
        // Programm mit ESC beenden
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mf.closeprogramm();
            }
        }
        #endregion

        #region MainMenu Button
        private void btMain(object sender, EventArgs e)
        {
            mf.showMainmenu();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }

        private void BtMainHover(object sender, EventArgs e)
        {
            pbMain.Image = Properties.Resources.buttonmainclick;
        }

        private void BtMainLeave(object sender, EventArgs e)
        {
            pbMain.Image = Properties.Resources.buttonmain;
        }
        #endregion

        #region Save Button
        private void pbSpeichern_Click(object sender, EventArgs e)
        {
            HighscoreN.save();
        }

        private void pbSpeichern_MouseHover(object sender, EventArgs e)
        {
            pbSpeichern.Image = Properties.Resources.buttonspeichernclick;
        }

        private void pbSpeichern_MouseLeave(object sender, EventArgs e)
        {
            pbSpeichern.Image = Properties.Resources.buttonspeichern;
        }
        #endregion

        #region Load 
        // load data to rtb
        private void pbLaden_Click(object sender, EventArgs e)
        {
            HighscoreN.load();

            string res = "";
            List<HighscoreN> scores = HighscoreN.getHighscoresSorted();
            foreach (HighscoreN sore in scores)
            {
                res += sore.username + ":" + sore.highscore + "Points" + System.Environment.NewLine;
            }

            rtbHighscores.Text = res;
        }

        private void pbLaden_MouseHover(object sender, EventArgs e)
        {
            pbLaden.Image = Properties.Resources.buttonladenclick;
        }

        private void pbLaden_MouseLeave(object sender, EventArgs e)
        {
            pbLaden.Image = Properties.Resources.buttonladen;
        }
        #endregion

        #region Clear Button
        private void pbClear_Click(object sender, EventArgs e)
        {
            rtbHighscores.Clear();
        }
        private void pbClear_MouseHover(object sender, EventArgs e)
        {
            pbClear.Image = Properties.Resources.buttonclearclick;
        }
        private void pbClear_MouseLeave(object sender, EventArgs e)
        {
            pbClear.Image = Properties.Resources.buttonclear;
        }
        #endregion
    }

}
