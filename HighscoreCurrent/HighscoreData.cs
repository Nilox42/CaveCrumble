using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CaveGame
{
    [Serializable]
    public class HighscoreData
    {
        public string tbLogin { get; set; }
        public string rtbHighscores { get; set; }

        public void save(string path)
        {
            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();
        }

        public HighscoreData load(string path)
        {
            HighscoreData hd = new HighscoreData();
            try
            {
                FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                hd = (HighscoreData)bf.Deserialize(fs);

                return hd;
            }
            catch (Exception)
            {
            }
            return null;

        }

    }
}
