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
using Myiptv.models;
using Microsoft.VisualBasic;

namespace Myiptv
{
    public partial class ChannelsForm : Form
    {

        private DatabaseSqliteController dataBaseSqliteController;

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
            dataBaseSqliteController = new DatabaseSqliteController();
            dataBaseSqliteController.InitializeDatabase();
            configDataGridViewChannelsGuest(dataBaseSqliteController.SelectAllGuestChannels());
            
        }

        private void configDataGridViewChannelsGuest(List<Channel> Channels)
        {
            dataGridViewChannelsGuest.DataSource = Channels;
            dataGridViewChannelsGuest.Columns["Url"].Visible = false;
            dataGridViewChannelsGuest.Columns["Code"].Visible = false;
            dataGridViewChannelsGuest.Columns["Icon"].Visible = false;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminArea a = new AdminArea();
            a.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(dataBaseSqliteController.UserSession == null)
            {
                LoginForm l = new LoginForm(dataBaseSqliteController);
                l.Show();
            }
            else
            {
                dataBaseSqliteController.UserSession = null;
                guestMode();
            }
            
        }

        private void dataGridViewChannelsGuest_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewChannelsGuest.Rows[e.RowIndex];
            int id = (int)row.Cells["ID"].Value;
            Channel guestChannel = dataBaseSqliteController.SelectChannelsById(id);
            pictureBoxGuestChannel.Image = helpers.ImageHandler.FixedSize(Image.FromStream(new MemoryStream(guestChannel.Icon)), 128, 128);
            labelGuestNameChannel.Text = guestChannel.Name;
            labelGuestIdChannel.Text = guestChannel.Id + "";
        }

        private void dataGridViewChannelsGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string value = textBoxGuestSearchChannel.Text;
            configDataGridViewChannelsGuest(dataBaseSqliteController.SelectAllChannelsByPatern(value));
            
        }

        private void adminMode()
        {
            labelUserSession.Text = dataBaseSqliteController.UserSession.Name;
            buttonAdminArea.Visible = true;
            buttonLogin.Text = "Logout";
            labelAdminMode.Visible = true;
        }
        private void guestMode()
        {
            buttonLogin.Text = "Login";
            buttonAdminArea.Visible = false;
            labelAdminMode.Visible = false;
        }

        private void ChannelsForm_Activated(object sender, EventArgs e)
        {
            configDataGridViewChannelsGuest(dataBaseSqliteController.SelectAllChannels());
            if(dataBaseSqliteController.UserSession != null)
            {
                adminMode();
            }
            else
            {
                guestMode();
            }
            
        }

        private void labelUserSession_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGuestSearchChannel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Channel guestChannel = dataBaseSqliteController.SelectChannelsById(int.Parse(labelGuestIdChannel.Text));
            if (String.IsNullOrEmpty(guestChannel.Code))
            {

                string code = Interaction.InputBox("CANAL PROTEGIDO!\nDigite o Codigo para continuar");
                if(code == guestChannel.Code)
                {
                    System.Diagnostics.Process.Start(guestChannel.Url);
                }
                else
                {
                    MessageBox.Show("Codigo incorreto", "Erro!",
     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                System.Diagnostics.Process.Start(guestChannel.Url);
            }
        }
    }
}
