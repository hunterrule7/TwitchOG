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
    public partial class SpotifyLogin : Form
    {
        private string client_id;
        private string redirect_uri;
        private string myScope;
        private bool isDone;
        private string finalUrl;
        private string access_token;
        private bool isSuccess;

        public SpotifyLogin()
        {
            InitializeComponent();
            client_id = "f12254b8c14a41ac9d7642398d78e62d";
            redirect_uri = "http://kgresources.us";
            myScope = "playlist-read-private";
            finalUrl = String.Format("https://accounts.spotify.com/authorize?client_id={0}&response_type=code&redirect_uri={1}&scope={2}", client_id, redirect_uri, myScope);
            isDone = false;
            isSuccess = false;
        }

        private void refreshAccessToken()
        {
            string myUrl = String.Format("https://accounts.spotify.com/api/token?grant_type=authorization_code&code={0}&redirect_uri={1}&client_id={2}&client_secret={3}");
        }

        private void SpotifyLogin_Load(object sender, EventArgs e)
        {
            loginToSpotify();
        }

        private void loginToSpotify()
        {
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://accounts.spotify.com/authorize?client_id=" + client_id + "&response_type=code&redirect_uri=" + redirect_uri.ToString() +"&scope=" + myScope);
            try
            {
                webBrowserLogin.Navigate(finalUrl);
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(finalUrl);

                //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                //using (var stream = response.GetResponseStream())
                //using (StreamReader reader = new StreamReader(stream))
                //{
                //    var result = reader.ReadToEnd();
                //    MessageBox.Show(result);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getToken()
        {
            return webBrowserLogin.Url.ToString();
        }

        public bool getSuccessValue
        {
            get
            {
                return isSuccess;
            }
        }

        private void webBrowserLogin_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            try
            {
                StreamWriter myWriter = new StreamWriter("SpotifyAccessToken/accessToken.txt");
                while (isDone == false)
                {
                    if (webBrowserLogin.Url.ToString() != finalUrl)
                    {
                        var code = getToken();
                        myWriter.WriteLine(code.Substring(33));
                        myWriter.Close();
                        isDone = true;
                        Close();
                        isSuccess = true;
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
