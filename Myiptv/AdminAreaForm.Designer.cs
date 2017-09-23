namespace Myiptv
{
    partial class AdminArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the Code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArea));
            this.nameChannelTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.uploadFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.channelsList = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteChannel = new System.Windows.Forms.Button();
            this.labelIdChannel = new System.Windows.Forms.Label();
            this.buttonUpdateChannel = new System.Windows.Forms.Button();
            this.textBoxCodeChannelEdit = new System.Windows.Forms.TextBox();
            this.textBoxUrlChannelEdit = new System.Windows.Forms.TextBox();
            this.textBoxNameChannelEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxImageChannel = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchChannelTextBox = new System.Windows.Forms.TextBox();
            this.channelsTable = new System.Windows.Forms.DataGridView();
            this.usersList = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.insertChannel = new System.Windows.Forms.TabPage();
            this.groupImage = new System.Windows.Forms.GroupBox();
            this.labelImagePreview = new System.Windows.Forms.Label();
            this.pictureBoxPreviewImage = new System.Windows.Forms.PictureBox();
            this.insertUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.channelsList.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageChannel)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelsTable)).BeginInit();
            this.usersList.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.insertChannel.SuspendLayout();
            this.groupImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImage)).BeginInit();
            this.insertUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameChannelTextBox
            // 
            this.nameChannelTextBox.Location = new System.Drawing.Point(141, 48);
            this.nameChannelTextBox.Name = "nameChannelTextBox";
            this.nameChannelTextBox.Size = new System.Drawing.Size(240, 20);
            this.nameChannelTextBox.TabIndex = 0;
            this.nameChannelTextBox.TextChanged += new System.EventHandler(this.nameChannelTextBox_TextChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(141, 97);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(240, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(141, 143);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(240, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // uploadFile
            // 
            this.uploadFile.Image = ((System.Drawing.Image)(resources.GetObject("uploadFile.Image")));
            this.uploadFile.Location = new System.Drawing.Point(141, 199);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(240, 49);
            this.uploadFile.TabIndex = 4;
            this.uploadFile.UseVisualStyleBackColor = true;
            this.uploadFile.Click += new System.EventHandler(this.uploadFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cadastrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameChannelTextBox);
            this.groupBox1.Controls.Add(this.uploadFile);
            this.groupBox1.Controls.Add(this.urlTextBox);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 342);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Canal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Icone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.AllowDrop = true;
            this.cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("cadastrar.Image")));
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar.Location = new System.Drawing.Point(141, 280);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(240, 41);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // returnButton
            // 
            this.returnButton.Image = ((System.Drawing.Image)(resources.GetObject("returnButton.Image")));
            this.returnButton.Location = new System.Drawing.Point(6, 19);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(66, 58);
            this.returnButton.TabIndex = 0;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.channelsList);
            this.tabControl1.Controls.Add(this.usersList);
            this.tabControl1.Controls.Add(this.insertChannel);
            this.tabControl1.Controls.Add(this.insertUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 480);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // channelsList
            // 
            this.channelsList.Controls.Add(this.groupBox5);
            this.channelsList.Controls.Add(this.groupBox4);
            this.channelsList.Location = new System.Drawing.Point(4, 22);
            this.channelsList.Name = "channelsList";
            this.channelsList.Size = new System.Drawing.Size(759, 454);
            this.channelsList.TabIndex = 3;
            this.channelsList.Text = "Lista de Canais";
            this.channelsList.UseVisualStyleBackColor = true;
            this.channelsList.Click += new System.EventHandler(this.channelsList_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeleteChannel);
            this.groupBox5.Controls.Add(this.labelIdChannel);
            this.groupBox5.Controls.Add(this.buttonUpdateChannel);
            this.groupBox5.Controls.Add(this.textBoxCodeChannelEdit);
            this.groupBox5.Controls.Add(this.textBoxUrlChannelEdit);
            this.groupBox5.Controls.Add(this.textBoxNameChannelEdit);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.pictureBoxImageChannel);
            this.groupBox5.Controls.Add(this.NameLabel);
            this.groupBox5.Location = new System.Drawing.Point(399, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 442);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Editar Canal";
            // 
            // buttonDeleteChannel
            // 
            this.buttonDeleteChannel.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteChannel.Image")));
            this.buttonDeleteChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteChannel.Location = new System.Drawing.Point(63, 391);
            this.buttonDeleteChannel.Name = "buttonDeleteChannel";
            this.buttonDeleteChannel.Size = new System.Drawing.Size(213, 40);
            this.buttonDeleteChannel.TabIndex = 10;
            this.buttonDeleteChannel.Text = "Remover Canal";
            this.buttonDeleteChannel.UseVisualStyleBackColor = true;
            this.buttonDeleteChannel.Click += new System.EventHandler(this.buttonDeleteChannel_Click);
            // 
            // labelIdChannel
            // 
            this.labelIdChannel.AutoSize = true;
            this.labelIdChannel.Location = new System.Drawing.Point(9, 26);
            this.labelIdChannel.Name = "labelIdChannel";
            this.labelIdChannel.Size = new System.Drawing.Size(16, 13);
            this.labelIdChannel.TabIndex = 9;
            this.labelIdChannel.Text = "Id";
            this.labelIdChannel.Click += new System.EventHandler(this.label11_Click);
            // 
            // buttonUpdateChannel
            // 
            this.buttonUpdateChannel.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateChannel.Image")));
            this.buttonUpdateChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateChannel.Location = new System.Drawing.Point(63, 345);
            this.buttonUpdateChannel.Name = "buttonUpdateChannel";
            this.buttonUpdateChannel.Size = new System.Drawing.Size(213, 40);
            this.buttonUpdateChannel.TabIndex = 8;
            this.buttonUpdateChannel.Text = "Atualizar Canal";
            this.buttonUpdateChannel.UseVisualStyleBackColor = true;
            this.buttonUpdateChannel.Click += new System.EventHandler(this.buttonUpdateChannel_Click);
            // 
            // textBoxCodeChannelEdit
            // 
            this.textBoxCodeChannelEdit.Location = new System.Drawing.Point(63, 306);
            this.textBoxCodeChannelEdit.Name = "textBoxCodeChannelEdit";
            this.textBoxCodeChannelEdit.Size = new System.Drawing.Size(213, 20);
            this.textBoxCodeChannelEdit.TabIndex = 7;
            // 
            // textBoxUrlChannelEdit
            // 
            this.textBoxUrlChannelEdit.Location = new System.Drawing.Point(63, 260);
            this.textBoxUrlChannelEdit.Name = "textBoxUrlChannelEdit";
            this.textBoxUrlChannelEdit.Size = new System.Drawing.Size(213, 20);
            this.textBoxUrlChannelEdit.TabIndex = 6;
            this.textBoxUrlChannelEdit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxNameChannelEdit
            // 
            this.textBoxNameChannelEdit.Location = new System.Drawing.Point(63, 213);
            this.textBoxNameChannelEdit.Name = "textBoxNameChannelEdit";
            this.textBoxNameChannelEdit.Size = new System.Drawing.Size(213, 20);
            this.textBoxNameChannelEdit.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Url";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // pictureBoxImageChannel
            // 
            this.pictureBoxImageChannel.Location = new System.Drawing.Point(89, 36);
            this.pictureBoxImageChannel.Name = "pictureBoxImageChannel";
            this.pictureBoxImageChannel.Size = new System.Drawing.Size(143, 145);
            this.pictureBoxImageChannel.TabIndex = 2;
            this.pictureBoxImageChannel.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 220);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.searchChannelTextBox);
            this.groupBox4.Controls.Add(this.channelsTable);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 448);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de Canais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Procurar Canal";
            // 
            // searchChannelTextBox
            // 
            this.searchChannelTextBox.Location = new System.Drawing.Point(6, 55);
            this.searchChannelTextBox.Name = "searchChannelTextBox";
            this.searchChannelTextBox.Size = new System.Drawing.Size(378, 20);
            this.searchChannelTextBox.TabIndex = 1;
            this.searchChannelTextBox.TextChanged += new System.EventHandler(this.searchChannelTextBox_TextChanged);
            this.searchChannelTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchChannelTextBox_KeyUp);
            // 
            // channelsTable
            // 
            this.channelsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.channelsTable.Location = new System.Drawing.Point(6, 96);
            this.channelsTable.Name = "channelsTable";
            this.channelsTable.Size = new System.Drawing.Size(378, 346);
            this.channelsTable.TabIndex = 0;
            this.channelsTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.channelsTable_CellEnter);
            // 
            // usersList
            // 
            this.usersList.Controls.Add(this.buttonRemoveUser);
            this.usersList.Controls.Add(this.groupBox3);
            this.usersList.Location = new System.Drawing.Point(4, 22);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(759, 454);
            this.usersList.TabIndex = 2;
            this.usersList.Text = "Usuários";
            this.usersList.UseVisualStyleBackColor = true;
            this.usersList.Click += new System.EventHandler(this.usersList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.usersTable);
            this.groupBox3.Location = new System.Drawing.Point(16, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 412);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Usuarios";
            // 
            // usersTable
            // 
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTable.Location = new System.Drawing.Point(6, 19);
            this.usersTable.Name = "usersTable";
            this.usersTable.Size = new System.Drawing.Size(544, 387);
            this.usersTable.TabIndex = 1;
            this.usersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellContentClick);
            // 
            // insertChannel
            // 
            this.insertChannel.Controls.Add(this.groupImage);
            this.insertChannel.Controls.Add(this.groupBox1);
            this.insertChannel.Location = new System.Drawing.Point(4, 22);
            this.insertChannel.Name = "insertChannel";
            this.insertChannel.Padding = new System.Windows.Forms.Padding(3);
            this.insertChannel.Size = new System.Drawing.Size(759, 454);
            this.insertChannel.TabIndex = 0;
            this.insertChannel.Text = "Inserir Canal";
            this.insertChannel.UseVisualStyleBackColor = true;
            this.insertChannel.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // groupImage
            // 
            this.groupImage.Controls.Add(this.labelImagePreview);
            this.groupImage.Controls.Add(this.pictureBoxPreviewImage);
            this.groupImage.Location = new System.Drawing.Point(419, 15);
            this.groupImage.Name = "groupImage";
            this.groupImage.Size = new System.Drawing.Size(228, 188);
            this.groupImage.TabIndex = 6;
            this.groupImage.TabStop = false;
            this.groupImage.Text = "Imagem Selecionada";
            // 
            // labelImagePreview
            // 
            this.labelImagePreview.AutoSize = true;
            this.labelImagePreview.Location = new System.Drawing.Point(43, 157);
            this.labelImagePreview.Name = "labelImagePreview";
            this.labelImagePreview.Size = new System.Drawing.Size(105, 13);
            this.labelImagePreview.TabIndex = 1;
            this.labelImagePreview.Text = "Aguardando Imagem";
            // 
            // pictureBoxPreviewImage
            // 
            this.pictureBoxPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPreviewImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreviewImage.Image")));
            this.pictureBoxPreviewImage.Location = new System.Drawing.Point(46, 30);
            this.pictureBoxPreviewImage.Name = "pictureBoxPreviewImage";
            this.pictureBoxPreviewImage.Size = new System.Drawing.Size(132, 124);
            this.pictureBoxPreviewImage.TabIndex = 0;
            this.pictureBoxPreviewImage.TabStop = false;
            // 
            // insertUser
            // 
            this.insertUser.Controls.Add(this.groupBox2);
            this.insertUser.Location = new System.Drawing.Point(4, 22);
            this.insertUser.Name = "insertUser";
            this.insertUser.Padding = new System.Windows.Forms.Padding(3);
            this.insertUser.Size = new System.Drawing.Size(759, 454);
            this.insertUser.TabIndex = 1;
            this.insertUser.Text = "Inserir Usuario";
            this.insertUser.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(180, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Usuário";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(83, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(83, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nome";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(83, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(83, 97);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(240, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveUser.Image")));
            this.buttonRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveUser.Location = new System.Drawing.Point(605, 38);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(138, 44);
            this.buttonRemoveUser.TabIndex = 1;
            this.buttonRemoveUser.Text = "Remover Usuario";
            this.buttonRemoveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // AdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminArea";
            this.Text = "MyIpTv Area Administrativa";
            this.Load += new System.EventHandler(this.AdminArea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.channelsList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageChannel)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelsTable)).EndInit();
            this.usersList.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.insertChannel.ResumeLayout(false);
            this.groupImage.ResumeLayout(false);
            this.groupImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImage)).EndInit();
            this.insertUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameChannelTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button uploadFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insertChannel;
        private System.Windows.Forms.TabPage insertUser;
        private System.Windows.Forms.TabPage usersList;
        private System.Windows.Forms.TabPage channelsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView channelsTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchChannelTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox groupImage;
        private System.Windows.Forms.Label labelImagePreview;
        private System.Windows.Forms.PictureBox pictureBoxPreviewImage;
        private System.Windows.Forms.PictureBox pictureBoxImageChannel;
        private System.Windows.Forms.TextBox textBoxNameChannelEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCodeChannelEdit;
        private System.Windows.Forms.TextBox textBoxUrlChannelEdit;
        private System.Windows.Forms.Button buttonUpdateChannel;
        private System.Windows.Forms.Label labelIdChannel;
        private System.Windows.Forms.Button buttonDeleteChannel;
        private System.Windows.Forms.Button buttonRemoveUser;
    }
}