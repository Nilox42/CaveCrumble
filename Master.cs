using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CaveGame
{
    public partial class MasterForm : Form
    {
        MainMenu hauptmenue;
        GameForm spiel;
        Highscore highscore;
        Login login;

        WMPLib.WindowsMediaPlayer MediaPlayer = new WMPLib.WindowsMediaPlayer();
        
        List<int> points = new List<int>();            

        public MasterForm()
        {
            InitializeComponent();

            MediaPlayer.URL = Application.StartupPath + @"\Content\Audio\MainMenuMusik.mp3";
            MediaPlayer.settings.volume = 10;
        }
        private async void MasterForm_Load(object sender, EventArgs e)
        {
            // Main menü laden nachdem Master Form geladen ist
            showLogin();

            MediaPlayer.controls.play();

            await Task.Delay(1);

            this.Hide();
        }

        #region Game
        public void startGame()
        {
            //close Mainmenu
            hauptmenue.Hide();
            hauptmenue.Dispose();

            MediaPlayer.controls.stop();

            spiel = new GameForm(this);
            spiel.Show();
        }

        public void gameOver(int points)
        {
            this.points.Add(points);

            MediaPlayer.controls.play();
        }
        #endregion

        #region show / hide

        public void showLogin()
        {
            login = new Login(this);
            login.Show();
        }
        public void showMainmenu()
        {
            if(spiel != null)
            {
                spiel.Hide();
                spiel.Dispose();
            }
            if (highscore != null)
            {
                highscore.Hide();
                highscore.Dispose();
            }

            //reset hauptmenue
            if (hauptmenue != null)
            {
                hauptmenue.Hide();
                hauptmenue.Dispose();
            }

            MediaPlayer.controls.play();
            hauptmenue = new MainMenu(this);
            hauptmenue.Show();
        }

        public void showhighscore()
        {
            if (spiel != null)
            {
                spiel.Hide();
                spiel.Dispose();
            }
            if (highscore != null)
            {
                highscore.Hide();
                highscore.Dispose();
            }

            if (hauptmenue != null)
            {
                hauptmenue.Hide();
                hauptmenue.Dispose();
            }

            highscore = new Highscore(this, points);
            highscore.Show();

        }

        public void closeprogramm()
        {
            if (spiel != null)
            {
                spiel.Hide();
                spiel.Dispose();
            }
            if (highscore != null)
            {
                highscore.Hide();
                highscore.Dispose();
            }
            if (hauptmenue != null)
            {
                hauptmenue.Hide();
                hauptmenue.Dispose();
            }

            Application.Exit();
        }
        #endregion

    }
}
