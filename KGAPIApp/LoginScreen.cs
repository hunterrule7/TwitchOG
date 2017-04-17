using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Dynamic;
using System.Net;
using System.IO;

namespace KGAPIApp
{
    public partial class LoginScreen : Form
    {
        private const string AppId = "1717601725124510";
        private Uri _loginUrl;
        private const string _ExtendedPermissions = "email, publish_actions, user_posts, user_status, manage_pages";
        FacebookClient fbClient = new FacebookClient();
        Facebook myFBObj = new Facebook();
        char mySplitter = '"';
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            FacebookClient fbClient = new FacebookClient();
            dynamic parameters = new ExpandoObject();
            parameters.client_id = AppId;
            //parameters.client_secret = "c52bbc56700c90faba4f953075d49889";
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            parameters.response_type = "token";
            parameters.display = "popup";

            if (!string.IsNullOrWhiteSpace(_ExtendedPermissions))
            {
                parameters.scope = _ExtendedPermissions;
            }

            var fb = new FacebookClient();
            _loginUrl = fb.GetLoginUrl(parameters);
            webBrowserLogin.Navigate(_loginUrl.AbsoluteUri);
        }

        private void extendTokenLife(string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://graph.facebook.com/oauth/access_token?grant_type=fb_exchange_token&amp&client_id=1717601725124510&amp&client_secret=c52bbc56700c90faba4f953075d49889&amp&fb_exchange_token=" + token);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd();
                result = result.Substring(17);
                var finishedResult = result.Split(mySplitter);
                myFBObj.myAccessToken = finishedResult[0];
                // This is new code
                StreamWriter myWriter = new StreamWriter("AccessToken/myAccessToken.txt");
                myWriter.WriteLine(finishedResult[0]);
                myWriter.Close();
            }
        }

        private void webBrowserLogin_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var fb = new FacebookClient();
            FacebookOAuthResult oauthResult; //helps to streamline parsing
            if (fb.TryParseOAuthCallbackUrl(e.Url, out oauthResult))
            { //type of fb is FacebookClient of c# sdk
                if (oauthResult.IsSuccess)
                {
                    myFBObj.myAccessToken = oauthResult.AccessToken;
                    extendTokenLife(oauthResult.AccessToken);
                    //from here start reaing user's feed with the help of access token
                }
            }
        }

        private void webBrowserLogin_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }
    }
}
