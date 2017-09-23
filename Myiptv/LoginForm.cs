using Myiptv.database;
using Myiptv.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myiptv
{
    public partial class LoginForm : Form
    {
        public DatabaseSqliteController databaseSqliteController { get; set; }

        public LoginForm(DatabaseSqliteController db)
        {
            this.databaseSqliteController = db;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User userSession = databaseSqliteController.SelectUserById(textBoxLoginUsername.Text);
            if(userSession == null)
            {
                MessageBox.Show("Usuario Invalido");
            }
            else
            {
                if (userSession.Password == textBoxLoginPassword.Text)
                {
                    databaseSqliteController.UserSession = userSession;
                    this.Close();
                }
            }
        }
    }
}
