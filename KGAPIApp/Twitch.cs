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
        string uniqueID = "372612798";
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

        public void getChannelInfo()
        {
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
                        var result = reader.ReadToEnd();
                        reader.Close();
                        MessageBox.Show(result);
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
                MessageBox.Show("There was an error logging you in, please try to re-login. Error Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getChannelFollowers()
        {
            try
            {
                if (keyIsValid() == true)
                {
                    string myUrl = String.Format("https://api.twitch.tv/kraken/channels/{0}/follows?client_id={1}&oauth_token={2}", channel_id, client_id, getAccessToken());
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myUrl);
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                        reader.Close();
                        MessageBox.Show(result);
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
        }

        public void startLogin()
        {
            TwitchLogin tLogin = new TwitchLogin();
            tLogin.Show();
        }
    }
}
