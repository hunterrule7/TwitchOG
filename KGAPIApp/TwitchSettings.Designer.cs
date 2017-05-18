namespace KGAPIApp
{
    partial class TwitchSettings
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
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientSecret = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.btnSubmitTwitchInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.Location = new System.Drawing.Point(112, 9);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(333, 20);
            this.lblAccountInfo.TabIndex = 0;
            this.lblAccountInfo.Text = "Please Enter Your Account Information Below";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(9, 44);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(64, 17);
            this.lblClientID.TabIndex = 1;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.AutoSize = true;
            this.lblClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientSecret.Location = new System.Drawing.Point(12, 87);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(92, 17);
            this.lblClientSecret.TabIndex = 2;
            this.lblClientSecret.Text = "Client Secret:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(12, 64);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(533, 20);
            this.txtClientID.TabIndex = 3;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(12, 107);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(533, 20);
            this.txtClientSecret.TabIndex = 4;
            // 
            // btnSubmitTwitchInfo
            // 
            this.btnSubmitTwitchInfo.Location = new System.Drawing.Point(470, 133);
            this.btnSubmitTwitchInfo.Name = "btnSubmitTwitchInfo";
            this.btnSubmitTwitchInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTwitchInfo.TabIndex = 5;
            this.btnSubmitTwitchInfo.Text = "Submit";
            this.btnSubmitTwitchInfo.UseVisualStyleBackColor = true;
            this.btnSubmitTwitchInfo.Click += new System.EventHandler(this.btnSubmitTwitchInfo_Click);
            // 
            // TwitchSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 168);
            this.Controls.Add(this.btnSubmitTwitchInfo);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblClientSecret);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblAccountInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TwitchSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitch Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientSecret;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Button btnSubmitTwitchInfo;
    }
}