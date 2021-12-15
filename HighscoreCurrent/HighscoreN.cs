using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveGame
{
    internal class HighscoreN
    {
        #region data that has to be used
        public string username { get; private set; }
        public int highscore { get; private set; }
        #endregion

        #region constructor
        public HighscoreN(string username, int higscore)
        {
            this.username = username;
            this.highscore = higscore;
        }
        #endregion

        #region Static / Global
        private static List<HighscoreN> highscores = new List<HighscoreN>();
        private static string savelocation = Directory.GetCurrentDirectory() + @"\highscores.txt";

        public static void addHighscore(string username, int highscore)
        {
            highscores.Add(new HighscoreN(username, highscore));
        }
        public static void removeUserHighscores(string username)
        {
            HighscoreN h = highscores.Where(u => u.username == username).ToList().ElementAt(0);
            if (h != null)
            {
                highscores.Remove(h);
            }
            else
            {
                Console.WriteLine("User: " + username + " doesnt has a highscore!");
            }
        }

        public static void clearAll()
        {
            highscores.Clear();
        }

        public static HighscoreN getHighscorebyUsername(string username)
        {
            return highscores.Where(highscore => highscore.username == username).ToList().ElementAt(0);
        }

        public static List<HighscoreN> getHighscoresSorted()
        {
            List<HighscoreN> res = highscores.OrderBy(u => u.highscore).ToList();
            res.Reverse();
            return res;
        }

        public static void save()
        {
            List<string> tosave = new List<string>();
            foreach (HighscoreN s in highscores)
            {
                tosave.Add(s.username + ":" + s.highscore);
            }

            File.WriteAllLines(savelocation, tosave);
        }
        public static void load()
        {
            highscores.Clear();
            if (File.Exists(savelocation))
            {
                List<string> loaded = File.ReadAllLines(savelocation).ToList();

                foreach (string s in loaded)
                {
                    string username = s.Split(':')[0];
                    string highscore = s.Split(':')[1];
                    int highscoreint;
                    if (int.TryParse(highscore, out highscoreint))
                    {
                        highscores.Add(new HighscoreN(username, highscoreint));
                    }
                    else
                    {
                        Console.WriteLine("File error: cant convert to int  Username :" + username);
                    }
                }
            }
        }
        #endregion

    }
}