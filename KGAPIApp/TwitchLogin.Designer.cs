namespace KGAPIApp
{
    partial class TwitchLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserLoginTwitch = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserLoginTwitch
            // 
            this.webBrowserLoginTwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserLoginTwitch.Location = new System.Drawing.Point(0, 0);
            this.webBrowserLoginTwitch.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserLoginTwitch.Name = "webBrowserLoginTwitch";
            this.webBrowserLoginTwitch.Size = new System.Drawing.Size(651, 422);
            this.webBrowserLoginTwitch.TabIndex = 0;
            this.webBrowserLoginTwitch.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowserLoginTwitch_Navigated);
            // 
            // TwitchLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 422);
            this.Controls.Add(this.webBrowserLoginTwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TwitchLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Login";
            this.Load += new System.EventHandler(this.TwitchLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserLoginTwitch;
    }
}