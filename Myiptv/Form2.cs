﻿using Myiptv.database;
using Myiptv.helpers;
using Myiptv.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myiptv
{
    public partial class AdminArea : Form
    {
        private DatabaseSqliteController databaseSqiteController;
        public OpenFileDialog openFileDialog { get; set; }
        public AdminArea()
        {
            InitializeComponent();
        }

        private void AdminArea_Load(object sender, EventArgs e)
        {
            databaseSqiteController = new DatabaseSqliteController();
            channelsTable.DataSource = databaseSqiteController.SelectAllChannels();
            

        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPreviewImage.Image = ImageHandler.FixedSize(Image.FromFile(openFileDialog.FileName), 128, 128);
                labelImagePreview.Text = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            
            Channel channel = new Channel();
            channel.Name = nameChannelTextBox.Text;
            channel.Url = urlTextBox.Text;
            channel.Code = codeTextBox.Text;
            channel.Icon = File.ReadAllBytes(openFileDialog.FileName);

            Console.WriteLine(channel.ToString());

            if (databaseSqiteController.InsertChannel(channel))
            {
                MessageBox.Show("Canal inserido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na inserção", "Erro!",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ChannelsForm c = new ChannelsForm();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrWhiteSpace(passwordTextBox.Text) || String.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Nenhum campo deve estar vazio e o Username e Password nao devem conter espaços em branco", "Erro no Formulário",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                user.Name = nameTextBox.Text;
                user.Username = usernameTextBox.Text;
                user.Password = passwordTextBox.Text;
                if(databaseSqiteController.InsertUser(user))
                {
                    MessageBox.Show("Usuario inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro na inserção", "Erro!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Console.WriteLine( databaseSqiteController.SelectAllUsers().ToString());


        }

        private void usersList_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedTab == usersList)
            {
                usersTable.DataSource = databaseSqiteController.SelectAllUsers();
            }
            else if (tabControl1.SelectedTab == channelsList)
            {
                channelsTable.DataSource = databaseSqiteController.SelectAllChannels();
            }
        }

        private void channelsList_Click(object sender, EventArgs e)
        {

        }

        private void searchChannelTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchValue = searchChannelTextBox.Text;

            channelsTable.DataSource = databaseSqiteController.SelectAllChannelsByPatern(searchChannelTextBox.Text);
            
        }

        private void channelsTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = channelsTable.Rows[e.RowIndex];
            int id = (int)row.Cells["ID"].Value;
            Console.WriteLine(id + "id");
            Channel channelSeleted = databaseSqiteController.SelectChannelsById(id);
            textBoxNameChannelEdit.Text = channelSeleted.Name;
            textBoxUrlChannelEdit.Text = channelSeleted.Url;
            textBoxCodeChannelEdit.Text = channelSeleted.Code;
            pictureBoxImageChannel.Image =  ImageHandler.FixedSize( Image.FromStream(new MemoryStream(channelSeleted.Icon)), 128, 128 );
        }

        private void imagePreviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void nameChannelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateChannel_Click(object sender, EventArgs e)
        {

        }
    }
}