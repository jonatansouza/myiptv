using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Myiptv.database;

namespace Myiptv
{
    public partial class ChannelsForm : Form
    {
        

        
        public ChannelsForm()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void Myiptv_Load(object sender, EventArgs e)
        {
            DatabaseSqliteController dataBaseSqlite = new DatabaseSqliteController();
            dataBaseSqlite.InitializeDatabase();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminArea a = new AdminArea();
            a.Show();
        }
    }
}
