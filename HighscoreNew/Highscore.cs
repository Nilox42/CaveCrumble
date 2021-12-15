using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveGame
{
    internal class HighscoreN
    {
        private string username { get; set; }
        private int highscore { get; set; }

        public HighscoreN(string username, int higscore)
        {
            this.username = username;
            this.highscore = higscore;
        }

        #region Static / Global
        private static List<HighscoreN> highscores = new List<HighscoreN>();

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
            res.Sort();
            return res;
        }
        #endregion

    }
}