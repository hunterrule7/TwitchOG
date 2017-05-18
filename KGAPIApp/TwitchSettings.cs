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
            StreamWriter writer = new StreamWriter("Twitch/AccountInfo/clientID.txt");
            writer.WriteLine(txtClientID.Text);
            writer.Close();
        }

        private void submitSecret()
        {
            StreamWriter writer = new StreamWriter("Twitch/AccountInfo/clientSecret.txt");
            writer.WriteLine(txtClientSecret.Text);
            writer.Close();
        }
    }
}
