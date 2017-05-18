using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KGAPIApp
{
    public partial class Form1 : Form
    {
        Process p;
        Facebook fbObj = new Facebook();
        

        public Form1()
        {
            InitializeComponent();
            fbObj.getTxtInfo();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Facebook.postStatus(txtMessage.Text);
            if (fbObj.isAuthNeeded == true)
            {
                btnAuthorize.Enabled = true;
                btnAuthorize.Visible = true;
            }
        }

        private void btnConnectBot_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Process();
                p.StartInfo.FileName = "DiscordApp\\DiscordBot.exe";
                p.Start();
                btnConnectBot.Enabled = false;
                btnDisconnectBot.Enabled = true;
                btnDisconnectBot.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnectBot_Click(object sender, EventArgs e)
        {
            try
            {
                if (p.HasExited == true)
                {
                    p.Close();
                    btnConnectBot.Enabled = true;
                    btnDisconnectBot.Enabled = false;
                    btnDisconnectBot.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please close out of the DiscordBot app before disconnecting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTweet_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnTweet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            Facebook.getAccessToken();
            btnAuthorize.Enabled = false;
            btnAuthorize.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Facebook.getAccessToken();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Nightbot Login Logic Here
        }

        public void changeBtnSpotify()
        {
            btnLogin.Enabled = false;
            btnLogin.Text = "Logged In";
            btnAvailableDevices.Enabled = true;
        }

        public void reloginButton()
        {
            btnGetChannelID.Enabled = false;
            btnLoginTwitch.Enabled = true;
            btnLoginTwitch.Visible = true;
            Refresh();
        }

        private void btnAvailableDevices_Click(object sender, EventArgs e)
        {
            Spotify spObj = new Spotify();
            spObj.getSpotifyRequest("/v1/me/player/devices");
        }

        private void btnLoginTwitch_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.startLogin();
            btnLoginTwitch.Enabled = false;
            btnLoginTwitch.Visible = false;
            btnGetChannelID.Enabled = true;
        }

        private void btnGetFeed_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getChannelID();
        }

        private void btnChannelFollows_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getStreamKey();
        }

        private void btnFollowerCount_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getFollowerCount();
        }

        private void btnStreamTitle_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getStreamTitle();
        }

        private void btnCurrentGame_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getCurrentGame();
        }

        private void btnTopGames_Click(object sender, EventArgs e)
        {
            Twitch tObj = new Twitch();
            tObj.getChannelViews();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TwitchSettings twitchSettings = new TwitchSettings();
            twitchSettings.Show();
        }
    }
}
