namespace KGAPIApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FacebookPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblStatusUpdate = new System.Windows.Forms.Label();
            this.DiscordPage = new System.Windows.Forms.TabPage();
            this.btnDisconnectBot = new System.Windows.Forms.Button();
            this.btnConnectBot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pgSpotify = new System.Windows.Forms.TabPage();
            this.btnAvailableDevices = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picBoxSpotifyLogo = new System.Windows.Forms.PictureBox();
            this.pgTwitch = new System.Windows.Forms.TabPage();
            this.btnGetChannelID = new System.Windows.Forms.Button();
            this.btnLoginTwitch = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnGetStreamKey = new System.Windows.Forms.Button();
            this.btnFollowerCount = new System.Windows.Forms.Button();
            this.btnStreamTitle = new System.Windows.Forms.Button();
            this.btnCurrentGame = new System.Windows.Forms.Button();
            this.btnGetChannelViews = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.FacebookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.DiscordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pgSpotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpotifyLogo)).BeginInit();
            this.pgTwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FacebookPage);
            this.tabControl.Controls.Add(this.DiscordPage);
            this.tabControl.Controls.Add(this.pgSpotify);
            this.tabControl.Controls.Add(this.pgTwitch);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(626, 388);
            this.tabControl.TabIndex = 0;
            // 
            // FacebookPage
            // 
            this.FacebookPage.Controls.Add(this.pictureBox2);
            this.FacebookPage.Controls.Add(this.btnAuthorize);
            this.FacebookPage.Controls.Add(this.pictureBox3);
            this.FacebookPage.Controls.Add(this.btnSubmit);
            this.FacebookPage.Controls.Add(this.txtMessage);
            this.FacebookPage.Controls.Add(this.lblStatusUpdate);
            this.FacebookPage.Location = new System.Drawing.Point(4, 22);
            this.FacebookPage.Name = "FacebookPage";
            this.FacebookPage.Padding = new System.Windows.Forms.Padding(3);
            this.FacebookPage.Size = new System.Drawing.Size(618, 362);
            this.FacebookPage.TabIndex = 0;
            this.FacebookPage.Text = "Facebook";
            this.FacebookPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KGAPIApp.Properties.Resources.FEZ_04_512;
            this.pictureBox2.Location = new System.Drawing.Point(585, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Enabled = false;
            this.btnAuthorize.Location = new System.Drawing.Point(335, 313);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(130, 34);
            this.btnAuthorize.TabIndex = 1;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Visible = false;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KGAPIApp.Properties.Resources.Facebook_logo_pngimage___facebook_logopng___moshi_monsters_wiki_a9jmq8uc;
            this.pictureBox3.Location = new System.Drawing.Point(81, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(457, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(471, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 34);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Post";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(22, 115);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(579, 192);
            this.txtMessage.TabIndex = 2;
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatusUpdate.Location = new System.Drawing.Point(19, 95);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(116, 17);
            this.lblStatusUpdate.TabIndex = 1;
            this.lblStatusUpdate.Text = "Status Update:";
            // 
            // DiscordPage
            // 
            this.DiscordPage.Controls.Add(this.btnDisconnectBot);
            this.DiscordPage.Controls.Add(this.btnConnectBot);
            this.DiscordPage.Controls.Add(this.pictureBox1);
            this.DiscordPage.Location = new System.Drawing.Point(4, 22);
            this.DiscordPage.Name = "DiscordPage";
            this.DiscordPage.Size = new System.Drawing.Size(618, 362);
            this.DiscordPage.TabIndex = 2;
            this.DiscordPage.Text = "Discord";
            this.DiscordPage.UseVisualStyleBackColor = true;
            // 
            // btnDisconnectBot
            // 
            this.btnDisconnectBot.Enabled = false;
            this.btnDisconnectBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectBot.Location = new System.Drawing.Point(142, 200);
            this.btnDisconnectBot.Name = "btnDisconnectBot";
            this.btnDisconnectBot.Size = new System.Drawing.Size(325, 46);
            this.btnDisconnectBot.TabIndex = 2;
            this.btnDisconnectBot.Text = "Disconnect Bot";
            this.btnDisconnectBot.UseVisualStyleBackColor = true;
            this.btnDisconnectBot.Visible = false;
            this.btnDisconnectBot.Click += new System.EventHandler(this.btnDisconnectBot_Click);
            // 
            // btnConnectBot
            // 
            this.btnConnectBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectBot.Location = new System.Drawing.Point(142, 148);
            this.btnConnectBot.Name = "btnConnectBot";
            this.btnConnectBot.Size = new System.Drawing.Size(325, 46);
            this.btnConnectBot.TabIndex = 1;
            this.btnConnectBot.Text = "Connect Bot";
            this.btnConnectBot.UseVisualStyleBackColor = true;
            this.btnConnectBot.Click += new System.EventHandler(this.btnConnectBot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KGAPIApp.Properties.Resources.fc0b01fe10a0b8c602fb0106d8189d9b;
            this.pictureBox1.Location = new System.Drawing.Point(142, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pgSpotify
            // 
            this.pgSpotify.Controls.Add(this.btnAvailableDevices);
            this.pgSpotify.Controls.Add(this.btnLogin);
            this.pgSpotify.Controls.Add(this.picBoxSpotifyLogo);
            this.pgSpotify.Location = new System.Drawing.Point(4, 22);
            this.pgSpotify.Name = "pgSpotify";
            this.pgSpotify.Size = new System.Drawing.Size(618, 362);
            this.pgSpotify.TabIndex = 3;
            this.pgSpotify.Text = "Spotify";
            this.pgSpotify.UseVisualStyleBackColor = true;
            // 
            // btnAvailableDevices
            // 
            this.btnAvailableDevices.Enabled = false;
            this.btnAvailableDevices.Location = new System.Drawing.Point(226, 168);
            this.btnAvailableDevices.Name = "btnAvailableDevices";
            this.btnAvailableDevices.Size = new System.Drawing.Size(166, 36);
            this.btnAvailableDevices.TabIndex = 2;
            this.btnAvailableDevices.Text = "Get Available Devices";
            this.btnAvailableDevices.UseVisualStyleBackColor = true;
            this.btnAvailableDevices.Click += new System.EventHandler(this.btnAvailableDevices_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(243, 108);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 35);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picBoxSpotifyLogo
            // 
            this.picBoxSpotifyLogo.Image = global::KGAPIApp.Properties.Resources.Spotify_logo_with_text_svg;
            this.picBoxSpotifyLogo.Location = new System.Drawing.Point(135, 15);
            this.picBoxSpotifyLogo.Name = "picBoxSpotifyLogo";
            this.picBoxSpotifyLogo.Size = new System.Drawing.Size(349, 75);
            this.picBoxSpotifyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSpotifyLogo.TabIndex = 0;
            this.picBoxSpotifyLogo.TabStop = false;
            // 
            // pgTwitch
            // 
            this.pgTwitch.Controls.Add(this.btnGetChannelViews);
            this.pgTwitch.Controls.Add(this.btnCurrentGame);
            this.pgTwitch.Controls.Add(this.btnStreamTitle);
            this.pgTwitch.Controls.Add(this.btnFollowerCount);
            this.pgTwitch.Controls.Add(this.btnGetStreamKey);
            this.pgTwitch.Controls.Add(this.btnGetChannelID);
            this.pgTwitch.Controls.Add(this.btnLoginTwitch);
            this.pgTwitch.Controls.Add(this.pictureBox4);
            this.pgTwitch.Location = new System.Drawing.Point(4, 22);
            this.pgTwitch.Name = "pgTwitch";
            this.pgTwitch.Size = new System.Drawing.Size(618, 362);
            this.pgTwitch.TabIndex = 4;
            this.pgTwitch.Text = "Twitch";
            this.pgTwitch.UseVisualStyleBackColor = true;
            // 
            // btnGetChannelID
            // 
            this.btnGetChannelID.Location = new System.Drawing.Point(113, 111);
            this.btnGetChannelID.Name = "btnGetChannelID";
            this.btnGetChannelID.Size = new System.Drawing.Size(127, 41);
            this.btnGetChannelID.TabIndex = 2;
            this.btnGetChannelID.Text = "Get Channel ID";
            this.btnGetChannelID.UseVisualStyleBackColor = true;
            this.btnGetChannelID.Click += new System.EventHandler(this.btnGetFeed_Click);
            // 
            // btnLoginTwitch
            // 
            this.btnLoginTwitch.Enabled = false;
            this.btnLoginTwitch.Location = new System.Drawing.Point(8, 313);
            this.btnLoginTwitch.Name = "btnLoginTwitch";
            this.btnLoginTwitch.Size = new System.Drawing.Size(127, 41);
            this.btnLoginTwitch.TabIndex = 1;
            this.btnLoginTwitch.Text = "Login";
            this.btnLoginTwitch.UseVisualStyleBackColor = true;
            this.btnLoginTwitch.Visible = false;
            this.btnLoginTwitch.Click += new System.EventHandler(this.btnLoginTwitch_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KGAPIApp.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(120, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(378, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnGetStreamKey
            // 
            this.btnGetStreamKey.Location = new System.Drawing.Point(246, 111);
            this.btnGetStreamKey.Name = "btnGetStreamKey";
            this.btnGetStreamKey.Size = new System.Drawing.Size(127, 41);
            this.btnGetStreamKey.TabIndex = 3;
            this.btnGetStreamKey.Text = "Get Stream Key";
            this.btnGetStreamKey.UseVisualStyleBackColor = true;
            this.btnGetStreamKey.Click += new System.EventHandler(this.btnChannelFollows_Click);
            // 
            // btnFollowerCount
            // 
            this.btnFollowerCount.Location = new System.Drawing.Point(379, 111);
            this.btnFollowerCount.Name = "btnFollowerCount";
            this.btnFollowerCount.Size = new System.Drawing.Size(127, 41);
            this.btnFollowerCount.TabIndex = 4;
            this.btnFollowerCount.Text = "Get Follower Count";
            this.btnFollowerCount.UseVisualStyleBackColor = true;
            this.btnFollowerCount.Click += new System.EventHandler(this.btnFollowerCount_Click);
            // 
            // btnStreamTitle
            // 
            this.btnStreamTitle.Location = new System.Drawing.Point(113, 158);
            this.btnStreamTitle.Name = "btnStreamTitle";
            this.btnStreamTitle.Size = new System.Drawing.Size(127, 41);
            this.btnStreamTitle.TabIndex = 5;
            this.btnStreamTitle.Text = "Get Stream Title";
            this.btnStreamTitle.UseVisualStyleBackColor = true;
            this.btnStreamTitle.Click += new System.EventHandler(this.btnStreamTitle_Click);
            // 
            // btnCurrentGame
            // 
            this.btnCurrentGame.Location = new System.Drawing.Point(246, 158);
            this.btnCurrentGame.Name = "btnCurrentGame";
            this.btnCurrentGame.Size = new System.Drawing.Size(127, 41);
            this.btnCurrentGame.TabIndex = 6;
            this.btnCurrentGame.Text = "Get Current Game";
            this.btnCurrentGame.UseVisualStyleBackColor = true;
            this.btnCurrentGame.Click += new System.EventHandler(this.btnCurrentGame_Click);
            // 
            // btnGetChannelViews
            // 
            this.btnGetChannelViews.Location = new System.Drawing.Point(379, 158);
            this.btnGetChannelViews.Name = "btnGetChannelViews";
            this.btnGetChannelViews.Size = new System.Drawing.Size(127, 41);
            this.btnGetChannelViews.TabIndex = 7;
            this.btnGetChannelViews.Text = "Get Channel Views";
            this.btnGetChannelViews.UseVisualStyleBackColor = true;
            this.btnGetChannelViews.Click += new System.EventHandler(this.btnTopGames_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Gaming\'s Social Media Manager";
            this.tabControl.ResumeLayout(false);
            this.FacebookPage.ResumeLayout(false);
            this.FacebookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.DiscordPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pgSpotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpotifyLogo)).EndInit();
            this.pgTwitch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage FacebookPage;
        private System.Windows.Forms.TabPage DiscordPage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblStatusUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnectBot;
        private System.Windows.Forms.Button btnDisconnectBot;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage pgSpotify;
        private System.Windows.Forms.PictureBox picBoxSpotifyLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAvailableDevices;
        private System.Windows.Forms.TabPage pgTwitch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnLoginTwitch;
        private System.Windows.Forms.Button btnGetChannelID;
        private System.Windows.Forms.Button btnGetStreamKey;
        private System.Windows.Forms.Button btnFollowerCount;
        private System.Windows.Forms.Button btnStreamTitle;
        private System.Windows.Forms.Button btnCurrentGame;
        private System.Windows.Forms.Button btnGetChannelViews;
    }
}

