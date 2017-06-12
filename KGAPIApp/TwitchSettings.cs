using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Linq;

namespace KGAPIApp
{
    public partial class TwitchSettings : Form
    {
        public TwitchSettings()
        {
            InitializeComponent();
        }

        private void btnSubmitTwitchInfo_Click(object sender, EventArgs e)
        {
            try
            {
                submitID();
                submitSecret();
                MessageBox.Show("Account info successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. Error code: " +  ex.Message);
            }
        }

        private void submitID()
        {
            //StreamWriter writer = new StreamWriter("Twitch/AccountInfo/clientID.txt");
            //writer.WriteLine(txtClientID.Text);
            //writer.Close();
            try
            {
                TOGDataContext db = new TOGDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hunter Gulley\Source\Repos\TwitchOG\KGAPIApp\TwitchOG.mdf;Integrated Security=True");
                Table<TwitchInfo> twitchTable = db.GetTable<TwitchInfo>();
                IQueryable<TwitchInfo> detailQuery = from TwitchInfo in twitchTable where TwitchInfo.Id == 1 select TwitchInfo;
                foreach (TwitchInfo item in detailQuery)
                {
                    item.client_id = txtClientID.Text;
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void submitSecret()
        {
            //StreamWriter writer = new StreamWriter("Twitch/AccountInfo/clientSecret.txt");
            //writer.WriteLine(txtClientSecret.Text);
            //writer.Close();
            try
            {
                TOGDataContext db = new TOGDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hunter Gulley\Source\Repos\TwitchOG\KGAPIApp\TwitchOG.mdf;Integrated Security=True");
                Table<TwitchInfo> twitchTable = db.GetTable<TwitchInfo>();
                IQueryable<TwitchInfo> detailQuery = from TwitchInfo in twitchTable where TwitchInfo.Id == 1 select TwitchInfo;
                foreach (TwitchInfo item in detailQuery)
                {
                    item.client_secret = txtClientSecret.Text;
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
