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
        string scope = "channel_stream+channel_read";
        private string finalUrl;
        private bool isDone = false;
        StreamWriter myWriter = new StreamWriter("TwitchAccessToken/accessToken.txt");
        public TwitchLogin()
        {
            InitializeComponent();
            finalUrl = String.Format("https://api.twitch.tv/kraken/oauth2/authorize?response_type=code&client_id={0}&redirect_uri=http://www.kgresources.us&scope={1}", client_id, scope);
        }

        private void TwitchLogin_Load(object sender, EventArgs e)
        {
            getToken();
        }

        // Returns Access Token From the URL
        private string getTokenKey()
        {
            var code = webBrowserLoginTwitch.Url.ToString();
            code = code.Substring(33);
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
                while (isDone == false)
                {
                    if (webBrowserLoginTwitch.Url.ToString() != finalUrl)
                    {
                        var code = getTokenKey();
                        myWriter.WriteLine(code);
                        myWriter.Close();
                        isDone = true;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
