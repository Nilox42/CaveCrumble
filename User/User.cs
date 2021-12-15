using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace CaveGame
{
    public class User
    {
        #region save sections
        [XmlElement("ID")]
        public int id { get; set; }

        [XmlElement("Username")]
        public string username { get; set; }

        [XmlElement("Password")]
        public string password { get; set; }

        #endregion


        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }
        public User() { }//Used by XML Serialiser to construct an instance of User

 

    }
}
