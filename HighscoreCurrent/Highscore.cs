using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CaveGame
{

    [Serializable]

    public partial class Highscore : Form
    {
        List<int> highscores;
        MasterForm mf;

        public Highscore(MasterForm mf0,List<int> punktzahl0)
        {
            InitializeComponent();
            mf = mf0;
            highscores = punktzahl0;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            highscores.Sort();
            highscores.Reverse();

            #region RichTextBox
            int index = 1;
            foreach(int i in highscores)
            {
                rtbHighscores.Text = rtbHighscores.Text + "               Place " + index+": " + i.ToString()+ "Seconds" + "\n";
                index++;
            }
            #endregion
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
            try
            {
                HighscoreData hd = new HighscoreData();
                string speicherHighscore = Directory.GetCurrentDirectory();

                hd.rtbHighscores = rtbHighscores.Text;

                hd.save(Path.Combine(speicherHighscore + @"\Content\highscore") + "\\HighscoreDaten.txt");

            }
            catch (Exception ex)
            {
            }
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
            try
            {
                string savelocation = Directory.GetCurrentDirectory();
                HighscoreData hd = new HighscoreData();

                hd = hd.load(Path.Combine(savelocation + @"\Content\highscore") + "\\HighscoreDaten.txt");

                rtbHighscores.Text = hd.rtbHighscores;
            }
            catch (Exception ex)
            {

            }
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
