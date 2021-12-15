using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace CaveGame
{
    public enum LoginResult
    {
        error = 1,
        succes = 2
    }

    public enum RegisterResult
    {
        error = 1,
        succes = 2,
        usernametake = 3
    }

    public static class UserHandler
    {
        private static List<User> userlist = new List<User>();
        private static string userlistlocation;
        private static Random random = new Random();

        public static User currentuser;

        public static void Init(string _userlistlocation)//Static classes dont have constructors so you have to call Userhandler.Init() at the start of you application
        {
            userlistlocation = _userlistlocation;
        }

        #region Save / Load
        public static void load()
        {
            if (File.Exists(userlistlocation))
            {
                XmlSerializer x = new XmlSerializer(typeof(List<User>));
                FileStream reader = null;
                try
                {
                    using (reader = new FileStream(userlistlocation, FileMode.Open))
                    {
                        userlist = (List<User>)x.Deserialize(reader);
                        Console.WriteLine("[UserHandler] - " + "Loaded Xml");
                    }
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine("[UserHandler] - XML not found 0  [" + e.Message + "]");
                    Console.ReadKey();
                }
                catch (System.InvalidOperationException e)
                {
                    Console.WriteLine("[UserHandler] - XML Ungültiges Dateiformat  [" + e.Message + "]");
                    Console.ReadKey();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            else
            {
                Console.WriteLine("[UserHandler] - XML NOT FOUND");
            }
        }
        public static void save()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(userlistlocation))
            {
                x.Serialize(writer, userlist);
                writer.Close();
            }
        }
        #endregion

        #region Generral
        public static User createUser(string username, string password)
        {
            //Check inputs, not ment to be only check 
            if (doesUsernameExist(username) || isPasswordSufficiant(password) == false)
            {
                return null;
            }

            User user = new User(generateUniqeUserID(), username, password);
            userlist.Add(user);
            return user;
        }

        public static bool doesUsernameExist(string username)
        {
            bool found = false;
            foreach(User u in userlist)
            {
                if (u.username == username)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
        public static bool isPasswordSufficiant(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (password.Length > 30)
            {
                return false;
            }
            if (password.Contains(' '))
            {
                return false;
            }

            return true;
        }

        public static int generateUniqeUserID()
        {
            while (true)
            {
                int tryint = random.Next();

                if(userlist.Where(u => u.id == tryint).Count() <= 0)
                {
                    return tryint; // If found cancle loop and return generated integer
                }
            }
        }

        public static User getUserByUsername(string username)
        {
            List<User> res = userlist.Where(u => u.username == username).ToList();
            if (res.Count > 0)
            {
                return res[0];
            }

            return null;
        }
        #endregion

        #region Login
        public static LoginResult login(string username, string password)
        {
            User user = getUserByUsername(username);
            if (user != null)
            {
                if (user.password == password)
                {
                    currentuser = user;
                    return LoginResult.succes;
                }
                else
                {
                    return LoginResult.error;
                }
            }

            return LoginResult.error;
        }
        #endregion

        #region Register
        public static RegisterResult register(string username, string password)
        {
            User user = getUserByUsername(username);
            if (user == null)
            {
                if (createUser(username, password) != null)
                {
                    currentuser = user;
                    return RegisterResult.succes;
                }
                else
                {
                    return RegisterResult.error;
                }
            }
            else
            {
                return RegisterResult.usernametake;
            }
        }
        #endregion

        #region En/Decryption
        public static void EncryptFile()
        {
            string password = @"simonundandi";

            if (File.Exists(userlistlocation) == false)
            {
                Console.WriteLine("Cant encrpt file: File not found!");
                return;
            }

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            string cryptFile = userlistlocation + @".NN";
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(userlistlocation, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);

            RMCrypto.Dispose();
            fsIn.Close();
            cs.Close();
            fsCrypt.Close();
        }
        public static void DecryptFile()
        {
            string password = @"simonundandi";

            if (File.Exists(userlistlocation + @".NN") == false)
            {
                Console.WriteLine("Cant decrypt file: File not found!");
                return;
            }

            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(userlistlocation + @".NN", FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(userlistlocation, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("File Decryption failed " + "    " + e.Message);
            }
        }
        #endregion

    }
}