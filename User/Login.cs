using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaveGame
{
    public partial class Login : Form
    {
        MasterForm mf;
        public Login(MasterForm mf)
        {
            InitializeComponent();

            this.mf = mf;
        }

        #region Login
        private void btlogin_Click(object sender, EventArgs e)
        {
            LoginResult res = UserHandler.login(tbusername.Text, tbpassword.Text);
            switch (res)
            {
                case LoginResult.error:
                    {
                        lberror.Text = "Error";
                    }
                    break;
                case LoginResult.succes:
                    {
                        mf.showMainmenu();
                        this.Close();
                        break;
                    }
            }
        }
        #endregion
        
        #region Register
        private void btregister_Click(object sender, EventArgs e)
        {
            RegisterResult res = UserHandler.register(tbusername.Text, tbpassword.Text);
            switch (res)
            {
                case RegisterResult.error:
                    {
                        lberror.Text = "Error";
                    }
                    break;
                case RegisterResult.succes:
                    {
                        UserHandler.save();
                        mf.showMainmenu();
                        this.Close();
                    }
                    break;
                case RegisterResult.usernametake:
                    {
                        lberror.Text = "Username Taken";
                    }
                    break;
            }
        }
        #endregion
    }
}
