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
        string scope = "channel_stream+channel_read";
        string finalUrl;
        public Twitch()
        {
            
        }

        private string getAccessToken()
        {
            StreamReader reader = new StreamReader("TwitchAccessToken/accessToken.txt");
            var myReturn = reader.ReadToEnd();
            return myReturn;
        }

        public void getChannelStreamKey()
        {
            try
            {
                string myUrl = String.Format("https://api.twitch.tv/kraken/channel?code={0}&client_id={1}&client_secret={2}", getAccessToken(), client_id, client_secret);
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
