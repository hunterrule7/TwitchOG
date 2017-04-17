using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace KGAPIApp
{
    class Spotify
    {
        private string clientID = "f12254b8c14a41ac9d7642398d78e62d";
        private string clientSecret = "d01fdb31c2b945c5becdf47bbc4cf8f4";
        private string redirectUri = "http://kgresources.us";
        private string scope = "playlist-read-private, 	user-read-recently-played";
        private string access_token = "";
        private string token_type = "Bearer";
        SpotifyLogin sLogin;

        public Spotify()
        {
            sLogin = new SpotifyLogin();
            StreamReader reader = new StreamReader("SpotifyAccessToken/accessToken.txt");
            access_token = reader.ReadToEnd();
        }

        public string getClientID
        {
            get
            {
                return clientID;
            }
        }

        public string getScope
        {
            get
            {
                return scope;
            }
        }

        public string getRedirect
        {
            get
            {
                return redirectUri;
            }
        }

        public void LoginSpotify()
        {
            sLogin.Show();
        }

        public void getSpotifyRequest(string aRequest)
        {
            try
            {
                SpotifyLogin spLogin = new SpotifyLogin();
                StreamWriter writer = new StreamWriter("Spotify/spotifyPage.html");
                string theUrl = "https://accounts.spotify.com";
                //string finalUrl = theUrl + aRequest + "&access_token=" + access_token + token_type;
                string finalUrl = String.Format("{0}{1}?client_id={2}&access_token={3}&authorization={4}&scope={5}", theUrl, aRequest, clientID, access_token, token_type, scope);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(finalUrl);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    writer.WriteLine(result);
                    writer.Close();
                    var p = new Process();
                    p.StartInfo.FileName = "Spotify\\spotifyPage.html";
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
