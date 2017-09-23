namespace Myiptv
{
    partial class ChannelsForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param Name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChannelsGuest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGuestSearchChannel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGuestIdChannel = new System.Windows.Forms.Label();
            this.labelGuestNameChannel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserSession = new System.Windows.Forms.Label();
            this.labelAdminMode = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxGuestChannel = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAdminArea = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChannelsGuest)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuestChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewChannelsGuest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGuestSearchChannel);
            this.groupBox1.Location = new System.Drawing.Point(11, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canais";
            // 
            // dataGridViewChannelsGuest
            // 
            this.dataGridViewChannelsGuest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewChannelsGuest.Location = new System.Drawing.Point(9, 85);
            this.dataGridViewChannelsGuest.Name = "dataGridViewChannelsGuest";
            this.dataGridViewChannelsGuest.Size = new System.Drawing.Size(384, 265);
            this.dataGridViewChannelsGuest.TabIndex = 0;
            this.dataGridViewChannelsGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChannelsGuest_CellContentClick);
            this.dataGridViewChannelsGuest.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChannelsGuest_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procurar Canal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxGuestSearchChannel
            // 
            this.textBoxGuestSearchChannel.Location = new System.Drawing.Point(9, 48);
            this.textBoxGuestSearchChannel.Name = "textBoxGuestSearchChannel";
            this.textBoxGuestSearchChannel.Size = new System.Drawing.Size(384, 20);
            this.textBoxGuestSearchChannel.TabIndex = 7;
            this.textBoxGuestSearchChannel.TextChanged += new System.EventHandler(this.textBoxGuestSearchChannel_TextChanged);
            this.textBoxGuestSearchChannel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGuestIdChannel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelGuestNameChannel);
            this.groupBox2.Controls.Add(this.pictureBoxGuestChannel);
            this.groupBox2.Location = new System.Drawing.Point(464, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 375);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes do Canal";
            // 
            // labelGuestIdChannel
            // 
            this.labelGuestIdChannel.AutoSize = true;
            this.labelGuestIdChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuestIdChannel.Location = new System.Drawing.Point(113, 216);
            this.labelGuestIdChannel.Name = "labelGuestIdChannel";
            this.labelGuestIdChannel.Size = new System.Drawing.Size(23, 20);
            this.labelGuestIdChannel.TabIndex = 3;
            this.labelGuestIdChannel.Text = "Id";
            // 
            // labelGuestNameChannel
            // 
            this.labelGuestNameChannel.AutoSize = true;
            this.labelGuestNameChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuestNameChannel.Location = new System.Drawing.Point(142, 216);
            this.labelGuestNameChannel.Name = "labelGuestNameChannel";
            this.labelGuestNameChannel.Size = new System.Drawing.Size(51, 20);
            this.labelGuestNameChannel.TabIndex = 1;
            this.labelGuestNameChannel.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bem Vindo ";
            // 
            // labelUserSession
            // 
            this.labelUserSession.AutoSize = true;
            this.labelUserSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserSession.Location = new System.Drawing.Point(189, 23);
            this.labelUserSession.Name = "labelUserSession";
            this.labelUserSession.Size = new System.Drawing.Size(85, 20);
            this.labelUserSession.TabIndex = 9;
            this.labelUserSession.Text = "Visitante!";
            this.labelUserSession.Click += new System.EventHandler(this.labelUserSession_Click);
            // 
            // labelAdminMode
            // 
            this.labelAdminMode.AutoSize = true;
            this.labelAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminMode.ForeColor = System.Drawing.Color.Red;
            this.labelAdminMode.Location = new System.Drawing.Point(99, 43);
            this.labelAdminMode.Name = "labelAdminMode";
            this.labelAdminMode.Size = new System.Drawing.Size(163, 16);
            this.labelAdminMode.TabIndex = 10;
            this.labelAdminMode.Text = "[Modo Administrativo] ";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(675, 485);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(152, 58);
            this.buttonAbout.TabIndex = 11;
            this.buttonAbout.Text = "Sobre";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(107, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Assistir!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxGuestChannel
            // 
            this.pictureBoxGuestChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxGuestChannel.Location = new System.Drawing.Point(107, 32);
            this.pictureBoxGuestChannel.Name = "pictureBoxGuestChannel";
            this.pictureBoxGuestChannel.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxGuestChannel.TabIndex = 0;
            this.pictureBoxGuestChannel.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(716, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(123, 58);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAdminArea
            // 
            this.buttonAdminArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminArea.ForeColor = System.Drawing.Color.Red;
            this.buttonAdminArea.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminArea.Image")));
            this.buttonAdminArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminArea.Location = new System.Drawing.Point(512, 12);
            this.buttonAdminArea.Name = "buttonAdminArea";
            this.buttonAdminArea.Size = new System.Drawing.Size(198, 58);
            this.buttonAdminArea.TabIndex = 3;
            this.buttonAdminArea.Text = "Area Administrativa";
            this.buttonAdminArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdminArea.UseVisualStyleBackColor = true;
            this.buttonAdminArea.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChannelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 587);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.labelAdminMode);
            this.Controls.Add(this.labelUserSession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonAdminArea);
            this.Name = "ChannelsForm";
            this.Text = "MyIpTv - Painel Principal";
            this.Activated += new System.EventHandler(this.ChannelsForm_Activated);
            this.Load += new System.EventHandler(this.Myiptv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChannelsGuest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuestChannel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdminArea;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewChannelsGuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGuestNameChannel;
        private System.Windows.Forms.PictureBox pictureBoxGuestChannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGuestSearchChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserSession;
        private System.Windows.Forms.Label labelAdminMode;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelGuestIdChannel;
    }
}

