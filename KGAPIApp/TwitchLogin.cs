using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace KGAPIApp
{
    public partial class TwitchLogin : Form
    {
        string client_id = "pvqyut84yb72gkjqdcac7bwpw6ku4f";
        string client_secret = "6y2s4lnqfqhxhgczrxprdfz9khwuip";
        string scope = "channel_read+channel_stream";
        string uniqueID = "372612798";
        private string finalUrl;
        private string forceLoginUrl = "https://passport.twitch.tv/authentications/";
        private bool isDone = false;
        StreamWriter myWriter = new StreamWriter("TwitchAccessToken/accessToken.txt");
        public TwitchLogin()
        {
            InitializeComponent();
            finalUrl = String.Format("https://api.twitch.tv/kraken/oauth2/authorize?response_type=token&client_id={0}&redirect_uri=http://www.kgresources.us&scope={1}&force_verify=true", client_id, scope);
        }

        private void TwitchLogin_Load(object sender, EventArgs e)
        {
            getToken();
        }

        // Returns Access Token From the URL
        private string getTokenKey()
        {
            var code = webBrowserLoginTwitch.Url.ToString();
            code = code.Substring(41);
            code = code.Remove(30);
            return code;
        }

        private void getToken()
        {
            webBrowserLoginTwitch.Navigate(finalUrl);
        }

        private void webBrowserLoginTwitch_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            try
            {
                //while (isDone == false)
                //{
                //    if (webBrowserLoginTwitch.Url.ToString() != finalUrl && webBrowserLoginTwitch.Url.ToString().Substring(43) != forceLoginUrl)
                //    {
                //        var code = getTokenKey();
                //        myWriter.WriteLine(code);
                //        myWriter.Close();
                //        isDone = true;
                //        Close();
                //    }
                //}
                //MessageBox.Show(webBrowserLoginTwitch.Url.ToString());
                //var hunter = webBrowserLoginTwitch.Url.ToString().Remove(41);
                //MessageBox.Show(hunter);

                switch (webBrowserLoginTwitch.Url.ToString().Remove(41))
                {
                    case "https://www.kgresources.us/#access_token=":
                        var code = getTokenKey();
                        myWriter.WriteLine(code);
                        myWriter.Close();
                        isDone = true;
                        Close();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
