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
            try
            {
                if (keyIsValid() == true)
                {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[6];
                    finalResult = finalResult.Substring(6);
                    //finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Channel ID: " + finalResult, "Twitch Channel ID", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getStreamKey()
        {
            try
            {
                if (keyIsValid() == true)
                {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[31];
                    finalResult = finalResult.Substring(14);
                    finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Stream Key: " + finalResult, "Twitch Stream Key", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getFollowerCount()
        {
            try
            {
                if (keyIsValid() == true)
                {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[17];
                    finalResult = finalResult.Substring(12);
                    //finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Follower Count: " + finalResult, "Twitch Follower Count", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getStreamTitle()
        {
            try
            {
                if (keyIsValid() == true)
                {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[1];
                    finalResult = finalResult.Substring(10);
                    finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Stream Title: " + finalResult, "Twitch Stream Title", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getCurrentGame()
        {
            try
            {
                if (keyIsValid() == true)
	            {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[4];
                    finalResult = finalResult.Substring(8);
                    finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Current Game: " + finalResult, "Current Twitch Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            }
                else
                {
                    startLogin();
                    keyIsGood = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getChannelViews()
        {
            try
            {
                if (keyIsValid() == true)
	            {
                    var myResult = getTwitchInfo();
                    string[] results = myResult.Split(',');
                    string finalResult = results[16];
                    finalResult = finalResult.Substring(8);
                    //finalResult = finalResult.Remove(finalResult.Count() - 1);
                    MessageBox.Show("Channel Views: " + finalResult, "Twitch Channel Views", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            }
                else
	            {
                    startLogin();
                    keyIsGood = true;
	            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateAccountID()
        {
            StreamReader reader = new StreamReader("Twitch/AccountInfo/clientID.txt");
            string updatedID = reader.ReadToEnd();
            client_id = updatedID;
            reader.Close();
        }

        private void updateAccountSecret()
        {
            StreamReader reader = new StreamReader("Twitch/AccountInfo/clientSecret.txt");
            string updatedSecret = reader.ReadToEnd();
            client_id = updatedSecret;
            reader.Close();
        }

        public string getTwitchInfo()
        {
            updateAccountID();
            updateAccountSecret();
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
                if (ex.Message == "The remote server returned an error: (401) Unauthorized.")
                {
                    MessageBox.Show("There was an error logging you in. Make sure your account info is set. Error Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    startLogin();
                }
                else
                {
                    MessageBox.Show("An error has occured. Make sure your account info is set in the settings page. Error code: " + ex.Message);
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
