using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace CaveGame
{
    public partial class GameForm : Form
    {
        MasterForm mf;

        #region Varibles

        private List<PictureBox> allenemies = new List<PictureBox>();
        private int speed = 0;
        

        // Spielbereich deffinieren
        private static int maxX = 1130;
        private static int minX = 60;

        private static int maxY = 621 - 72;
        private static int minY = 0;

        // Schwierigkeit festlegen
        public int gameSpeed { get; set; } = 5;
        private int difficulty { get; set; } = 0;
        public int seconds { get; set; } = 0;


        public bool canchangebackground = true;
        public bool pausemenuisopen = false;
        int lives = 3;

        Random r = new Random();

        Timer tick = null;
        Timer tDifficulty = null;
        #endregion

        public GameForm(MasterForm mf0)
        {
            InitializeComponent();
            mf = mf0;
            SMediaPlayer.URL = Application.StartupPath + @"\Content\Audio\SpielMusik.mp3";
            SMediaPlayer.settings.volume = 10;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            SMediaPlayer.controls.play();

            // Pause menu and size
            {
                pPause.Hide();
                pPause.Left = 547;
                pPause.Top = 170;
                pPause.Height = 340;
                pPause.Width = 215;
            }

            //Add Enemie to list and set start positions of all enemies
            {
                allenemies.Add(pbstone0);

                pbstone0.Top = -100;
                pbstone1.Top = -100;
                pbstone2.Top = -100;
                pbstone3.Top = -100;
                pbstone4.Top = -100;
                pbstone5.Top = -100;
                pbstone6.Top = -100;
                pbstone7.Top = -100;
                pbbigstone.Top = -100;
            }

            // Events
            this.KeyDown += Game_KeyDown;
            this.KeyUp += Form1_KeyUp;


            // Gameupdater (Gameloop)
            tick = new Timer();
            tick.Interval = 0003;
            tick.Tick += Tick_Tick;
            tick.Start();

            // Increase Difficulty
            tDifficulty = new Timer();
            tDifficulty.Interval = 1000;
            tDifficulty.Tick += tDifficulty_Tick;
            tDifficulty.Start();
        }

        #region Audio
        public static WMPLib.WindowsMediaPlayer SMediaPlayer =new WMPLib.WindowsMediaPlayer();

        // ----------- Sound Serrings in pausemenue -------------
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            GameForm.SMediaPlayer.controls.play();            
            GameForm.SMediaPlayer.settings.volume = trackBar1.Value;
        }
        #endregion

        #region Input
        // Bewegung des Spielers +  geschwindigkeit beim drücken der taste
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && speed == 0)
            {
                if (seconds <=100)
                {
                    speed = -5;
                }
                if(seconds> 100)
                {
                    speed = -8;
                }
            }
            if (e.KeyCode == Keys.D && speed == 0)
            {
                if (seconds <= 100)
                {
                    speed = 5;
                }
                if (seconds > 100)
                {
                    speed = 8;
                }
                
            }

            // Close game when ESC is pressed
            if (e.KeyCode == Keys.Escape)
            {
                if (pausemenuisopen == false)
                {
                    trackBar1.Hide();

                    pPause.Show();
                    tick.Stop();
                    tDifficulty.Stop();
                    pausemenuisopen = true;
                }
                else
                {
                    tDifficulty.Start();
                    tick.Start();
                    pPause.Hide();
                    pausemenuisopen = false;
                }
            }
        }

        //Reset speed when key is released
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && speed == -5)
            {
                speed = 0;
            }
            if (e.KeyCode == Keys.D && speed == 5)
            {
                speed = 0;
            }
            if (e.KeyCode == Keys.A && speed == -8)
            {
                speed = 0;
            }
            if (e.KeyCode == Keys.D && speed == 8)
            {
                speed = 0;
            }
        }
        #endregion

        #region Update
        // Updatet player an enemies
        private void Tick_Tick(object sender, EventArgs e)
        {
            movePlayer();
            moveenemies();
            changeBackground();
        }
        private void tDifficulty_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 2)
            {
                allenemies.Add(pbstone1);
                allenemies.Add(pbstone2);
                difficulty++;
            }
            if (seconds == 10)
            {
                allenemies.Add(pbstone3);
                difficulty++;
            }
            if (seconds == 15)
            {
                allenemies.Add(pbstone4);
                difficulty++;
            }
            if (seconds == 20)
            {
                allenemies.Add(pbstone5);
                allenemies.Add(pbbigstone);
                difficulty++;

                gameSpeed++;
            }
            if (seconds == 25)
            {
                allenemies.Add(pbstone6);
                difficulty++;
            }
            if (seconds == 30)
            {
                allenemies.Add(pbstone7);
                difficulty++;
            }
            if (seconds == 50)
            {
                difficulty++;
            }
            if (seconds == 40)
            {
                gameSpeed++;
            }
            if (seconds == 60)
            {
                gameSpeed++;
            }
            if (seconds == 75)
            {
                difficulty++;
            }
            if (seconds == 80)
            {
                gameSpeed++;
            }
            if (seconds == 100)
            {
                difficulty++;
            }
            if (seconds == 150)
            {
                difficulty++;
            }

            //Update UI
            lbschwierigkeit.Text = difficulty.ToString();
            lbscore.Text = seconds.ToString();
        }

        public void movePlayer()
        {
            //Begrenzt spielbereich
            if (pbspieler.Left > minX && pbspieler.Left < maxX)
            {
                pbspieler.Left = pbspieler.Left + speed;
            }
            //setzt links zurück
            if (pbspieler.Left <= minX)
            {
                pbspieler.Left = pbspieler.Left + 5;
            }
            //setzt rechts zurück
            if (pbspieler.Left >= maxX)
            {
                pbspieler.Left = pbspieler.Left - 5;
            }
        }

        private void moveenemies()
        {
            foreach (PictureBox p in allenemies)
            {
                if (p.Top >= maxY)
                {
                    resetenemies(p);
                }
                else
                {
                    p.Top = p.Top + gameSpeed;
                }

                // on hit decrement lives
                if (pbspieler.Bounds.IntersectsWith(p.Bounds))
                {
                    SoundPlayer damagesound = new SoundPlayer(Application.StartupPath + @"\Content\Audio\damage.wav");
                    damagesound.Play();
                    takedamage(1);
                    resetenemies(p);
                }
                foreach (PictureBox b in allenemies)
                {
                    if (p != b && p.Bounds.IntersectsWith(b.Bounds))
                    {
                        resetenemies(p);
                    }
                }
            }
        }
        private void resetenemies(PictureBox p)
        {
            p.Top = minY - 72;
            p.Left = r.Next(minX, maxX);
        }

        public void changeBackground()
        {
            if (seconds == 25 && canchangebackground == true)
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Content\Stage\Stage2.png");
                canchangebackground = false;
            }
            if (seconds == 26 && canchangebackground == false)
            {
                canchangebackground = true;
            }

            if (seconds == 50 && canchangebackground == true)
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Content\Stage\Stage3.png");
                canchangebackground = false;
            }
            if (seconds == 51 && canchangebackground == false)
            {
                canchangebackground = true;
            }

            if (seconds == 75 && canchangebackground == true)
            {
                this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Content\Stage\Stage4.png");
                canchangebackground = false;
            }
            if (seconds == 76 && canchangebackground == false)
            {
                canchangebackground = true;
            }

            if (seconds == 100 && canchangebackground == true)
            {
                {
                    pbbigstone.InitialImage = null;
                    pbstone0.InitialImage = null;
                    pbstone1.InitialImage = null;
                    pbstone2.InitialImage = null;
                    pbstone3.InitialImage = null;
                    pbstone4.InitialImage = null;
                    pbstone5.InitialImage = null;
                    pbstone6.InitialImage = null;
                    pbstone7.InitialImage = null;
                }

                SMediaPlayer.controls.stop();
                SMediaPlayer.URL = Application.StartupPath + @"\Content\Audio\SpielMusik2.mp3";
                SMediaPlayer.controls.play();

                {
                    pbbigstone.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone0.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone1.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone2.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone3.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone4.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone5.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone6.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    pbstone7.Image = Image.FromFile(Application.StartupPath + @"\Content\Textures\firebollto.png");
                    this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Content\Stage\Stage5.png");
                }
                canchangebackground = false;

            }
            if (seconds == 101 && canchangebackground == false)
            {
                canchangebackground = true;
            }
        }
        #endregion

        #region Damage
        public void takedamage(int schaden)
        {
            lives = lives - schaden;
            if (lives <= 0)
            {
                Death();
            }
            if (lives == 1)
            {
                pbleben2.Visible = false;
            }
            if (lives == 2)
            {
                pbleben1.Visible = false;
            }
        }

        private void Death()
        {
            //todessound
            SoundPlayer death = new SoundPlayer(Application.StartupPath + @"\Content\Audio\Death.wav");
            death.Play();

            tick.Stop();
            tDifficulty.Stop();
            SMediaPlayer.controls.stop();

            mf.gameOver(seconds);
            mf.showhighscore();
        }
        #endregion

        #region Pausemenü
        private void pbBeenden(object sender, EventArgs e)
        {
            mf.showMainmenu();           
            tick.Stop();
            tDifficulty.Stop();
            SMediaPlayer.controls.stop();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Application.StartupPath + @"\Content\Audio\buttonclick.wav");
            sound.Play();
        }

        private void PbWeiter_Click(object sender, EventArgs e)
        {
            tDifficulty.Start();
            tick.Start();
            pPause.Hide();
            trackBar1.Enabled = false;
            trackBar1.Enabled = true;
        }
        #endregion

        #region illumintate buttons
        // ------ Button highlight --------
        private void pbWeiter_MouseHover(object sender, EventArgs e)
        {
            pbNext.Image = Properties.Resources.buttonresumeclick;
        }

        private void pbWeiter_MouseLeave(object sender, EventArgs e)
        {
            pbNext.Image = Properties.Resources.buttonresume;
        }

        private void pbschließenMouseHover(object sender, EventArgs e)
        {
            
            pbclose.Image = Properties.Resources.buttonExitclick;
        }

        private void pbschließenMouseLeave(object sender, EventArgs e)
        {
           
            pbclose.Image = Properties.Resources.buttonExit;
        }
        #endregion

    }
}
