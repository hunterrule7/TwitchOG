using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Facebook; // Used only for access token
using System.Dynamic;

namespace KGAPIApp
{
    class Facebook
    {
        static string myPostUrl = "https://graph.facebook.com/me/feed?message=test&access_token=";
        static string access_token = "EAACEdEosepcBAEl9AI0bHRi2lpROPCQffqZBHdiECnfgwrZAe4ZBHApJTfDAU4Lbek2mOcwr15GZBuhFgpgOlQtPRwtZC0LSs6IISBDH17eRQN25W0LrsZAWPsU1YcgMsfuKRbIGuj2Un27ko6dpWdOGgKQp4bs1dopozxwbXWyp3COWUZA5MjlSbJLKqgp8XEZD";
        static bool postSuccess = false;
        static bool reauthNeeded = false;
        StreamReader myReader = new StreamReader("AccessToken/myAccessToken.txt"); // new code

        public static void postStatus(string message)
        {
            try
            {
                var finalURI = myPostUrl + access_token;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(finalURI);
                var postData = "message=" + message;
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                var result = new StreamReader(response.GetResponseStream()).ReadToEnd();
                postSuccess = true;
            }
            catch (WebException ex)
            {
                MessageBox.Show("An Error has occured. Please try re-authenticating. Error: " + ex.Message);
                reauthNeeded = true;
            }
            catch (Exception ex)
            {
                postSuccess = false;
                MessageBox.Show(ex.Message);
            }
            if (postSuccess == true)
            {
                MessageBox.Show("Status successfully submitted!", "Post Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // New code
        public void getTxtInfo()
        {
            access_token = myReader.ReadToEnd();
            myReader.Close();
        }

        public static void getAccessToken()
        {
            LoginScreen myLS = new LoginScreen();
            myLS.Show();
        }

        public bool isAuthNeeded
        {
            get
            {
                return reauthNeeded;
            }
        }

        public string myAccessToken
        {
            set
            {
                access_token = value;
            }

            get
            {
                return access_token;
            }
        }
    }
}
