using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace KGAPIApp
{
    class Twitch
    {
        string client_id = "pvqyut84yb72gkjqdcac7bwpw6ku4f";
        string client_secret = "6y2s4lnqfqhxhgczrxprdfz9khwuip";
        string scope = "channel_read+channel_stream";
        string channel_id = "66302646";
        string uniqueID = "372612798";  //&oauth_token={2}
        bool keyIsGood = false;
        Form1 myObj = new Form1();
        string finalUrl;
        public Twitch()
        {
            
        }

        private string getAccessToken()
        {
            StreamReader reader = new StreamReader("TwitchAccessToken/accessToken.txt");
            var myReturn = reader.ReadToEnd();
            reader.Close();
            return myReturn;
        }

        private bool keyIsValid()
        {
            StreamReader reader = new StreamReader("TwitchAccessToken/accessToken.txt");
            var token = reader.ReadToEnd();
            reader.Close();
            if (token != "")
            {
                keyIsGood = true;
            }
            return keyIsGood;
        }

        public void getChannelID()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(188);
            myResult = myResult.Remove(8);
            MessageBox.Show("Channel ID: " + myResult, "Twitch Channel ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getStreamKey()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(1676);
            myResult = myResult.Remove(44);
            MessageBox.Show("Stream Key: " + myResult, "Twitch Stream Key", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getFollowerCount()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(818);
            myResult = myResult.Remove(4);
            myResult = myResult.TrimEnd(',');
            MessageBox.Show("Follower Count: " + myResult, "Twitch Follower Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getStreamTitle()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(25);
            myResult = myResult.Remove(100);
            string[] twoResult = myResult.Split('"');
            MessageBox.Show("Stream Title: " + twoResult[0], "Twitch Stream Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getCurrentGame()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(146);
            myResult = myResult.Remove(100);
            string[] twoResult = myResult.Split('"');
            MessageBox.Show("Current Game: " + twoResult[0], "Current Twitch Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void getChannelViews()
        {
            var myResult = getTwitchInfo();
            myResult = myResult.Substring(801);
            myResult = myResult.Remove(6);
            string[] twoResult = myResult.Split(',');
            MessageBox.Show("Channel Views: " + twoResult[0], "Twitch Channel Views", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string getTwitchInfo()
        {
            var result = "";
            try
            {
                if (keyIsValid() == true)
                {
                    string myUrl = String.Format("https://api.twitch.tv/kraken/channel?client_id={0}&oauth_token={1}", client_id, getAccessToken());
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myUrl);
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                        reader.Close();
                        return result;
                    }
                }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
            }
            catch (WebException ex)
            {
                if (ex.Message == "The remote server returned an error:(401) Unauthorized.")
                {
                    MessageBox.Show("There was an error logging you in, please try to re-login. Error Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    startLogin();
                }
                else
                {
                    MessageBox.Show("An error has occured. Error code: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public void startLogin()
        {
            TwitchLogin tLogin = new TwitchLogin();
            tLogin.Show();
        }
    }
}
